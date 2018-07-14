using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//Access to Google API helper Class = interact with API
using ConsoleApp1.Helper;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbPrevious.Visibility = Visibility.Hidden;
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            GoogleSearch(1);
            tbCurrentPage.Text = "1";
            tbPrevious.Visibility = Visibility.Hidden;
        }

        private void Previous_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            //Convert the current page text to int
            Int32.TryParse(tbCurrentPage.Text, out int start);

            //Calculate the first item in the result set to return from Google Search API (maximum 10 items)
            //Ex: if current page = 2, get the first batch: start = ((2 - 2) * 10) + 1 = 1
            //If current page = 3, get the second batch: start = ((3 - 2) * 10) + 1 = 11 and so on
            if (start > 1)
            {
                tbCurrentPage.Text = (start - 1).ToString();
                start = ((start - 2) * 10) + 1;
            }
            if(tbCurrentPage.Text == "1")
            {
                tbPrevious.Visibility = Visibility.Hidden;
            }

            GoogleSearch(start);
            e.Handled = true;
        }

        private void Next_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Int32.TryParse(tbCurrentPage.Text, out int start);

            //Calculate the first item in the result set to return from Google Search API (maximum 10 items)
            //Ex: If current page = 2, get the third batch: start = (2 * 10) + 1 = 21
            //If current page = 3, get the fourth batch: start = (3 * 10) + 1 = 31
            if (start > 0)
            {
                tbCurrentPage.Text = (start + 1).ToString();
                start = (start * 10) + 1;
            }
            if (tbCurrentPage.Text == "2")
            {
                tbPrevious.Visibility = Visibility.Visible;
            }

            GoogleSearch(start);
            e.Handled = true;
        }

        private void GoogleSearch(int start)
        {
            try
            {
                var search = tbSearchTerm.Text.Trim();
                if (!String.IsNullOrEmpty(search))
                {
                    var gSearch = GoogleAPIsHelper.CustomSearch(search, start);
                    var searchResults = gSearch.Items;

                    lbSearchResult.ItemsSource = searchResults;
                }
            }
            catch (Google.GoogleApiException ex)
            {
                tbErrorMessage.Text = ex.Error.Errors[0].Message + " " + ex.Error.Errors[0].Reason;
            }
        }

        private void Hyperlink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}

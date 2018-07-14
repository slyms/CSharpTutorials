using System;
using System.Collections.Generic;
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

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Constructor - same name as Class
        //Holds code needed to initialize Class
        //Called, when Class instance is created
        public MainWindow()
        {
            //Method - combines C# code with XAML appearance
            InitializeComponent();
            Division(2, 3);
        }

        int a;
        int b;
        int c;

        private void BT_Add_Click(object sender, RoutedEventArgs e)
        {
            a = int.Parse(TXB_1.Text);
            b = int.Parse(TXB_2.Text);
            c = a + b;
            MessageBox.Show(c.ToString());
        }

        private void BT_Substract_Click(object sender, RoutedEventArgs e)
        {
            a = int.Parse(TXB_1.Text);
            b = int.Parse(TXB_2.Text);
            c = a - b;
            MessageBox.Show(c.ToString());
        }

        private void BT_Multiply_Click(object sender, RoutedEventArgs e)
        {
            a = int.Parse(TXB_1.Text);
            b = int.Parse(TXB_2.Text);
            c = a * b;
            MessageBox.Show(c.ToString());
        }

        private void BT_Divide_Click(object sender, RoutedEventArgs e)
        {
            a = int.Parse(TXB_1.Text);
            b = int.Parse(TXB_2.Text);
            c = a / b;
            MessageBox.Show(c.ToString());
        }

            void Division(int x1, int x2)
            {
                MessageBox.Show((x1 - x2).ToString());
            }
    }
}

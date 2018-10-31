using SandeepSoni___Demo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandeepSoni___AccountApplication
{
    public partial class AccountForm : Form
    {
        Account a; //a - Reference Variable of Type Account - Account is a Class; it's not an Account Object

        public AccountForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {    
            //Create button - Constructor is called 3x
            a = new Account();
            Account a1;
            a1 = new Account("Test", 10000); //1st param '1' is deleted <- now id is autoincremented
            Account a2 = new Account(a1);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            //Get data from GUI form controls calculator fields
            //a.Id = int.Parse(txtId.Text); //Comment <- now id is autoincremented
            a.Name = txtName.Text;
            //a.Balance = decimal.Parse(txtBalance.Text);
            a.Deposit(decimal.Parse(txtBalance.Text));
            //a.Balance = 1000000; = Impossible - Balance Set Property is commented out
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            txtId.Text = a.Id.ToString();
            txtName.Text = a.Name;
            txtBalance.Text = a.Balance.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtBalance.Clear(); //Clears field
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            a = null;
        }

        private void btnGC_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void Id_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            a.Deposit(decimal.Parse(txtAmount.Text));
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            a.Withdraw(decimal.Parse(txtAmount.Text));
        }

        private void btnGetGeneration_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GC.GetGeneration(a).ToString());
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            Account a1;
            a1 = new Account();
            a = a1;
        }

        private void btnSetMB_Click(object sender, EventArgs e)
        {
            Account.MinBalance = int.Parse(txtMB.Text);
        }

        private void btnGetMB_Click(object sender, EventArgs e)
        {
            txtMB.Text = Account.MinBalance.ToString();
        }
    }
}

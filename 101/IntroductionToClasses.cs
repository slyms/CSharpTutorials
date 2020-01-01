using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    public class IntroductionToClasses
    {
        public class BankAccount
        {
            public string Number { get; }
            public string Owner { get; set; }
            public decimal Balance { get; }
            // private - separate public Property (Number) from private implementation (how number is generated)
            // static - shared by all Class Objects (value of a non-static variable is unique to each instance of the Class Object)
            private static int accountNumberSeed = 1234567890; 

            public void MakeDeposit(decimal amount, DateTime date, string note)
            {

            }

            public void MakeWithdrawal(decimal amount, DateTime date, string note)
            {

            }

            public BankAccount(string name, decimal initialBalance)
            {
                this.Owner = name;
                this.Balance = initialBalance;
                //Account Number should be assigned when Object is constructed - but it shouldn't be the responsibility of the caller to create it
                this.Number = accountNumberSeed.ToString();
                accountNumberSeed++;
            }
        }
    }
}

using System;
using System.Text;
using System.Windows.Forms;

namespace SandeepSoni___Demo
{
    public class Account
    {
        #region Field Members
        //Account no; ? - can be null
        private int? _Id;

        //Requirement: Id should be set only once
        private bool _IdAlreadySet;
        private String _Name;
        //private - direct, outside the Class changes to Balance are impossible = safety
        //public Method is providing access to private data
        private decimal _Balance; //Money

        public static int _MinBalance = 500; //Static Member
        
        //Req - minimum balance in (0, 5000)
        public static int MinBalance //Static Property
        {
            get
            {
                return _MinBalance;
            }
            set
            {
                if (value < 0 || value > 5000)
                    throw new ApplicationException("Invalid value for Minimum balance (Valid range = 0 to 5000)");
                _MinBalance = value;
            }
        }
        private static int _PrevId; //Previous id of Object
        #endregion

        #region Properties
        //Requirement: Id should be set only once
        public int? Id
        {
            get
            {
                return _Id;
            }
            //Comment <- now id is autoincremented
            //set
            //{
            //    if (_IdAlreadySet)
            //        throw new ApplicationException("Id is already set once and cannot be changed");
            //    _Id = value;
            //    _IdAlreadySet = true;
            //}
        }
        //Requirement: Name should be max 8 chars in length
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value.Length > 8)
                    throw new ApplicationException("Name cannot be more than 8 chars in length");
                _Name = value; //new value will be stored in _Name
            }
        }

        //Requirement: Balance should not be changed externally
        public decimal Balance //_Balance - used inside Class; Balance - outside = Public Member encapsulates Private Member
        {
            get
            {
                return _Balance; //= decimal bal = a.Balance;
            }    
            //If commented = Balance is ready-only Property
            //OR = private set = accesible only inside Class
            private set
            {
                _Balance = value; //= a.Balance = 10000; it's a Method, but outside the Class it's usage is as a Property Field
            }
        }

        //Implicit implementation - can be updated later if needed, ex. adding validation
        public string Address
        { get; set; }
        #endregion

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        //Constructor Method
        //Constructor Parameterless (Default Constructor)
        public Account()
        {
            //Code common to all other types of Constructors
            _PrevId++; //Increment id value for subsequent Objects
            _Id = _PrevId;
            MessageBox.Show("Object is Created");
        }

        //Constructor Parameterized
        public Account(string name, decimal balance) //int? - deleted from params <- now id is autoincremented
            : this()
        {
            //_Id = id; - Possible, but omits Property -> Property's set block would not be executed
            //Id = Property; id = local Variable
            //this.Id = id; //Comment <- now id is autoincremented
            this.Name = name;
            this.Balance = balance;
        }

        //Constructor Copy
        public Account(Account a)
            : this(a._Name, a._Balance) //a._Id - deleted from params <- now id is autoincremented
        {
            //this.Id = a.Id; //Comment <- now id is autoincremented
            this.Name = a.Name;
            this.Balance = a.Balance;
        }

        //Constructor Static
        static Account()
        {
            //Place for initialization of all Static Members of the Class
            MessageBox.Show("Class is loaded");
        }

        //Destructor Method
        ~Account()
        {
            MessageBox.Show("Object is Destroyed");
        }

        public void Withdraw(decimal amount)
        {
            if (this.Balance - amount < 500)
            {
                //Business rule - we don't know if the App will be WindowsForms or Console
                //Exception = code is independent of type of App it will be implemented in
                throw new ApplicationException("Insufficient funds");
            }
            else
                this.Balance -= amount;
        }

        //Req: compare 2 accounts, return balance which is greater
        public static Account GetAccountWithMoreBalance(Account a1, Account a2)
        {
            if (a1.Balance > a2.Balance)
                return a1;
            else
                return a2;
        }

    }

    /*
    public class Go
    {
        Account a = new Account();
        a.Id = 1;
        a.Name = "A1";
        a.Balance = 10000;
        
        a.Deposit(1000);

    }
    */
}

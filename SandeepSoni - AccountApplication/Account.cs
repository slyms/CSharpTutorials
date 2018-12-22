using System;
using System.Text;
using System.Windows.Forms;

namespace SandeepSoni___Demo
{
    public class Account
    {
        #region Field Members
        //Account no; ? = can be null
        private int? _Id;

        //Requirement: Id should be set only once
        private bool _IdAlreadySet;
        private String _Name;

        //private - direct outside the Class changes to Balance are impossible = safety
        //public Method is providing access to private data
        //_ - underscore - notation for private Members
        private decimal _Balance; //Money

        public static int _MinBalance = 500; //Static Member
        #endregion

        #region Properties
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

        //Previous id of Object - common for all Objects inside this Class
        private static int _PrevId; 
        
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
        //_Balance - used inside Class; Balance - outside = Public Member encapsulates Private Member = access restricion
        //-> Changing Balance no more possible: a.Balance = 1000000;
        //-> Changing Balance only possible: a.Deposit / a.Withdraw
        public decimal Balance 
        {
            get
            {
                return _Balance; //= decimal bal = a.Balance;
            }    
            //If commented = Balance is ready-only Property
            //OR = private set = accesible only inside Class
            private set
            {
                //If some additional code here, better write: Balance - to not repeat the code elsewhere
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

        //27.Destroying Objects and Role of Garbage Collector
        //30. Constructor and Destructor
        //Constructor Method
        //Constructor Parameterless (Default Constructor)
        public Account()
        {
            //Code common to all other types of Constructors which use "this"
            _PrevId++; //Increment id value for subsequent Objects
            _Id = _PrevId;
            MessageBox.Show("Object is Created");
        }

        //Constructor Parameterized
        public Account(string name, decimal balance) //"int?" - deleted from params <- now id is autoincremented
            //"this" = allows calling Default Constructor
            : this() 
        {
            //_Id = id; - Possible, but omits Property -> Property's set block would not be executed
            //Id = Property; id = local Variable
            //this.Id = id; //Comment <- now id is autoincremented
            this.Name = name;
            this.Balance = balance;
        }

        //Constructor Copy: 1st gets data from copied Object, 2nd - sets data in Object copy
        public Account(Account a)
            //"this" = allows calling Constructor Parameterized -> code within this Constructor can be commented
            : this(a._Name, a._Balance) //a._Id - deleted from params <- now id is autoincremented
        {
            //this.Id = a.Id; //Comment <- now id is autoincremented
            //this.Name = a.Name;
            //this.Balance = a.Balance;
        }

        //31. Static Members
        //Constructor Static
        static Account()
        {
            //Place for initialization of all Static Members of the Class
            //Code ex. to get data from DB
            MessageBox.Show("Class is loaded");
        }

        //Destructor Method
        ~Account()
        {
            MessageBox.Show("Object is Destroyed");
        }

        //Req - only amount >500 can be withdrawn
        public void Withdraw(decimal amount)
        {
            if (this.Balance - amount < 500)
            {
                //Business rule - we don't know if the App will be WindowsForms or Console - so don't use System.Windows.Forms.MessageBox
                //and MessageBox won't be appropriate if the App would be Console based App
                //Exception = code is independent of type of App it will be implemented in
                throw new ApplicationException("Insufficient funds");
            }
            else
                this.Balance -= amount;
        }

        //31.2 Static Methods
        //Req: compare 2 accounts, return balance which is greater
        //Static - current Object is not used, so it can be Static
        public static Account GetAccountWithMoreBalance(Account a1, Account a2)
        {
            if (a1.Balance > a2.Balance)
                return a1;
            else
                return a2;
        }

        //Non static
        public Account GetAccountWithMoreBalance(Account other)
        {
            if (other.Balance > this.Balance)
                return other;
            else
                return this;
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

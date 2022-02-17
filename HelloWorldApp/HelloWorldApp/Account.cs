namespace Banking
{
    class Account
    {
        private int _accountId;
        private string _accountHolder;
        private double _balance;

        public int AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }
        public string AccountHolder
        {
            get { return this._accountHolder; }
            set { this._accountHolder = value; }

        }

        public double Balance
        {
            get { return this._balance; }
            set { this._balance = value; }
            
        }
        public Account()
        {
            this._balance = 5000;
        }
        public Account(int id,string name,double bal)
        {
            this._accountId = id;
            this._accountHolder = name;
            this._balance = bal;
        }

        public void Withdraw(double amount)
        {
            this._balance= this._balance - amount;
        }

        public void Deposit(double amount)
        {
            this._balance= this._balance + amount;
        }
        override
        public string ToString()
        {
            return "Id: " + this._accountId + " Account Holder Name: " + this._accountHolder + " Balance: " + this._balance;
        }
    }
}
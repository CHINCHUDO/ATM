using System;

namespace ATM.Business
{
    public abstract class Account
    {
        private double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}

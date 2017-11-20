using System;

namespace ATM.Business
{
    public abstract class Account
    {
        private double balance = 0;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}

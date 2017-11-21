using System;

namespace ATM.Business
{
    public abstract class Account
    {
        private double balance = 0;

        public double Balance
        {
            get { return balance; }
        }

        public void Deposit(double deposit)
        {
            balance += deposit;
        }

        public void Withdraw(double withdraw)
        {
            balance -= withdraw;
        }
    }
}

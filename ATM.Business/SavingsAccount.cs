using System;

namespace ATM.Business
{
    public class SavingsAccount : Account
    {
        public bool BalanceWarning
        {
            get { return Balance < 500.0; }
        }

        public void TransferTo(CheckingAccount checkingAccount, double transferredMoney)
        {
            Withdraw(transferredMoney);
            checkingAccount.Deposit(transferredMoney);
        }
    }
}

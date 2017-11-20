using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Business
{
    public class SavingsAccount : Account
    {
        public void TransferTo(CheckingAccount checkingAccount, double transferredMoney)
        {
            Balance -= transferredMoney;
            checkingAccount.Balance += transferredMoney;
        }
    }
}

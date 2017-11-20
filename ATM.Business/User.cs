using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Business
{
    public class User
    {
        private CheckingAccount checkingAccount = new CheckingAccount();
        private SavingsAccount savingsAccount = new SavingsAccount();

        public CheckingAccount CheckingAccount
        {
            get { return checkingAccount; }
        }

        public SavingsAccount SavingsAccount
        {
            get { return savingsAccount; }
        }
    }
}

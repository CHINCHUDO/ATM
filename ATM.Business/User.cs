

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

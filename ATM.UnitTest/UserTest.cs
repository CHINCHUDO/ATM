
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ATM.Business;

namespace ATM.UnitTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void User_Should_See_The_Balance_Of_SavingsAccount()
        {
            var user = new User();
            user.SavingsAccount.Balance = 500.0;
            Assert.AreEqual(user.SavingsAccount.Balance, 500.0);
        }

        [TestMethod]
        public void User_Should_See_The_Balance_Of_CheckingAccount()
        {
            var user = new User();
            user.CheckingAccount.Balance = 500.0;
            Assert.AreEqual(user.CheckingAccount.Balance, 500.0);
        }

        [TestMethod]
        public void User_Should_Be_Able_To_Transfer_From_Savings_To_Checking()
        {
            var user = new User();
            user.SavingsAccount.Balance = 100.0;
            user.CheckingAccount.Balance = 500.0;

            user.SavingsAccount.TransferTo(user.CheckingAccount, 50.0);


            Assert.AreEqual(user.CheckingAccount.Balance, 550.0);
            Assert.AreEqual(user.SavingsAccount.Balance, 50.0);
        }
    }
}

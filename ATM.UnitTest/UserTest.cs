
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
    }
}

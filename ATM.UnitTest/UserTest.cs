
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
            user.SavingsAccount.Deposit(500.0);
            Assert.AreEqual(user.SavingsAccount.Balance, 500.0);
        }

        [TestMethod]
        public void User_Should_See_The_Balance_Of_CheckingAccount()
        {
            var user = new User();
            user.CheckingAccount.Deposit(500.0);
            Assert.AreEqual(user.CheckingAccount.Balance, 500.0);
        }

        [TestMethod]
        public void User_Should_Be_Able_To_Transfer_From_Savings_To_Checking()
        {
            var user = new User();
            user.SavingsAccount.Deposit(100.0);
            user.CheckingAccount.Deposit(500.0);

            user.SavingsAccount.TransferTo(user.CheckingAccount, 50.0);

            Assert.AreEqual(user.CheckingAccount.Balance, 550.0);
            Assert.AreEqual(user.SavingsAccount.Balance, 50.0);
        }

        [TestMethod]
        public void User_Needs_To_Be_Warned_If_Their_Savings_Account_Drops_Bellow_500()
        {
            var user = new User();
            user.SavingsAccount.Deposit(600.0);

            Assert.IsFalse(user.SavingsAccount.BalanceWarning);

            user.SavingsAccount.Deposit(300.0);

            Assert.IsTrue(user.SavingsAccount.BalanceWarning);
        }

        [TestMethod]
        [ExpectedException(typeof(WithdrawUpTo500Exception))]
        public void User_Needs_To_Be_Able_To_Withdraw_Up_To_500_From_Checking_Account()
        {
            var user = new User();
            user.CheckingAccount.Deposit(1000.0);

            user.CheckingAccount.Withdraw(600.0);
        }

        //New stuff
        [TestMethod]
        public void User_Needs_To_Deposit_Money_To_Checking_Account()
        {
            var user = new User();
            user.CheckingAccount.Deposit(750.0);

            user.CheckingAccount.Deposit(50.0);

            Assert.AreEqual(user.CheckingAccount.Balance, 800.0);
        }

        [TestMethod]
        public void User_Can_Withdraw_Money_Using_A_Credit_Card()
        {
            var user = new User();
            //user.CheckingAccount.Deposit(750.0);

            user.CheckingAccount.Withdraw(50.0);

            Assert.AreEqual(user.CheckingAccount.Balance, 700.0);
        }


    }
}

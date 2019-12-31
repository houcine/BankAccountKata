using BankAccountService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAccount.Tests
{
    [TestClass]
    public class WithdrawUnitTests
    {
        [TestMethod]
        public void WithdrawalNegativeAmountCheck()
        {
            Account account = new Account();
            Amount amount = new Amount(-700);
            Balance oldBalance = account.Balance;
            account.Withdraw(amount);
            Assert.AreEqual(oldBalance, account.Balance);
        }

        [TestMethod]
        public void WithdrawalCheckNegativeBalance()
        {
            Account account = new Account();
            account.Balance = new Balance(100);
            Amount amount = new Amount(700);
            Balance oldBalance = account.Balance;
            account.Withdraw(amount);
            Assert.AreEqual(oldBalance, account.Balance);
        }

        [TestMethod]
        public void WithdrawalPositiveAmountCheck()
        {
            Account account = new Account();
            account.Balance = new Balance(800);
            Amount amount = new Amount(300);
            Balance newBalance = account.Balance - amount;
            account.Withdraw(amount);
            Assert.AreEqual(newBalance, account.Balance);
        }
    }
}

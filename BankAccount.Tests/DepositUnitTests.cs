using BankAccountService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAccount.Tests
{
    [TestClass]
    public class DepositUnitTests
    {
        [TestMethod]
        public void DepositPositiveAmountCheck()
        {
            Account account = new Account();
            Amount amount = new Amount(500);
            Balance newBalance = account.Balance + amount;
            account.Deposit(amount);
            Assert.AreEqual(newBalance, account.Balance);
        }

        [TestMethod]
        public void DepositNegativeAmountCheck()
        {
            Account account = new Account();
            Amount amount = new Amount(-500);
            Balance oldBalance = account.Balance;
            account.Deposit(amount);
            Assert.AreEqual(oldBalance, account.Balance);
        }
    }
}

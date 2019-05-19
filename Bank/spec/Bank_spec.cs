using NUnit.Framework;
using src;

namespace spec
{
    [TestFixture]
    public class BankTests
    {
        [Test]
        public void MyBalance()
        {
            var testBalance = new Bank();
            var zero = testBalance.MyBalance();
            Assert.AreEqual(0, zero);
        }

        [Test]
        public void Deposit()
        {
            // Testing Deposit method
            var testDeposit = new Bank();
            var testAdd = testDeposit.Deposit(1000);
            Assert.AreEqual("Your money has been deposited!", testAdd);
            
            // Testing balance is changed
            Assert.AreEqual(1000, testDeposit.MyBalance());
            
            //Testing Edge Cases
            Assert.That(() => testDeposit.Deposit(-50), Throws.ArgumentException);
        }

        [Test]
        public void Withdraw()
        {
            // Testing Withdraw method
            var testWithdraw = new Bank();
            testWithdraw.Deposit(1000);
            var testRemove = testWithdraw.Withdraw(500);
            Assert.AreEqual("Your money has been withdrawn!", testRemove);
            
            // Testing balance has changed
            Assert.AreEqual(500, testWithdraw.MyBalance());
            
            // Testing Edge Cases
            Assert.That(() => testWithdraw.Withdraw(-60), Throws.ArgumentException);
            Assert.That(() => testWithdraw.Withdraw(600), Throws.ArgumentException);
        }

        [Test]
        public void DisplayStatement()
        {
            var statement = new Bank();
            statement.Deposit(100);
            statement.Withdraw(50);
            statement.Deposit(80);
            Assert.AreEqual($"date || credit || debit || balance\n{statement.NewTable.Date} || 80.00 || || 130.00\n{statement.NewTable.Date} || || 50.00 || 50.00\n{statement.NewTable.Date} || 100.00 || || 100.00\n", statement.DisplayStatement());
        }
    }
}
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
            Assert.AreEqual(1000, testAdd);
            
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
            Assert.AreEqual(500, testRemove);
            
            // Testing balance has changed
            Assert.AreEqual(500, testWithdraw.MyBalance());
            
            // Testing Edge Cases
            Assert.That(() => testWithdraw.Withdraw(-60), Throws.ArgumentException);
            Assert.That(() => testWithdraw.Withdraw(600), Throws.ArgumentException);
        }
    }
}
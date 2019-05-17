using NUnit.Framework;
using src;

namespace spec
{
    [TestFixture]
    public class TableTests
    {
        [Test]
        public void Deposit()
        {
            // Testing deposit string
            var testAdditions = new Table();
            var plusOneHundred = testAdditions.Deposit(100);
            Assert.AreEqual("Your money has been deposited!", plusOneHundred);
            
            // Testing history is stored
            Assert.AreEqual("17/05/2019 || 100.00 || || 100.00", testAdditions.history[0]);
        }

        [Test]
        public void Withdraw()
        {
            // Testing withdraw string
            var testWithdraw = new Table();
            var minusOneHundred = testWithdraw.Withdraw(100);
            Assert.AreEqual("Your money has been withdrawn!", minusOneHundred);
            
            // Testing history is stored
            Assert.AreEqual("17/05/2019 || || -100.00 || -100.00", testWithdraw.history[0]);
        }
    }
}
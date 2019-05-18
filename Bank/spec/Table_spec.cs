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
            Assert.AreEqual("18/05/2019 || 100.00 || || 100.00", testAdditions.history[0]);
        }

        [Test]
        public void Withdraw()
        {
            // Testing withdraw string
            var testWithdraw = new Table();
            var minusOneHundred = testWithdraw.Withdraw(100);
            Assert.AreEqual("Your money has been withdrawn!", minusOneHundred);
            
            // Testing history is stored
            Assert.AreEqual("18/05/2019 || || 100.00 || -100.00", testWithdraw.history[0]);
        }

        [Test]
        public void Table()
        {
            // Testing bank statement
            var showTable = new Table();
            showTable.Deposit(100);
            showTable.Withdraw(50);
            Assert.AreEqual($"date || credit || debit || balance\n18/05/2019 || 100.00 || || 100.00\n18/05/2019 || || 50.00 || 50.00", showTable.Table());
        }
    }
}
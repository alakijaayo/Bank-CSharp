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
            Assert.AreEqual($"{testAdditions.Date} || 100.00 || || 100.00", testAdditions.History[0]);
        }

        [Test]
        public void Withdraw()
        {
            // Testing withdraw string
            var testWithdraw = new Table();
            var minusOneHundred = testWithdraw.Withdraw(100);
            Assert.AreEqual("Your money has been withdrawn!", minusOneHundred);
            
            // Testing history is stored
            Assert.AreEqual($"{testWithdraw.Date} || || 100.00 || -100.00", testWithdraw.History[0]);
        }

        [Test]
        public void ShowTable()
        {
            // Testing bank statement
            var displayTable = new Table();
            displayTable.Deposit(100);
            displayTable.Withdraw(50);
            displayTable.Deposit(80);
            Assert.AreEqual($"date || credit || debit || balance\n{displayTable.Date} || 80.00 || || 130.00\n{displayTable.Date} || || 50.00 || 50.00\n{displayTable.Date} || 100.00 || || 100.00\n", displayTable.Statement());
        }
    }
}
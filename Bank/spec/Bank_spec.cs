using System;
using NUnit.Framework;
using src;

namespace spec
{
    [TestFixture]
    public class Tests
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
            var testDeposit = new Bank();
            var testAdd = testDeposit.Deposit(1000);
            Assert.AreEqual(1000, testAdd);
        }

        [Test]
        public void Withdraw()
        {
            var testWithdraw = new Bank();
            var Add = testWithdraw.Deposit(1000);
            var testRemove = testWithdraw.Withdraw(500);
            Assert.AreEqual(500, testRemove);
        }
    }
}
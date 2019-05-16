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

        public void Deposit()
        {
            var testDeposit = new Bank();
            var addMoney = testDeposit.Deposit(1000);
            Assert.AreEqual(1000, addMoney);
        }
    }
}
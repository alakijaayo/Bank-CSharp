using System;
using NUnit.Framework;
using src;

namespace spec
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Balance()
        {
            var testbalance = new Bank();
            var zero = testbalance.balance();
            Assert.AreEqual(0, zero);
        }
    }
}
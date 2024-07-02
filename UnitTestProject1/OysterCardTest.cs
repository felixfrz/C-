using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class OysterCardTest
    {
        [TestClass]
        public class OysterCardTest
        {
            [TestMethod]
            [ExpectedException(typeof(FareException), "You don't have enough balance!")]
            public void TestValidateExeption()
            {
                OysterCard card = new OysterCard(30f);
                card.ValidateBalance(40);
            }

            [TestMethod]
            [ExpectedException(typeof(FareException), "You don't have enough balance!")]
            public void TestOutException()
            {
                OysterCard card = new OysterCard(30f);
                card.Out(40);
            }
        }
    }
}

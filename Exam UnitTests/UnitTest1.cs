using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace быстрее_бы_сдать_я_устал
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] public void CheckValid()
        {
            Assert.IsTrue(Passwording.Check("YasperMoglot2004"));
        }
        [TestMethod] public void CheckInvalidLength()
        {
            Assert.IsFalse(Passwording.Check("Yasper"));
        }
        [TestMethod] public void TestInvalidSpecialChar()
        {
            Assert.IsFalse(Passwording.Check("YasperMoglot2004!"));
        }
        [TestMethod] public void TestInvalidNoDigits()
        {
            Assert.IsFalse(Passwording.Check("YasperMoglotasdsajsakjskjdaasd"));
        }
        [TestMethod] public void TestInvalidNoCapital()
        {
            Assert.IsFalse(Passwording.Check("adsaaspersadasdoglot2004"));
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP.Entities.Validators.Van;

namespace ERP.Test.Van
{
    [TestClass]
    public class vanValidatorTests
    {
        
        [TestMethod()]
        public void correctLicencePlateTest()
        {
            Assert.IsTrue(VanValidator.LicensePlateValidator("abc1234"));
        }

        [TestMethod()]
        public void incorrectLicencePlateTest()
        {
            Assert.IsFalse(VanValidator.LicensePlateValidator("ab1"));
        }
    }
}

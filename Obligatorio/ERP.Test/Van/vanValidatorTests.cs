using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP.Test.Van
{
    [TestClass]
    public class vanValidatorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            [TestMethod()]
        public void correctLicencePlateTest()
        {
            Assert.IsTrue(ERP.Entities.Validators.Student.StudentValidator.CIValidator("abc1234"));
        }

        [TestMethod()]
        public void incorrectLicencePlateTest()
        {
            Assert.IsFalse(ERP.Entities.Validators.Student.StudentValidator.CIValidator("654"));
        }
    }
    }
}

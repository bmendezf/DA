using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP.Entities.Validators.Student;

namespace ERP.Test.Student
{
    [TestClass]
    public class StudentValidatorTest
    {
        [TestMethod()]
        public void correctCITest()
        {
            Assert.IsTrue(ERP.Entities.Validators.Student.StudentValidator.CIValidator("1234567-8"));
        }

        [TestMethod()]
        public void incorrectCITest()
        {
            Assert.IsFalse(ERP.Entities.Validators.Student.StudentValidator.CIValidator("12345678"));
        }
    }
}

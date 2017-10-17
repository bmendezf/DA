using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP.Entities.Validators.Subject;

namespace ERP.Test.Validators.Subject
{
    [TestClass]
    public class SubjectValidatorTests
    {
        [TestMethod()]
        public void correctCodeTest()
        {
            Assert.IsTrue(SubjectValidator.CodeValidator("12345"));
        }

        [TestMethod()]
        public void incorrectCodeTest()
        {
            Assert.IsFalse(SubjectValidator.CodeValidator("a12345"));
        }
    }
}

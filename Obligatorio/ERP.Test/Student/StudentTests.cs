using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP.Entities.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Student.Tests
{
    [TestClass()]
    public class StudentTests
    {
        Student student;

        [TestInitialize()]
        public void initialize()
        {
            student = new Student();
        }

        [TestMethod()]
        public void NameTest()
        {            
            student.Name = "Juan";

            Assert.AreEqual(student.Name, "Juan");
        }


        [TestMethod()]
        public void NameNotNullTest()
        {
            Assert.IsNotNull(student.Name);
        }

        [TestMethod()]
        public void LastNameTest()
        {
            student.LastName = "Alonso";

            Assert.AreEqual(student.LastName, "Alonso");
        }

        [TestMethod()]
        public void LastNameNotNullTest()
        {
            Assert.IsNotNull(student.LastName);
        }

        [TestMethod()]
        public void CITest()
        {
            student.CI = 12345678;

            Assert.AreEqual(student.CI, 12345678);
        }

        [TestMethod()]
        public void CINotNullTest()
        {
            Assert.IsNotNull(student.CI);
        }

        [TestMethod()]
        public void StudentNumberTest()
        {
            student.StudentNumber = 123456;

            Assert.AreEqual(student.StudentNumber, 123456);
        }

        [TestMethod()]
        public void StudentNumberNotNullTest()
        {
            Assert.IsNotNull(student.StudentNumber);
        }

        [TestMethod()]
        public void SubjectsTest()
        {
            List<Subject.Subject> someSubjects;
            someSubjects = new List<Subject.Subject>();
            student.Subjects = someSubjects;

            Assert.AreEqual(student.Subjects, someSubjects);
        }
    }
}
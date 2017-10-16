using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP.Entities.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Teacher.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        [TestMethod()]
        public void firstNameNotNullTest()
        {
            Teacher aTeacher = new Teacher();

            Assert.IsNotNull(aTeacher.FirstName);
        }

        [TestMethod()]
        public void firstNameTest()
        {
            Teacher aTeacher = new Teacher();
            aTeacher.FirstName = "Juan";

            Assert.Equals(aTeacher.FirstName, "Juan");
        }

        [TestMethod()]
        public void lastNameNotNullTest()
        {
            Teacher aTeacher = new Teacher();

            Assert.IsNotNull(aTeacher.LastName);
        }

        [TestMethod()]
        public void lastNameNotNullTest()
        {
            Teacher aTeacher = new Teacher();
            aTeacher.FirstName = "Garcia";


            Assert.Equals(aTeacher.LastName, "Garcia");
        }

        [TestMethod()]
        public void subjectsNotNullTest()
        {
            Teacher aTeacher = new Teacher();

            Assert.IsNotNull(aTeacher.Subjects);
        }

        [TestMethod()]
        public void subjectsTest()
        {
            Teacher aTeacher = new Teacher();
            List<Subject> aList = new List<Subject>;
            aTeacher.Subjects = aList;

            Assert.Equals(aTeacher.Subjects, aList);
        }

        [TestMethod()]
        public void iDNotNullTest()
        {
            Teacher aTeacher = new Teacher();
           

            Assert.IsNotNull(aTeacher.Id);
        }

        [TestMethod()]
        public void teacherEqualityTrueTest()
        {
            Teacher aTeacher = new Teacher();
            aTeacher.Id = "47319195";

            Teacher anotherTeacher = new Teacher();
            anotherTeacher.Id = "47319195";


            Assert.Equals(aTeacher, anotherTeacher);
        }

        [TestMethod()]
        public void teacherEqualityFalseTest()
        {
            Teacher aTeacher = new Teacher();
            aTeacher.Id = "47319195";

            Teacher anotherTeacher = new Teacher();
            anotherTeacher.Id = "17970731";


            Assert.AreNotEqual(aTeacher, anotherTeacher);
        }
    }
}
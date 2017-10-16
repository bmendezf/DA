using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP.Entities.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Subject.Tests
{
    [TestClass()]
    public class SubjectTests
    {
        [TestMethod()]
        public void nameNotNullTest()
        {
            Subject aSubject = new Subject();

            Assert.IsNotNull(aSubject.Name);
        }

        [TestMethod()]
        public void nameTest()
        {
            Subject aSubject = new Subject();
            aSubject.Name = "Diseno de Aplicaciones 1";

            Assert.AreEqual(aSubject.Name, "Diseno de Aplicaciones 1");
        }

        [TestMethod()]
        public void codeNotNullTest()
        {
            Subject aSubject = new Subject();

            Assert.IsNotNull(aSubject.Code);
        }

        [TestMethod()]
        public void codeTest()
        {
            Subject aSubject = new Subject();
            aSubject.Code = "DA1";

            Assert.AreEqual(aSubject.Code, "DA1");
        }

        [TestMethod()]
        public void studentsNotNullTest()
        {
            Subject aSubject = new Subject();

            Assert.IsNotNull(aSubject.Students);
        }

        [TestMethod()]
        public void studentsTest()
        {
            Subject aSubject = new Subject();
            List<Student.Student> listStudents = new List<Student.Student>();
            aSubject.Students = listStudents;

            Assert.AreEqual(aSubject.Students, listStudents);
        }

        [TestMethod()]
        public void teachersNotNullTest()
        {
            Subject aSubject = new Subject();

            Assert.IsNotNull(aSubject.Teachers);
        }

        [TestMethod()]
        public void teachersTest()
        {
            Subject aSubject = new Subject();
            List<Teacher.Teacher> listTeachers = new List<Teacher.Teacher>();
            aSubject.Teachers = listTeachers;

            Assert.AreEqual(aSubject.Teachers, listTeachers);
        }


        [TestMethod()]
        public void subjectsAreEqualTest()
        {
            Subject aSubject = new Subject();
            aSubject.Code = "DA1";

            Subject anotherSubject = new Subject();
            anotherSubject.Code = "DA1";

            Assert.AreEqual(aSubject, anotherSubject);
        }

        [TestMethod()]
        public void subjectsAreNotEqualTest()
        {
            Subject aSubject = new Subject();
            aSubject.Code = "DA1";

            Subject anotherSubject = new Subject();
            anotherSubject.Code = "DA1";

            Assert.AreNotEqual(aSubject, anotherSubject);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Student;
using ERP.Entities.Subject;
using ERP.Entities.Van;
using ERP.Entities.Teacher;

namespace ERP.Data.Tests
{
    [TestClass()]
    public class DataTests
    {
        [TestMethod()]
        public void StudentsNotNullTest()
        {
            Data someData = new Data();

            Assert.IsNotNull(someData.Students);
        }

        [TestMethod()]
        public void SubjectsIsNotNullTest()
        {
            Data someData = new Data();

            Assert.IsNotNull(someData.Subjects);
        }
        [TestMethod()]
        public void TeachersNotNullTest()
        {
            Data someData = new Data();

            Assert.IsNotNull(someData.Teachers);
        }
        [TestMethod()]
        public void VansNotNullTest()
        {
            Data someData = new Data();

            Assert.IsNotNull(someData.Vans);
        }
        [TestMethod()]
        public void AddStudentTest()
        {
            Data someData = new Data();

            Student aStudent = new Student();
            someData.AddStudent(aStudent);

            Assert.IsTrue(someData.Students.Contains(aStudent));
        }

        [TestMethod()]
        public void DeleteStudentTest()
        {
            Data someData = new Data();

            Student aStudent = new Student();
            someData.AddStudent(aStudent);
            someData.DeleteStudent(aStudent);

            Assert.IsFalse(someData.Students.Contains(aStudent));
        }

        [TestMethod()]
        public void UpdateStudentTest()
        {
            Data someData = new Data();

            Student aStudent = new Student();
            someData.AddStudent(aStudent);

            aStudent.Name = "Juan";
            someData.UpdateStudent(aStudent);

            Assert.IsTrue(someData.Students.Contains(aStudent));
        }

        [TestMethod()]
        public void GetStudentTest()
        {
            Data someData = new Data();

            Student aStudent = new Student();
            someData.AddStudent(aStudent);

            Student theStudent = someData.GetStudent(aStudent);

            Assert.AreEqual(aStudent,theStudent);
        }

        [TestMethod()]
        public void AddSubjectTest()
        {
            Data someData = new Data();

            Subject aSubject = new Subject();
            someData.AddSubject(aSubject);

            Assert.IsTrue(someData.Subjects.Contains(aSubject));
        }

        [TestMethod()]
        public void DeleteSubjectTest()
        {
            Data someData = new Data();

            Subject aSubject = new Subject();
            someData.AddSubject(aSubject);
            someData.DeleteSubject(aSubject);

            Assert.IsFalse(someData.Subjects.Contains(aSubject));
        }

        [TestMethod()]
        public void UpdateSubjectTest()
        {
            Data someData = new Data();

            Subject aSubject = new Subject();
            someData.AddSubject(aSubject);

            aSubject.Name = "BASE DE DATOS";
            someData.UpdateSubject(aSubject);

            Assert.IsTrue(someData.Subjects.Contains(aSubject));
        }

        [TestMethod()]
        public void GetSubjectTest()
        {
            Data someData = new Data();

            Subject aSubject = new Subject();
            someData.AddSubject(aSubject);

            Subject theSubject = someData.GetSubject(aSubject);

            Assert.AreEqual(aSubject, theSubject);
        }

        [TestMethod()]
        public void AddTeacherTest()
        {
            Data someData = new Data();

            Teacher aTeacher = new Teacher();
            someData.AddTeacher(aTeacher);

            Assert.IsTrue(someData.Teachers.Contains(aTeacher));
        }

        [TestMethod()]
        public void DeleteTeacherTest()
        {
            Data someData = new Data();

            Teacher aTeacher = new Teacher();
            someData.AddTeacher(aTeacher);
            someData.DeleteTeacher(aTeacher);

            Assert.IsFalse(someData.Teachers.Contains(aTeacher));
        }

        [TestMethod()]
        public void UpdateTeacherTest()
        {
            Data someData = new Data();

            Teacher aTeacher = new Teacher();
            someData.AddTeacher(aTeacher);

            aTeacher.FirstName = "Jenny";
            someData.UpdateTeacher(aTeacher);

            Assert.IsTrue(someData.Teachers.Contains(aTeacher));
        }

        [TestMethod()]
        public void GetTeacherTest()
        {
            Data someData = new Data();

            Teacher aTeacher = new Teacher();
            someData.AddTeacher(aTeacher);

            Teacher theTeacher = someData.GetTeacher(aTeacher);

            Assert.AreEqual(aTeacher, theTeacher);
        }

        [TestMethod()]
        public void AddVanTest()
        {

            Data someData = new Data();

            Van aVan = new Van();
            someData.AddVan(aVan);

            Assert.IsTrue(someData.Vans.Contains(aVan));

        }

        [TestMethod()]
        public void DeleteVanTest()
        {
            Data someData = new Data();

            Van aVan = new Van();
            someData.AddVan(aVan);
            someData.DeleteVan(aVan);

            Assert.IsFalse(someData.Vans.Contains(aVan));
        }

        [TestMethod()]
        public void UpdateVanTest()
        {
            Data someData = new Data();

            Van aVan = new Van();
            someData.AddVan(aVan);

            aVan.Capacity = 50;
            someData.UpdateVan(aVan);

            Assert.IsTrue(someData.Vans.Contains(aVan));
        }

        [TestMethod()]
        public void GetVanTest()
        {
            Data someData = new Data();

            Van aVan = new Van();
            someData.AddVan(aVan);

            Van theVan = someData.GetVan(aVan);


            Assert.AreEqual(aVan, theVan);
        }
    }
}
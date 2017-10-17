using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP.Entities.Student;
using ERP.Data;
using ERP.Logic;

namespace ERP.Test.Student
{

    [TestClass]
    public class StudentLogicTest
    {
        Entities.Student.Student student;
        Data.Data aDatabase;
        StudentLogic studentLogic;

        [TestInitialize()]
        public void Initialize()
        {
            student = new Entities.Student.Student();
            aDatabase = new Data.Data();
            studentLogic = new StudentLogic(aDatabase);
        }

        [TestMethod()]
        public void AddStudentTrueTest()
        {
            Assert.IsTrue(studentLogic.AddStudent(student));
        }

        [TestMethod()]
        public void AddStudentFalseTest()
        {
            studentLogic.AddStudent(student);

            Assert.IsFalse(studentLogic.AddStudent(student)); ;
        }

        [TestMethod()]
        public void DeleteStudentTest()
        {
            studentLogic.AddStudent(student);
           
            Assert.IsTrue(studentLogic.DeleteStudent(student));
        }

        [TestMethod()]
        public void DeleteStudentFalseTest()
        {
            Assert.IsFalse(studentLogic.DeleteStudent(student));
        }

        [TestMethod()]
        public void GetStudentTest()
        {
            studentLogic.AddStudent(student);
            Entities.Student.Student recivedStudent = studentLogic.getStudent(student);

            Assert.AreEqual(student,recivedStudent);
        }

        [TestMethod()]
        public void updateStudentTest()
        {
            student.Name = "bruno";
            studentLogic.AddStudent(student);
            Entities.Student.Student modifiedStudent = new Entities.Student.Student();
            modifiedStudent.Name = "Juan";
            modifiedStudent.StudentNumber = student.StudentNumber;
            studentLogic.UpdateStudent(modifiedStudent);

            Assert.AreEqual(modifiedStudent.Name, studentLogic.getStudent(student).Name);
        }

        [TestMethod()]
        public void updateStudentFalseTest()
        {
            Assert.IsFalse(studentLogic.UpdateStudent(student));
        }

        [TestMethod()]
        public void GetAllStudentsTest()
        {
            studentLogic.AddStudent(student);
            int numberOfElements = 1;

            Assert.AreEqual(numberOfElements, studentLogic.GetAllStudents().Count);
        }

    }
}


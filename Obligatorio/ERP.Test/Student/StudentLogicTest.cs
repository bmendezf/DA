using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP.Test.Student
{
   
    [TestClass]
    public class StudentLogicTest
    {
        Entities.Student.Student student;

        [TestInitialize()]
        public void Initialize()
        {
            student = new Entities.Student.Student();
        }

        [TestMethod()]
        public void AddStudentTest()
        {
            Logic.StudentLogic.addStudent(student);
            Entities.Student.Student recivedStudent = ERP.Logic.StudentLogic.getStudent(student);
         
            Assert.AreEqual(student, recivedStudent);
        }

        [TestMethod()]
        public void AddStudentRepeatedTest()
        {
            Logic.StudentLogic.addStudent(student);
            Logic.StudentLogic.addStudent(student);

            List<Entities.Student.Student> students = ERP.Logic.StudentLogic.getAllStudents();

            Assert.AreEqual(students.Count, 1);
        }

        [TestMethod()]
        public void DeleteStudentTest()
        {
            Logic.StudentLogic.addStudent(student);
            Logic.StudentLogic.deleteStudent(student);

            List<Entities.Student.Student> students = ERP.Logic.StudentLogic.getAllStudents();

            Assert.AreEqual(students.Count, 0);
        }

        [TestMethod()]
        public void updateStudentTest()
        {
            student.Name = "bruno";
            Logic.StudentLogic.addStudent(student);
            Entities.Student.Student student2 = new Entities.Student.Student();
            student2.Name = "Juan";
            student2.StudentNumber = student.StudentNumber;
            Logic.StudentLogic.updateStudent(student2);
            Entities.Student.Student updatedStudent = Logic.StudentLogic.getStudent(student);

            Assert.AreEqual(updatedStudent.Name, student2.Name);
        }
    }
}

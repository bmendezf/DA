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
           
            Assert.IsTrue(studentLogic.deleteStudent(student));
        }

        //    [TestMethod()]
        //    public void updateStudentTest()
        //    {
        //        student.Name = "bruno";
        //        Logic.StudentLogic.addStudent(student);
        //        student2.Name = "Juan";
        //        student2.StudentNumber = student.StudentNumber;
        //        Logic.StudentLogic.updateStudent(student2);
        //        Entities.Student.Student updatedStudent = Logic.StudentLogic.getStudent(student);

        //        Assert.AreEqual(updatedStudent.Name, student2.Name);
        //    }
        //}
    }
}

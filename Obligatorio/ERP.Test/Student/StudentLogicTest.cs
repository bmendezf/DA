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
            Entities.Student.Student studentRecibido = ERP.Logic.StudentLogic.getStudent(student);
         
            Assert.AreEqual(student, studentRecibido);
        }


    }
}

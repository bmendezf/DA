using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Data;
using ERP.Entities.Subject;
using ERP.Entities.Student;
using ERP.Entities.Teacher;

namespace ERP.Logic.Tests
{
    [TestClass()]
    public class TeacherLogicTests
    {
        Data.Data aDatabase = new Data.Data();

        [TestMethod()]
        public void AddTeacherTrueTest()
        {
            TeacherLogic tea = new TeacherLogic(aDatabase);
            Teacher aTeacher = new Teacher();
            Assert.IsTrue(tea.AddTeacher(aTeacher)); 
        }

        [TestMethod()]
        public void AddTeacherFalseTest()
        {
            TeacherLogic tea = new TeacherLogic(aDatabase);
            Teacher aTeacher = new Teacher();
            Assert.IsTrue(tea.AddTeacher(aTeacher)); ;
        }

        [TestMethod()]
        public void DeleteTeacherTrueTest()
        {
            TeacherLogic tea = new TeacherLogic(aDatabase);
            Teacher aTeacher = new Teacher();
            tea.AddTeacher(aTeacher);

            Assert.IsTrue(tea.DeleteTeacher(aTeacher));
        }

        [TestMethod()]
        public void DeleteTeacherFalseTest()
        {
            TeacherLogic tea = new TeacherLogic(aDatabase);
            Teacher aTeacher = new Teacher();

            Assert.IsTrue(tea.DeleteTeacher(aTeacher));
        }

        [TestMethod()]
        public void UpdateTeacherTrueTest()
        {
            TeacherLogic tea = new TeacherLogic(aDatabase);
            Teacher aTeacher = new Teacher();
            tea.AddTeacher(aTeacher);
            aTeacher.FirstName = "JENNY";
            tea.UpdateTeacher(aTeacher);

            Assert.IsTrue(tea.UpdateTeacher(aTeacher));
        }

        [TestMethod()]
        public void UpdateTeacherFalseTest()
        {
            TeacherLogic tea = new TeacherLogic(aDatabase);
            Teacher aTeacher = new Teacher();    
            tea.UpdateTeacher(aTeacher);

            Assert.IsFalse(tea.UpdateTeacher(aTeacher));
        }
        [TestMethod()]
        public void GetAllTeachersTest()
        {
            TeacherLogic tea = new TeacherLogic(aDatabase);
            Teacher aTeacher = new Teacher();
            tea.AddTeacher(aTeacher);


            Assert.IsNotNull(tea.GetAllTeachers());
        }

    }
}
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
    public class SubjectLogicTests
    {
        Data.Data aDatabase = new Data.Data();
        

        [TestMethod()]
        public void AddSubjectTrueTest()
        {
            SubjectLogic sub = new SubjectLogic(aDatabase);
            Subject aSubject = new Subject();
            Assert.IsTrue(sub.AddSubject(aSubject));
        }

        [TestMethod()]
        public void AddSubjectFalseTest()
        {
            SubjectLogic sub = new SubjectLogic(aDatabase);
            Subject aSubject = new Subject();
            sub.AddSubject(aSubject);

            Assert.IsFalse(sub.AddSubject(aSubject));
        }


        [TestMethod()]
        public void DeleteSubjectTrueTest()
        {
            SubjectLogic sub = new SubjectLogic(aDatabase);
            Subject aSubject = new Subject();
            sub.AddSubject(aSubject);

            Assert.IsTrue(sub.DeleteSubject(aSubject));
        }

        [TestMethod()]
        public void DeleteSubjectFalseTest()
        {
            SubjectLogic sub = new SubjectLogic(aDatabase);
            Subject aSubject = new Subject();

            Assert.IsFalse(sub.DeleteSubject(aSubject));
        }

        [TestMethod()]
        public void UpdateSubjectTrueTest()
        {
            SubjectLogic sub = new SubjectLogic(aDatabase);
            Subject aSubject = new Subject();
            sub.AddSubject(aSubject);
            aSubject.Name = "BASE DE DATOS";
            sub.UpdateSubject(aSubject);
              

            Assert.IsTrue(sub.UpdateSubject(aSubject));
        }

        [TestMethod()]
        public void UpdateSubjectFalseTest()
        {
            SubjectLogic sub = new SubjectLogic(aDatabase);
            Subject aSubject = new Subject();
            sub.UpdateSubject(aSubject);
                

            Assert.IsFalse(sub.UpdateSubject(aSubject));
        }

        [TestMethod()]
        public void GetSubjectTrueTest()
        {
            SubjectLogic sub = new SubjectLogic(aDatabase);
            Subject aSubject = new Subject();
            sub.AddSubject(aSubject);


            Assert.IsNotNull(sub.GetSubject(aSubject));
        }

        [TestMethod()]
        public void GetSubjectFalseTest()
        {
            SubjectLogic sub = new SubjectLogic(aDatabase);
            Subject aSubject = new Subject();


            Assert.IsNull(sub.AddSubject(aSubject));
        }

        [TestMethod()]
        public void GetAllSubjectsTest()
        {
            SubjectLogic sub = new SubjectLogic(aDatabase);
            Subject aSubject = new Subject();
            sub.AddSubject(aSubject);


            Assert.IsNotNull(sub.GetAllSubjects());
        }

        [TestMethod()]
        public void GetStudentsBySubjectTest()
        {
            SubjectLogic sub = new SubjectLogic(aDatabase);
            Subject aSubject = new Subject();
            sub.AddSubject(aSubject);


            Assert.IsNotNull(sub.GetStudentsBySubject(aSubject));
        }
        [TestMethod()]
        public void GetTeachersBySubjectTest()
        {
            SubjectLogic sub = new SubjectLogic(aDatabase);
            Subject aSubject = new Subject();
            sub.AddSubject(aSubject);


            Assert.IsNotNull(sub.GetTeachersBySubject(aSubject));
        }

        [TestMethod()]
        public void GetSubjectsByStudentTest()
        {
            SubjectLogic sub = new SubjectLogic(aDatabase);
            Subject aSubject = new Subject();
            sub.AddSubject(aSubject);
            Student aStudent = new Student();


            Assert.IsNotNull(sub.GetSubjectsByStudent(aStudent));
        }

        [TestMethod()]
        public void GetSubejctsByTeacherTest()
        {
            SubjectLogic sub = new SubjectLogic(aDatabase);
            Subject aSubject = new Subject();
            sub.AddSubject(aSubject);
            Teacher aTeacher = new Teacher();

            Assert.IsNotNull(sub.GetSubjectsByTeacher(aTeacher));
        }
    }
}
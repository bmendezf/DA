using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Data;
using ERP.Entities.Subject;
using ERP.Entities.Student;
using ERP.Entities.Teacher;


namespace ERP.Logic
{
    public class SubjectLogic: ISubjectLogic
    {
        private Data.Data database;
        
        public SubjectLogic(Data.Data someDatabase)
        {
            this.database = someDatabase;
        }
        public bool AddSubject(Subject sSubject) { return false; }

        public bool DeleteSubject(Subject sSubject) { return false; }

        public bool UpdateSubject(Subject sSubject) { return false; }

        public Subject GetSubject(Subject sSubject) { return null; }

        public List<Subject> GetAllSubjects()
        {
            return null;
        }

        public List<Student> GetStudentsBySubject(Subject aSubject)
        {
            return null;
        }

        public List<Teacher> GetTeachersBySubject(Subject aSubject)
        {
            return null;
        }

        public List<Subject> GetSubjectsByStudent(Student aStudent)
        {
            return null;
        }
        public List<Teacher> GetSubejctsByTeacher(Teacher aTeacher)
        {
            return null;
        }


    }
}

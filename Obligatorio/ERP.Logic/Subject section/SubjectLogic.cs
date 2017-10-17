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
    public class SubjectLogic: ISubjectLogic, ISubjectForTeacher, ISubjectForStudent
    {
        private Data.Data database;
        
        public SubjectLogic(Data.Data someDatabase)
        {
            this.database = someDatabase;
        }
        public bool AddSubject(Subject aSubject)
        {
            //RUN VALIDATORS
            return database.AddSubject(aSubject);
        }

        public bool DeleteSubject(Subject aSubject)
        {
            //RUN VALIDATORS
            return database.DeleteSubject(aSubject);
        }

        public bool UpdateSubject(Subject aSubject)
        {
            //RUN VALIDATORS
            return database.UpdateSubject(aSubject); 
        }

        public Subject GetSubject(Subject aSubject)
        {
            //RUN VALIDATORS
            return database.GetSubject(aSubject); 
        }

        public List<Subject> GetAllSubjects()
        {
            //RUN VALIDATORS
            return database.GetAllSubjects();
        }

        public List<Student> GetStudentsBySubject(Subject aSubject)
        {
            //RUN VALIDATORS
            return database.GetStudentsBySubject(aSubject);
        }

        public List<Teacher> GetTeachersBySubject(Subject aSubject)
        {
            //RUN VALIDATORS
            return database.GetTeachersBySubject(aSubject);
        }

        public List<Subject> GetSubjectsByStudent(Student aStudent)
        {
            //RUN VALIDATORS
            return database.GetSubjectsByStudent(aStudent);
        }
        public List<Subject> GetSubjectsByTeacher(Teacher aTeacher)
        {
            //RUN VALIDATORS
            return database.GetSubjectsByTeacher(aTeacher);
        }


    }
}

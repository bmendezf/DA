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
            if (Entities.Validators.Subject.SubjectValidator.CodeValidator(aSubject.Code))
            {
                return database.AddSubject(aSubject);
            }
            else
            {
                return false;
            }
            
        }

        public bool DeleteSubject(Subject aSubject)
        {
            return database.DeleteSubject(aSubject);
        }

        public bool UpdateSubject(Subject aSubject)
        {
            if (Entities.Validators.Subject.SubjectValidator.CodeValidator(aSubject.Code))
            {
                return database.UpdateSubject(aSubject);
            }
            else
            {
                return false;
            }
        }

        public Subject GetSubject(Subject aSubject)
        {
            return database.GetSubject(aSubject); 
        }

        public List<Subject> GetAllSubjects()
        {
            return database.GetAllSubjects();
        }

        public List<Student> GetStudentsBySubject(Subject aSubject)
        {
            return database.GetStudentsBySubject(aSubject);
        }

        public List<Teacher> GetTeachersBySubject(Subject aSubject)
        {
            return database.GetTeachersBySubject(aSubject);
        }

        public List<Subject> GetSubjectsByStudent(Student aStudent)
        {
            return database.GetSubjectsByStudent(aStudent);
        }
        public List<Subject> GetSubjectsByTeacher(Teacher aTeacher)
        {
            return database.GetSubjectsByTeacher(aTeacher);
        }
    }
}

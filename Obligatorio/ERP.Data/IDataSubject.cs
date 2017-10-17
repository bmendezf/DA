using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Subject;
using ERP.Entities.Student;
using ERP.Entities.Teacher;

namespace ERP.Data
{
    interface IDataSubject
    {
        List<Subject> Subjects { get; set; }

        bool AddSubject(Subject aSubject);

        bool DeleteSubject(Subject aSubject);

        bool UpdateSubject(Subject aSubject);

        Subject GetSubject(Subject aSubject);
        List<Subject> GetAllSubjects();
        List<Student> GetStudentsBySubject(Subject aSubject);
        List<Teacher> GetTeachersBySubject(Subject aSubject);


    }
}

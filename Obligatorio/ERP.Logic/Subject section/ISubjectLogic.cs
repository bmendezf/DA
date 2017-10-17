using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Subject;
using ERP.Entities.Student;
using ERP.Entities.Teacher;

namespace ERP.Logic
{
    interface ISubjectLogic
    {
        bool AddSubject(Subject sSubject);

        bool DeleteSubject(Subject sSubject);

        bool UpdateSubject(Subject sSubject);

        Subject GetSubject(Subject sSubject);
        List<Subject> GetAllSubjects();
        List<Student> GetStudentsBySubject(Subject aSubject);
        List<Teacher> GetTeachersBySubject(Subject aSubject);
    }
}

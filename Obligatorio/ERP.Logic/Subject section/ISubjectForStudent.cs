using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Subject;
using ERP.Entities.Student;



namespace ERP.Logic
{
    interface ISubjectForStudent
    {
        List<Subject> GetSubjectsByStudent(Student aStudent);

    }
}

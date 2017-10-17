using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Teacher;
using ERP.Entities.Subject;



namespace ERP.Logic
{
    interface ISubjectForTeacher
    {
        List<Subject> GetSubjectsByTeacher(Teacher aTeacher);

    }
}

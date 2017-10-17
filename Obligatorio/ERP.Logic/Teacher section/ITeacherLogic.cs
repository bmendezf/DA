using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Teacher;


namespace ERP.Logic
{
    interface ITeacherLogic
    {
        bool AddTeacher(Teacher aTeacher);

        bool DeleteTeacher(Teacher aTeacher);

        bool UpdateTeacher(Teacher aTeacher);

        List<Teacher> GetAllTeachers();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Teacher;


namespace ERP.Data
{
    interface IDataTeacher
    {
        List<Teacher> Teachers { get; set; }
        bool AddTeacher(Teacher aTeacher);

        bool DeleteTeacher(Teacher aTeacher);

        bool UpdateTeacher(Teacher aTeacher);

        Teacher GetTeacher(Teacher aTeacher);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Subject
{
     interface ISubject
    {
        string Name { get; set; }

        string Code { get; set; }

        List<Student.Student> Students { get; set; }

        List<Teacher.Teacher> Teachers { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Data
{
    interface IData
    {
         List<ERP.Entities.Student.Student> Students { get; set; }
         List<ERP.Entities.Subject.Subject> Subjects { get; set; }
         List<ERP.Entities.Teacher.Teacher> Teachers { get; set; }
         List<ERP.Entities.Van.Van> Vans { get; set; }
    }
}

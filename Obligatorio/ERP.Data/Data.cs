using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Data
{
    public class Data
    {
        public static List<ERP.Entities.Student.Student> students = new List<ERP.Entities.Student.Student>();
        public static List<ERP.Entities.Subject.Subject> subjects = new List<ERP.Entities.Subject.Subject>();
        public static List<ERP.Entities.Teacher.Teacher> teachers = new List<ERP.Entities.Teacher.Teacher>();
        public static List<ERP.Entities.Van.Van> vans = new List<ERP.Entities.Van.Van>();
    }
}

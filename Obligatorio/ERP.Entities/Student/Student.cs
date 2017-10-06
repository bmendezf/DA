using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Student
{
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int CI { get; set; }
        public int StudentNumber { get; set; }

        public Student()
        {
            Name = "";
            LastName = "";
            CI = 0;
        }
    }

}

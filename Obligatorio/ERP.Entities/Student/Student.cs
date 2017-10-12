using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Subject;

namespace ERP.Entities.Student
{
    public struct Coordenada
    {
        public int x;
        public int y;
        public Coordenada(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int CI { get; set; }
        public int StudentNumber { get; set; }
        public Coordenada coordenada { get; set; }
        

        public Student()
        {
            Name = "";
            LastName = "";
            CI = 0;
            StudentNumber = 0;
          
        }
    }

}

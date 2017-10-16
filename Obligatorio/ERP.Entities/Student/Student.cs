using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Subject;

namespace ERP.Entities.Student
{
    public struct coordenada
    {
        public int x { get; set; }
        public int y { get; set; }
        public coordenada(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Student
    {
        private static int nextStudentNumber = 0;
        public string Name { get; set; }
        public string LastName { get; set; }
        public int CI { get; set; }
        public int StudentNumber { get; set; }
        public coordenada Coordenada { get; set; }
        

        public Student()
        {
            Name = "";
            LastName = "";
            CI = 0;
            StudentNumber = nextStudentNumber;
            Coordenada = new coordenada(0, 0);
            nextStudentNumber++;
        }

        public override bool Equals(object obj)
        {
            Student aStudent = obj as Student;

            if (aStudent == null)
            {
                return false;
            }
            return this.StudentNumber== aStudent.StudentNumber;
        }


    }

}

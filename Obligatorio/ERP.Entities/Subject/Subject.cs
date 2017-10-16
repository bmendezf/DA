using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Subject
{
    public class Subject
    {
        public string Name;

        public string Code;

        public List<Student.Student> Students;

        public List<Teacher.Teacher> Teachers;

        public Subject()
        {
            this.Name = "";
            this.Code = "";
            this.Students = new List<Student.Student>();
            this.Teachers = new List<Teacher.Teacher>();

        }

        public override bool Equals(object obj)
        {
            var item = obj as Subject;
            if (item == null) return false;
            return this.Code.Equals(item.Code);
        }
    }
}

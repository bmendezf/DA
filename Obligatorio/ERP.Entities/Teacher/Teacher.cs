using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Teacher
{
    public class Teacher
    {
        public string FirstName;

        public string LastName;

        public List<Subject.Subject> Subjects;

        public string Id;
        public Teacher()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Id = "";
            this.Subjects = new List<Subject.Subject>();
        }

        public override bool Equals(object obj)
        {
            var item = obj as Teacher;
            if (item == null) return false;
            return this.Id.Equals(item.Id);
        }
    }
}

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
            this.Subjects = new List<Subject.Subject>();
        }

    }
}

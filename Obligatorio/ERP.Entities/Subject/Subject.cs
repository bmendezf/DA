using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Subject
{
    public class Subject: ISubject
    {
        private string _Name;

        private string _Code;

        private List<Student.Student> _Students;

        private List<Teacher.Teacher> _Teachers;

        public Subject()
        {
            _Name = "";
            _Code = "";
            _Students = new List<Student.Student>();
            _Teachers = new List<Teacher.Teacher>();

        }

        public override bool Equals(object obj)
        {
            var item = obj as Subject;
            if (item == null) return false;
            return this._Code.Equals(item._Code);
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }
        public List<ERP.Entities.Student.Student> Students
        {
            get { return _Students; }
            set { _Students = value; }
        }
        public List<ERP.Entities.Teacher.Teacher> Teachers
        {
            get { return _Teachers; }
            set { _Teachers = value; }
        }
    }
}

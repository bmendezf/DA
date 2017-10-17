using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Teacher
{
    public class Teacher: ITeacher
    {
        private string _FirstName;

        private string _LastName;

        private List<Subject.Subject> _Subjects;

        private string _Id;

        public Teacher()
        {
            _FirstName = "";
            _LastName = "";
            _Id = "";
            _Subjects = new List<Subject.Subject>();
        }

        public override bool Equals(object obj)
        {
            var item = obj as Teacher;
            if (item == null) return false;
            return this._Id.Equals(item._Id);
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public List<ERP.Entities.Subject.Subject> Subjects
        {
            get { return _Subjects; }
            set { _Subjects = value; }
        }
        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
    }
}

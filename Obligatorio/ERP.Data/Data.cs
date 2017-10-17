using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Data
{
    public class Data : IData
    {
        private List<ERP.Entities.Student.Student> _Students ;
        private List<ERP.Entities.Subject.Subject> _Subjects;
        private List<ERP.Entities.Teacher.Teacher> _Teachers = new List<ERP.Entities.Teacher.Teacher>();
        private List<ERP.Entities.Van.Van> _Vans = new List<ERP.Entities.Van.Van>();

        public Data()
        {
            _Students = new List<ERP.Entities.Student.Student>();
            _Subjects = new List<ERP.Entities.Subject.Subject>();
        }
        public List<ERP.Entities.Student.Student> Students
        {
            get { return _Students; }
            set { _Students = value; }
        }

        public List<ERP.Entities.Subject.Subject> Subjects
        {
            get { return _Subjects; }
            set { _Subjects = value; }
        }

        public List<ERP.Entities.Teacher.Teacher> Teachers
        {
            get { return _Teachers; }
            set { _Teachers = value; }
        }

        public List<ERP.Entities.Van.Van> Vans
        {
            get { return _Vans; }
            set { _Vans = value; }
        }

    }
}

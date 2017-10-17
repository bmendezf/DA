using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Student;
using ERP.Entities.Subject;
using ERP.Entities.Van;
using ERP.Entities.Teacher;

namespace ERP.Data
{
    public class Data : IDataStudent, IDataSubject, IDataTeacher, IDataVan
    {
        private List<Student> _Students ;
        private List<Subject> _Subjects;
        private List<Teacher> _Teachers = new List<ERP.Entities.Teacher.Teacher>();
        private List<Van> _Vans = new List<ERP.Entities.Van.Van>();

        public Data()
        {
            _Students = new List<Student>();
            _Subjects = new List<Subject>();
        }
        public List<Student> Students
        {
            get { return _Students; }
            set { _Students = value; }
        }

        public List<Subject> Subjects
        {
            get { return _Subjects; }
            set { _Subjects = value; }
        }

        public List<Teacher> Teachers
        {
            get { return _Teachers; }
            set { _Teachers = value; }
        }

        public List<Van> Vans
        {
            get { return _Vans; }
            set { _Vans = value; }
        }

        public bool AddStudent(Student aStudent) { return false; }

        public bool DeleteStudent(Student aStudent) { return false; }

        public bool UpdateStudent(Student aStudent) { return false; }

        public Student GetStudent(Student aStudent) { return null; }

        public bool AddSubject(Subject sSubject) { return false; }

        public bool DeleteSubject(Subject sSubject) { return false; }

        public bool UpdateSubject(Subject sSubject) { return false; }

        public Subject GetSubject(Subject sSubject) { return null; }

        public bool AddTeacher(Teacher aTeacher) { return false; }

        public bool DeleteTeacher(Teacher aStudent) { return false; }

        public bool UpdateTeacher(Teacher aStudent) { return false; }

        public Teacher GetTeacher(Teacher aStudent) { return null; }

        public bool AddVan(Van aVan) { return false; }

        public bool DeleteVan(Van aVan) { return false; }

        public bool UpdateVan(Van aVan) { return false; }

        public Van GetVan(Van aVan) { return null; }
    }
}

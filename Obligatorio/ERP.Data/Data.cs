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

        public bool AddStudent(Student aStudent)
        {
            if (Students.Contains(aStudent))
            {
                return false;
            }
            else
            {
                Students.Add(aStudent);
                return true;
            }
        }

        public bool DeleteStudent(Student aStudent) {
            if (Students.Contains(aStudent))
            {
                Students.Remove(aStudent);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateStudent(Student aStudent) { return false; }

        public Student GetStudent(Student aStudent)
        {
            if (!Students.Contains(aStudent))
            {
                return null;
            }
            else
            {
                int index = Students.IndexOf(aStudent);
                return Students[index];
            }
        }

        public bool AddSubject(Subject aSubject)
        {
            if (Subjects.Contains(aSubject))
            {
                return false;
            }
            else
            {
                Subjects.Add(aSubject);
                return true;
            }
        }

        public bool DeleteSubject(Subject aSubject)
        {
            if (!Subjects.Contains(aSubject))
            {
                return false;
            }
            else
            {
                Subjects.Remove(aSubject);
                return true;
            }
        }

        public bool UpdateSubject(Subject aSubject)
        {
            if (!Subjects.Contains(aSubject))
            {
                return false;
            }
            else
            {
                int index = Subjects.IndexOf(aSubject);
                Subjects[index] = aSubject;
                return true;
            }
        }

        public Subject GetSubject(Subject aSubject)
        {
            if (!Subjects.Contains(aSubject))
            {
                return null;
            }
            else
            {
                int index = Subjects.IndexOf(aSubject);
                return Subjects[index];
            }
        }

        public bool AddTeacher(Teacher aTeacher)
        {
            if (Teachers.Contains(aTeacher))
            {
                return false;
            }
            else
            {
                Teachers.Add(aTeacher);
                return true;
            }
        }

        public bool DeleteTeacher(Teacher aTeacher) {
            if (!Teachers.Contains(aTeacher))
            {
                return false;
            }
            else
            {
                Teachers.Remove(aTeacher);
                return true;
            }
        }

        public bool UpdateTeacher(Teacher aTeacher)
        {
            if (!Teachers.Contains(aTeacher))
            {
                return false;
            }
            else
            {
                int index = Teachers.IndexOf(aTeacher);
                Teachers[index] = aTeacher;
                return true;
            }
        }

        public Teacher GetTeacher(Teacher aTeacher)
        {
            if (!Teachers.Contains(aTeacher))
            {
                return null;
            }
            else
            {
                int index = Teachers.IndexOf(aTeacher);
                return Teachers[index];
            }
        }

        public List<Teacher> GetAllTeachers()
        {
            return Teachers;
        }
        public List<Subject> GetAllSubjects()
        {
            return Subjects;
        }
        public List<Student> GetStudentsBySubject(Subject aSubject)
        {
            if (Subjects.Contains(aSubject))
            {
                return GetSubject(aSubject).Students;
            }else
            {
                return null;
            }
        }

        public List<Teacher> GetTeachersBySubject(Subject aSubject)
        {
            if (Subjects.Contains(aSubject))
            {
                return GetSubject(aSubject).Teachers;
            }
            else
            {
                return null;
            }
        }

        public List<Subject> GetSubjectsByStudent(Student aStudent)
        {
            List<Subject> aList = null;
            if (Students.Contains(aStudent))
            {
                foreach (Subject sub in Subjects)
                {
                    if (sub.Students.Contains(aStudent))
                    {
                        if (aList == null)
                        {
                            aList = new List<Subject>();
                        }
                        aList.Add(sub);
                    }
                }
            }

            return aList;
        }

        public List<Subject> GetSubjectsByTeacher(Teacher aTeacher)
        {
            List<Subject> aList = null;
            if (Teachers.Contains(aTeacher))
            {
                foreach (Subject sub in Subjects)
                {
                    if (sub.Teachers.Contains(aTeacher))
                    {
                        if(aList == null)
                        {
                            aList = new List<Subject>();
                        }
                        aList.Add(sub);
                    }
                }
            }

            return aList;
        }

        public bool AddVan(Van aVan) { return false; }

        public bool DeleteVan(Van aVan) { return false; }

        public bool UpdateVan(Van aVan) { return false; }

        public Van GetVan(Van aVan) { return null; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Logic
{
    public class StudentLogic
    {
        public bool addStudent(Entities.Student.Student aStudent)
        {
            if (ERP.Data.Data.Students.Contains(aStudent))
            {
                return false;
            }
            ERP.Data.Data.Students.Add(aStudent);
            return true;
        }

        public Entities.Student.Student getStudent(Entities.Student.Student aStudent)
        {
            foreach (Entities.Student.Student student in ERP.Data.Data.Students)
            {
                if (student.Equals(aStudent))
                {
                    return student;
                }
            }
            return aStudent;
        }

        public List<Entities.Student.Student> getAllStudents()
        {
            return Data.Data.Students;
        }

        public bool deleteStudent(Entities.Student.Student aStudent)
        {
            if (ERP.Data.Data.Students.Contains(aStudent))
            {
                ERP.Data.Data.Students.Remove(aStudent);
                return true;
            }
            return false;
        }

        public bool updateStudent(Entities.Student.Student aStudent)
        {
            if (ERP.Data.Data.Students.Contains(aStudent))
            {
                ERP.Data.Data.Students.Remove(aStudent);
                ERP.Data.Data.students.Add(aStudent);
                return true;
            }
            return false;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Student;

namespace ERP.Logic
{
    public class StudentLogic: IStudentLogic
    {
        private Data.Data dataBase;

        public StudentLogic(Data.Data someDatabase)
        {
            this.dataBase = someDatabase;
        }

        public bool AddStudent(Student aStudent)
        {
            return dataBase.AddStudent(aStudent);
        }

        public bool DeleteStudent(Student aStudent)
        {
            throw new NotImplementedException();
        }

        public bool GetAllStudents(Student aStudent)
        {
            throw new NotImplementedException();
        }

        public Student getStudent(Student aStudent)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStudent(Student aStudent)
        {
            throw new NotImplementedException();
        }

        //public Entities.Student.Student getStudent(Entities.Student.Student aStudent)
        //{
        //    foreach (Entities.Student.Student student in ERP.Data.Data.Students)
        //    {
        //        if (student.Equals(aStudent))
        //        {
        //            return student;
        //        }
        //    }
        //    return aStudent;
        //}

        //public List<Entities.Student.Student> getAllStudents()
        //{
        //    return Data.Data.Students;
        //}

        //public bool deleteStudent(Entities.Student.Student aStudent)
        //{
        //    if (ERP.Data.Data.Students.Contains(aStudent))
        //    {
        //        ERP.Data.Data.Students.Remove(aStudent);
        //        return true;
        //    }
        //    return false;
        //}

        //public bool updateStudent(Entities.Student.Student aStudent)
        //{
        //    if (ERP.Data.Data.Students.Contains(aStudent))
        //    {
        //        ERP.Data.Data.Students.Remove(aStudent);
        //        ERP.Data.Data.students.Add(aStudent);
        //        return true;
        //    }
        //    return false;
        //}

    }
}
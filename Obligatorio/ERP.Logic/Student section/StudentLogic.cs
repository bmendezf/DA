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
            return dataBase.DeleteStudent(aStudent);
        }

        public bool GetAllStudents(Student aStudent)
        {
            throw new NotImplementedException();
        }

        public Student getStudent(Student aStudent)
        {
            return dataBase.GetStudent(aStudent);
        }

        public bool UpdateStudent(Student aStudent)
        {
            return dataBase.UpdateStudent(aStudent);
        }
    }
}
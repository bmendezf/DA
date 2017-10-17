using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Student;
using ERP.Entities.Validators.Student;

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
            if (ERP.Entities.Validators.Student.StudentValidator.CIValidator(aStudent.CI))
            {
                return dataBase.AddStudent(aStudent);
            }
            else
            {
                return false;
            }
            
        }

        public bool DeleteStudent(Student aStudent)
        {
            return dataBase.DeleteStudent(aStudent);
        }

        public Student getStudent(Student aStudent)
        {
            return dataBase.GetStudent(aStudent);
        }

        public bool UpdateStudent(Student aStudent)
        {
            if (ERP.Entities.Validators.Student.StudentValidator.CIValidator(aStudent.CI))
            {
                return dataBase.UpdateStudent(aStudent);
            }
            else
            {
                return false;
            }    
        }

        public List<Student> GetAllStudents()
        {
            return dataBase.GetAllStudents() ;
        }
    }
}
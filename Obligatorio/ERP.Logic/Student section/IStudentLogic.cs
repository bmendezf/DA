using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Student;

namespace ERP.Logic
{
    interface IStudentLogic
    {
        bool AddStudent(Student aStudent);

        bool DeleteStudent(Student aStudent);

        bool UpdateStudent(Student aStudent);

        List<Student> GetAllStudents();

        Student getStudent(Student aStudent);

    }
}

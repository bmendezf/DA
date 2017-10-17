using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Student;

namespace ERP.Data
{
    interface IDataStudent
    {
         List<Student> Students { get; set; }
         
        bool AddStudent(Student aStudent);

        bool DeleteStudent(Student aStudent);

        bool UpdateStudent(Student aStudent);

        Student GetStudent(Student aStudent);

       
    }
}

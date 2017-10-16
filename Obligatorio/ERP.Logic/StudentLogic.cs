﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Logic
{
    public class StudentLogic
    {
        public static bool addStudent(Entities.Student.Student aStudent)
        {
            ERP.Data.Data.students.Add(aStudent);
            return true;
        }
        public static Entities.Student.Student getStudent(Entities.Student.Student aStudent)
        {
            foreach (Entities.Student.Student student in ERP.Data.Data.students)
            {
                if (student.Equals(aStudent))
                {
                    return student;
                }
            }
            return aStudent;
        }



    }
}
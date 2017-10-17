using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Teacher;


namespace ERP.Logic
{
    public class TeacherLogic: ITeacherLogic
    {
        private Data.Data database;

        public TeacherLogic(Data.Data someDatabase)
        {
            this.database = someDatabase;
        }
        public bool AddTeacher(Teacher aTeacher)
        {
            //RUN VALIDATORS
            return database.AddTeacher(aTeacher);
        }

        public bool DeleteTeacher(Teacher aTeacher)
        {  
            //RUN VALIDATORS
            return database.DeleteTeacher(aTeacher);
        }

        public bool UpdateTeacher(Teacher aTeacher)
        {
            //RUN VALIDATORS
            return database.UpdateTeacher(aTeacher);
        }

        public List<Teacher> GetAllTeachers()
        {
            //RUN VALIDATORS
            return database.GetAllTeachers();
        }
    }
}

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
        public bool AddTeacher(Teacher aTeacher) { return false; }

        public bool DeleteTeacher(Teacher aTeacher) { return false; }

        public bool UpdateTeacher(Teacher aTeacher) { return false; }

        public List<Teacher> GetAllTeachers() { return null; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Teacher
{
    public class ITeacher
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        List<Subject.Subject> Subjects { get; set; }
        string Id { get; set; }
    }
}

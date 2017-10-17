using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Student
{
    interface IStudent
    {
        string Name { get; set; }
        string LastName { get; set; }
        string CI { get; set; }
        int StudentNumber { get; set; }
        Coordinate Coordinates { get; set; }
    }
}

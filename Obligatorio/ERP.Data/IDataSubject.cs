using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Subject;

namespace ERP.Data
{
    interface IDataSubject
    {
        List<Subject> Subjects { get; set; }

        bool AddSubject(Subject sSubject);

        bool DeleteSubject(Subject sSubject);

        bool UpdateSubject(Subject sSubject);

        bool GetSubject(Subject sSubject);



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Section
{
    interface ISection
    {
        string Name { get; set; }
        string Description { get; set; }
        List<string> Actions { get; set; }
    }
}

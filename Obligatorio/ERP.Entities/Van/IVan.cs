using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Van
{
    interface IVan
    {
        int Capacity { get; set; }
        string LicensePlate { get; set; }
    }
}

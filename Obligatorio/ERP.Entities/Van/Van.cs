using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Van
{
    public class Van
    {
        public bool Availability { get; set; }
        public int Capacity { get; set; }
        public string LicensePlate { get; set; }

        public Van()
        {
            Availability = true;
            Capacity = 0;
            LicensePlate = "";
        }
    }
}

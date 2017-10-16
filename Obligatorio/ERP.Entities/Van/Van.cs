using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Van
{
    public class Van
    {
        public int Capacity { get; set; }
        public string LicensePlate { get; set; }

        public Van()
        {
            Capacity = 0;
            LicensePlate = "";
        }

        public override bool Equals(object obj)
        {
            Van aVan = obj as Van;

            if (aVan == null)
            {
                return false;
            }
            return this.LicensePlate == aVan.LicensePlate;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Logic
{
    public class VanLogic
    {
        public static bool addVan(Entities.Van.Van aVan)
        {
            if (ERP.Data.Data.vans.Contains(aVan))
            {
                return false;
            }
            ERP.Data.Data.vans.Add(aVan);
            return true;
        }

        public static Entities.Van.Van getVan(Entities.Van.Van aVan)
        {
            foreach (Entities.Van.Van van in ERP.Data.Data.vans)
            {
                if (van.Equals(aVan))
                {
                    return van;
                }
            }
            return aVan;
        }

        public static List<Entities.Van.Van> getAllVans()
        {
            return Data.Data.vans;
        }

        public static bool deleteVan(Entities.Van.Van aVan)
        {
            if (ERP.Data.Data.vans.Contains(aVan))
            {
                ERP.Data.Data.vans.Remove(aVan);
                return true;
            }
            return false;
        }

        public static bool updateVan(Entities.Van.Van aVan)
        {
            if (ERP.Data.Data.vans.Contains(aVan))
            {
                ERP.Data.Data.vans.Remove(aVan);
                ERP.Data.Data.vans.Add(aVan);
                return true;
            }
            return false;
        }
    }
}

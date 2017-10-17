using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Van;

namespace ERP.Logic
{
    public class VanLogic : IVanLogic
    {
        private Data.Data dataBase;

        public VanLogic(Data.Data someDatabase)
        {
            this.dataBase = someDatabase;
        }

        public bool AddVan(Van aVan)
        {
            return dataBase.AddVan(aVan);
        }

        public bool DeleteVan(Van aVan)
        {
            return dataBase.DeleteVan(aVan);
        }

        public List<Van> GetAllVans()
        {
            throw new NotImplementedException();
        }

        public int getAmountOfVans()
        {
            throw new NotImplementedException();
        }

        public Van GetVan(Van aVan)
        {
            return dataBase.GetVan(aVan);
        }

        public int getVanCapacity(Van aVan)
        {
            throw new NotImplementedException();
        }

        public bool UpdateVan(Van aVan)
        {
            throw new NotImplementedException();
        }
        //public static bool addVan(Entities.Van.Van aVan)
        //{
        //    if (ERP.Data.Data.vans.Contains(aVan))
        //    {
        //        return false;
        //    }
        //    ERP.Data.Data.vans.Add(aVan);
        //    return true;
        //}

        //public static Entities.Van.Van getVan(Entities.Van.Van aVan)
        //{
        //    foreach (Entities.Van.Van van in ERP.Data.Data.vans)
        //    {
        //        if (van.Equals(aVan))
        //        {
        //            return van;
        //        }
        //    }
        //    return aVan;
        //}

        //public static List<Entities.Van.Van> getAllVans()
        //{
        //    return Data.Data.vans;
        //}

        //public static bool deleteVan(Entities.Van.Van aVan)
        //{
        //    if (ERP.Data.Data.vans.Contains(aVan))
        //    {
        //        ERP.Data.Data.vans.Remove(aVan);
        //        return true;
        //    }
        //    return false;
        //}

        //public static bool updateVan(Entities.Van.Van aVan)
        //{
        //    if (ERP.Data.Data.vans.Contains(aVan))
        //    {
        //        ERP.Data.Data.vans.Remove(aVan);
        //        ERP.Data.Data.vans.Add(aVan);
        //        return true;
        //    }
        //    return false;
        //}

        //public static int getCapacity(Entities.Van.Van aVan)
        //{
        //    int capacity = 0;
        //    Entities.Van.Van van = getVan(aVan);
        //    capacity = van.Capacity;

        //    return capacity;
        //}

        //public static int getAmount()
        //{
        //    int amount = 0;
        //    amount = Data.Data.vans.Count;

        //    return amount;
        //}

    }
}

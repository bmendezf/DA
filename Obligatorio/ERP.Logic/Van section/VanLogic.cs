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
            return dataBase.Vans;
        }

        public int GetAmountOfVans()
        {
            throw new NotImplementedException();
        }

        public Van GetVan(Van aVan)
        {
            return dataBase.GetVan(aVan);
        }

        public int GetVanCapacity(Van aVan)
        {
            return this.GetVan(aVan).Capacity;
        }

        public bool UpdateVan(Van aVan)
        {
            return dataBase.UpdateVan(aVan);
        }
    }
}

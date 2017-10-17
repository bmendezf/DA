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
            return dataBase.UpdateVan(aVan);
        }
    }
}

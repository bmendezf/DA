using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Van;
using ERP.Entities.Validators.Van;

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
            if (VanValidator.LicensePlateValidator(aVan.LicensePlate)) {
                return dataBase.AddVan(aVan);
            }
            else
            {
                return false;
            }
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
            return this.GetAllVans().Count;
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

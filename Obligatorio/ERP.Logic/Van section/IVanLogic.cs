using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Van;

namespace ERP.Logic
{
    interface IVanLogic
    {
        bool AddVan(Van aVan);
        bool DeleteVan(Van aVan);
        bool UpdateVan(Van aVan);
        Van GetVan(Van aVan);
        List<Van> GetAllVans();
        int getVanCapacity(Van aVan);
        int getAmountOfVans();
    }
}

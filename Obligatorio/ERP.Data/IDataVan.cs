using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Van;


namespace ERP.Data
{
    interface IDataVan
    {
        List<Van> Vans { get; set; }

        bool AddVan(Van aVan);

        bool DeleteVan(Van aVan);

        bool UpdateVan(Van aVan);

        Van GetVan(Van aVan);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ERP.Entities.Validators.Van
{
    public static class VanValidator
    {
        public static bool LicensePlateValidator(String aLicensePlate)
        {
            if (aLicensePlate.Length == 7)
            {              
                Regex r = new Regex(@"^[a-z A-Z 0-9]+$", RegexOptions.IgnoreCase);
                return r.IsMatch(aLicensePlate);
            }
            else
            {
                return false;
            }
        }
    }
}

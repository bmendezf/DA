using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Validators.Student
{
    public static class StudentValidator
    {
        public static bool CIValidator(String aCI)
        {
            
            if (aCI.Length== 9 && aCI.Contains("-"))
            {
                try
                {
                    string[] ciParts = aCI.Split('-');
                    string numericCI = "";
                    foreach (string element in ciParts)
                    {
                        numericCI = numericCI + element;
                    }
                    int j;
                    return Int32.TryParse(numericCI,out j);
                }
                catch (FormatException f)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

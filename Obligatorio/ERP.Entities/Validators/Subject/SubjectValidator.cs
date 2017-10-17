using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ERP.Entities.Validators.Subject
{
    public static class SubjectValidator
    {
        public static bool CodeValidator(String aSubjectNumber)
        { 
            Regex r = new Regex(@"^[0-9]+$", RegexOptions.IgnoreCase);
            return r.IsMatch(aSubjectNumber);
        }
    }
}

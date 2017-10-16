using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Module
{
    public class Section
    {
        public string Name;

        public string Description;

        public List<string> Actions;
        
        public Section()
        {
            this.Name = "";
            this.Description = "";
            this.Actions = new List<string>();
        }
    }
}

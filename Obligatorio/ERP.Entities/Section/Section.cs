using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Section
{
    public class Section : ISection
    {
        private string _Name;

        private string _Description;

        private List<string> _Actions;
        
        public Section()
        {
            _Name = "";
            _Description = "";
            _Actions = new List<string>();
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public List<string> Actions
        {
            get { return _Actions; }
            set { _Actions = value; }
        }
    }
}

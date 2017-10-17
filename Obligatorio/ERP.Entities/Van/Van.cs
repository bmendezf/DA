using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Van
{
    public class Van
    {
        private int _Capacity { get; set; }
        private string _LicensePlate { get; set; }

        public Van()
        {
            _Capacity = 0;
            _LicensePlate = "";
        }

        public override bool Equals(object obj)
        {
            Van aVan = obj as Van;

            if (aVan == null)
            {
                return false;
            }
            return this._LicensePlate == aVan._LicensePlate;
        }

        public int Capacity
        {
            get { return _Capacity; }
            set { _Capacity = value; }
        }
        public string LicensePlate
        {
            get { return _LicensePlate; }
            set { _LicensePlate = value; }
        }
    }
}
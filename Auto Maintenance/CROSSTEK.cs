using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Maintenance
{
    class CROSSTEK : Car
    {
        string _fuelType;
        public string FuelType { get { return _fuelType; } set { _fuelType = value; } }
    }
}

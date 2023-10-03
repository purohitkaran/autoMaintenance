using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Maintenance
{
    class SEDAN : Car
    {
        string _color;
        int _fuelEffeciency;

        public string Color { get { return _color; } set { _color = value; } }
        public int FuelEffeciency { get { return _fuelEffeciency; } set { _fuelEffeciency = value; } }
    }
}

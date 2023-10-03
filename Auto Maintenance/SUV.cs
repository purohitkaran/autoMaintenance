using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Maintenance
{
    class SUV : Car
    {
        string _mpg;
        string _wheelDrive;

        public string Mpg { get { return _mpg; } set { _mpg = value; } }
        public string WheelDrive { get { return _wheelDrive; } set { _wheelDrive = value; } }
    }
}

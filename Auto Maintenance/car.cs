using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Maintenance
{
    abstract class Car
    {
        string _make;
        string _model;
        int _year;

        public string Make { get { return _make; } set { _make = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public int Year { get { return _year; } set { _year = value; } }
    }
}

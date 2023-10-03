using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Maintenance
{
    class PersonalInfo
    {
        string _name;
        string _address;
        int _age;
        string _phoneNo;
        public PersonalInfo()
        {
        }
        public string Name { get { return _name; } set { _name = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public string PhoneNo
        {
            get { return _phoneNo; }
            set { _phoneNo = value; }
        }
    }
}

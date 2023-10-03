using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Maintenance
{
    class quote
    {
        string _estdPartsCharges;
        string _estdLaborCharges;
        string _salesTaxRate;
        string _salesTax;
        string _totalEstimate;
        public string EstdPartsCharges { get { return _estdPartsCharges; } set { _estdPartsCharges = value; } }
        public string EstdLaborCharges { get { return _estdLaborCharges; } set { _estdLaborCharges = value; } }
        public string SalesTaxRate { get { return _salesTaxRate; } set { _salesTaxRate = value; } }
        public string TotalEstimate { get { return _totalEstimate; } set { _totalEstimate = value; } }
        public string SalesTax { get { return _salesTax; } set { _salesTax = value; } }
        public static float calculateCharge(int makeYear)
        {
            int regularCharge = 100;
            int currentYear = DateTime.Now.Year;
            float finalCharge = regularCharge + (currentYear - makeYear)*10;
            return finalCharge;
        }
    }
}

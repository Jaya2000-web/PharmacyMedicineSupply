using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyMedicineSupply.Models
{
    public class PharmacyMedicineSupplyException : Exception
    {
        public PharmacyMedicineSupplyException(string Errmsg): base(Errmsg)
        {

        }
    }
}

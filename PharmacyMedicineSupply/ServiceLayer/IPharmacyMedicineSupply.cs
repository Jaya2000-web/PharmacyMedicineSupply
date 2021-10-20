using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyMedicineSupply
{
    public interface IPharmacyMedicineSupply
    {
        Task<List<PharmacyMedicineSupply>> GetAllPharmacies();
        Task<MedicineDemand> GetDemandList(MedicineDemand medicineDeman);
    }
}

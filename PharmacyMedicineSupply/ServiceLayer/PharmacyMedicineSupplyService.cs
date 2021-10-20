using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyMedicineSupply
{
    public class PharmacyMedicineSupplyService : IPharmacyMedicineSupply
    {
        PharmacyMedicineSupplyRepo repoObj = new PharmacyMedicineSupplyRepo();
        public async Task<List<PharmacyMedicineSupply>> GetAllPharmacies()
        {
            return await repoObj.GetAllPharmacies();
        }

        public async Task<MedicineDemand> GetDemandList(MedicineDemand medicineDeman)
        {
            return await repoObj.GetDemandList(medicineDeman);
        }

    }
}

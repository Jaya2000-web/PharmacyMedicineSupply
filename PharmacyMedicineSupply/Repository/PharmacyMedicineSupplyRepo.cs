using Microsoft.EntityFrameworkCore;
using PharmacyMedicineSupply.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PharmacyMedicineSupply
{
    public class PharmacyMedicineSupplyRepo : IPharmacyMedicineSupplyRepo
    {
        PharmacyMedicineSupplyContext dbContext = new PharmacyMedicineSupplyContext();
        public async Task<MedicineDemand> GetDemandList(MedicineDemand medicineDemand)
        {
            List<MedicineStock> stocks = new List<MedicineStock>();
            MedicineDemand medDemand = new MedicineDemand();
            //MedicineStock stock1 = new MedicineStock();
            List<PharmacyMedicineSupply> supplyList = new List<PharmacyMedicineSupply>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://medicinestock1234.azurewebsites.net/api/MedicineStock");
            //svc.BaseAddress = new Uri("https://localhost:44388/api/MedicineStock/");
            stocks = await client.GetFromJsonAsync<List<MedicineStock>>("");
            MedicineStock stock = stocks.Where(x => x.Name == medicineDemand.Medicine).First();
            if(medicineDemand.DemandCount <= stock.NumberOfTabletsInStock)
            {
                medDemand.DemandCount = medicineDemand.DemandCount;
                await dbContext.Medicines.AddAsync(medicineDemand);
                await dbContext.SaveChangesAsync();
                return medDemand;
            }
            else
            {
                throw new PharmacyMedicineSupplyException("Stock is Unavailable");
            }
        }
        public async Task<List<PharmacyMedicineSupply>> GetAllPharmacies()
        {
            return await dbContext.PharmacyMedicines.ToListAsync();
        }
    }
}

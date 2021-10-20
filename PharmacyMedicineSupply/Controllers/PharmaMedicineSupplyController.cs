using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PharmacyMedicineSupply.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PharmaMedicineSupplyController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(PharmaMedicineSupplyController));
        string[] PharmacyNames = new string[] { "Pharmacy 1", "Pharmacy 2", "Pharmacy 3" };
        List<PharmacyMedicineSupply> PharmacyMedicineSupplyList = new List<PharmacyMedicineSupply>();
        PharmacyMedicineSupplyContext dbContext = new PharmacyMedicineSupplyContext();
        PharmacyMedicineSupplyRepo repoObj = new PharmacyMedicineSupplyRepo();
        PharmacyMedicineSupplyService serviceObj = new PharmacyMedicineSupplyService();

        
        [HttpGet]

        public async Task<IActionResult> GetPharmacies()
        {
            
            _log4net.Info("Get all Medicine details");
            var identity = User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                List<PharmacyMedicineSupply> pharmacyMedicineSupplies = await (serviceObj.GetAllPharmacies());
                if (pharmacyMedicineSupplies != null)
                {
                    return Ok(pharmacyMedicineSupplies);
                }
                else
                {
                    return NoContent();
                }
            }
            else
            {
                return Unauthorized();
            }
        }
        

        [HttpPost("MedicineDemand")]
        public async Task<IEnumerable<PharmacyMedicineSupply>> ListOfPharmacies(MedicineDemand medicineDemand)
        {
            _log4net.Info("Post PharmacyMedicineSupply");
            await serviceObj.GetDemandList(medicineDemand);
            for(int i=0; i < PharmacyNames.Length; i++)
            {
                PharmacyMedicineSupply pharmacyMedicineSupply = new PharmacyMedicineSupply();
                pharmacyMedicineSupply.PharmacyName = PharmacyNames[i];
                pharmacyMedicineSupply.MedicineName = medicineDemand.Medicine;
                pharmacyMedicineSupply.SupplyCount = Convert.ToInt32(medicineDemand.DemandCount / PharmacyNames.Length);
                if (i == 0)
                {
                    pharmacyMedicineSupply.SupplyCount += Convert.ToInt32(medicineDemand.DemandCount % PharmacyNames.Length);
                }
                PharmacyMedicineSupplyList.Add(pharmacyMedicineSupply);

            }
            await dbContext.PharmacyMedicines.AddRangeAsync(PharmacyMedicineSupplyList);
            await dbContext.SaveChangesAsync();
            return PharmacyMedicineSupplyList;
        }
    }
}

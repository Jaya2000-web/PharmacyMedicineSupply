using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PharmacyMedicineSupply.Controllers;
using PharmacyMedicineSupply;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace PharmacyMedicineSupplyTest
{
    public class PharmacyMedicineTest
    {
        [TestCase]
        public async Task ListOfPharmacies()
        {
            //var controller = new PharmaMedicineSupplyController();
            var demand = new PharmacyMedicineSupplyService();
            //IEnumerable<PharmacyMedicineSupply.PharmacyMedicineSupply> PharmacyMedicineSupplyList = new List<PharmacyMedicineSupply.PharmacyMedicineSupply>() { };

            MedicineDemand medicineDemand = new MedicineDemand
            {
                Medicine = "Dolo 650",
                DemandCount = 30
            };
            var serviceres = await demand.GetDemandList(medicineDemand);
            Assert.AreEqual(medicineDemand.GetType(), serviceres.GetType());



        }

        [TestCase]
        public async Task AllDemandList()
        {
            var alldemand = new PharmacyMedicineSupplyService();
            PharmacyMedicineSupply.PharmacyMedicineSupply pharmacyMedicineSupply = new PharmacyMedicineSupply.PharmacyMedicineSupply();

            var res = await alldemand.GetAllPharmacies();
            Assert.AreEqual(pharmacyMedicineSupply.GetType(), res[1].GetType());
        }

       /* [TestCase]
        public async Task Errortest()
        {
            var demand = new PharmacyMedicineSupplyService();
            //IEnumerable<PharmacyMedicineSupply.PharmacyMedicineSupply> PharmacyMedicineSupplyList = new List<PharmacyMedicineSupply.PharmacyMedicineSupply>() { };

            MedicineDemand medicineDemand = new MedicineDemand
            {
                Medicine = "Gaviscon",
                DemandCount = 200
            };
            var serviceres = await demand.GetDemandList(medicineDemand);
            string res = "Stock is Unavailable";
            Assert.AreEqual(res.GetType(), serviceres.GetType());

        }*/

        [TestCase]
        public async Task ControllerTest()
        {
            var controller = new PharmaMedicineSupplyController();
            MedicineDemand medicineDemand = new MedicineDemand
            {
                Medicine = "Dolo 650",
                DemandCount = 30
            };
            List<PharmacyMedicineSupply.PharmacyMedicineSupply> pharmacyMedicineSupply = new List<PharmacyMedicineSupply.PharmacyMedicineSupply>();

            var Actionresult = await controller.ListOfPharmacies(medicineDemand);
            Assert.AreEqual(Actionresult.GetType(), pharmacyMedicineSupply.GetType());

        }
    }
}

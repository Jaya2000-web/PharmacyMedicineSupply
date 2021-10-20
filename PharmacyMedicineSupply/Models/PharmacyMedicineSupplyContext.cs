using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyMedicineSupply
{
    public class PharmacyMedicineSupplyContext : DbContext
    {
        public PharmacyMedicineSupplyContext()
        {

        }

        public PharmacyMedicineSupplyContext(DbContextOptions<PharmacyMedicineSupplyContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:stockdb1234.database.windows.net,1433;Initial Catalog=SupplyDB;Persist Security Info=False;User ID=divya214;Password=Divya@214;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            /*modelBuilder.Entity<MedicineStock>().HasData(
            new MedicineStock
            {
                Name = "Dolo 650",
                ChemicalComposition = "Paracetamol,Acetaminophen",
                TargetAilment = "General",
                DateOfExpiry = DateTime.Parse("31-12-2022"),
                NumberOfTabletsInStock = 300
            },
            new MedicineStock
            {
                Name = "Orthoherb",
                ChemicalComposition = "Castor Plant,Adulsa,Neem,Guggul",
                TargetAilment = "Orthopaedics",
                DateOfExpiry = DateTime.Parse("26-11-2021"),
                NumberOfTabletsInStock = 190
            },
            new MedicineStock
            {
                Name = "Cholecalciferol",
                ChemicalComposition = "Ergocalciferol,Cholecalciferol,22-DiHydroergoCalciferol",
                TargetAilment = "Orthopaedics",
                DateOfExpiry = DateTime.Parse("10-11-2023"),
                NumberOfTabletsInStock = 200
            },
            new MedicineStock
            {
                Name = "Gaviscon",
                ChemicalComposition = "Magnesium,Oxide,Silicon,Sodium",
                TargetAilment = "General",
                DateOfExpiry = DateTime.Parse("20-08-2022"),
                NumberOfTabletsInStock = 150
            },
            new MedicineStock
            {
                Name = "Hilact",
                ChemicalComposition = "Pancreatin,Dimethicone,Polydimethylsiloxane",
                TargetAilment = "Gynaecology",
                DateOfExpiry = DateTime.Parse("11-06-2024"),
                NumberOfTabletsInStock = 400
            },
             new MedicineStock
             {
                 Name = "Cyclopam",
                 ChemicalComposition = "Dicyclomine,Hydrochloride,Paracetamol",
                 TargetAilment = "Gynaecology",
                 DateOfExpiry = DateTime.Parse("02-11-2025"),
                 NumberOfTabletsInStock = 500
             }
            );


            base.OnModelCreating(modelBuilder);
            var keysProperties = modelBuilder.Model.GetEntityTypes().Select(x => x.FindPrimaryKey()).SelectMany(x => x.Properties);
            foreach (var property in keysProperties)
            {
                property.ValueGenerated = ValueGenerated.OnAdd;
            }
        }*/

        
            
        

        public DbSet<MedicineDemand> Medicines { get; set; }
        public DbSet<MedicineStock> MedicineStocks { get; set; }
        public DbSet<PharmacyMedicineSupply> PharmacyMedicines { get; set; }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacyMedicineSupply.Migrations
{
    public partial class migr4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MedicineStock",
                keyColumn: "Name",
                keyValue: "Cholecalciferol");

            migrationBuilder.DeleteData(
                table: "MedicineStock",
                keyColumn: "Name",
                keyValue: "Cyclopam");

            migrationBuilder.DeleteData(
                table: "MedicineStock",
                keyColumn: "Name",
                keyValue: "Dolo 650");

            migrationBuilder.DeleteData(
                table: "MedicineStock",
                keyColumn: "Name",
                keyValue: "Gaviscon");

            migrationBuilder.DeleteData(
                table: "MedicineStock",
                keyColumn: "Name",
                keyValue: "Hilact");

            migrationBuilder.DeleteData(
                table: "MedicineStock",
                keyColumn: "Name",
                keyValue: "Orthoherb");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MedicineStock",
                columns: new[] { "Name", "ChemicalComposition", "DateOfExpiry", "NumberOfTabletsInStock", "TargetAilment" },
                values: new object[,]
                {
                    { "Dolo 650", "Paracetamol,Acetaminophen", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 300, "General" },
                    { "Orthoherb", "Castor Plant,Adulsa,Neem,Guggul", new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 190, "Orthopaedics" },
                    { "Cholecalciferol", "Ergocalciferol,Cholecalciferol,22-DiHydroergoCalciferol", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 200, "Orthopaedics" },
                    { "Gaviscon", "Magnesium,Oxide,Silicon,Sodium", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 150, "General" },
                    { "Hilact", "Pancreatin,Dimethicone,Polydimethylsiloxane", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 400, "Gynaecology" },
                    { "Cyclopam", "Dicyclomine,Hydrochloride,Paracetamol", new DateTime(2025, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, "Gynaecology" }
                });
        }
    }
}

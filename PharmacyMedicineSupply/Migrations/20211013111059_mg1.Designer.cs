﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharmacyMedicineSupply;

namespace PharmacyMedicineSupply.Migrations
{
    [DbContext(typeof(PharmacyMedicineSupplyContext))]
    [Migration("20211013111059_mg1")]
    partial class mg1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PharmacyMedicineSupply.MedicineDemand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DemandCount")
                        .HasColumnType("int");

                    b.Property<string>("Medicine")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MedicineDemand");
                });

            modelBuilder.Entity("PharmacyMedicineSupply.MedicineStock", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChemicalComposition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfExpiry")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfTabletsInStock")
                        .HasColumnType("int");

                    b.Property<string>("TargetAilment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("MedicineStock");

                    b.HasData(
                        new
                        {
                            Name = "Dolo 650",
                            ChemicalComposition = "Paracetamol,Acetaminophen",
                            DateOfExpiry = new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfTabletsInStock = 300,
                            TargetAilment = "General"
                        },
                        new
                        {
                            Name = "Orthoherb",
                            ChemicalComposition = "Castor Plant,Adulsa,Neem,Guggul",
                            DateOfExpiry = new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfTabletsInStock = 190,
                            TargetAilment = "Orthopaedics"
                        },
                        new
                        {
                            Name = "Cholecalciferol",
                            ChemicalComposition = "Ergocalciferol,Cholecalciferol,22-DiHydroergoCalciferol",
                            DateOfExpiry = new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfTabletsInStock = 200,
                            TargetAilment = "Orthopaedics"
                        },
                        new
                        {
                            Name = "Gaviscon",
                            ChemicalComposition = "Magnesium,Oxide,Silicon,Sodium",
                            DateOfExpiry = new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfTabletsInStock = 150,
                            TargetAilment = "General"
                        },
                        new
                        {
                            Name = "Hilact",
                            ChemicalComposition = "Pancreatin,Dimethicone,Polydimethylsiloxane",
                            DateOfExpiry = new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfTabletsInStock = 400,
                            TargetAilment = "Gynaecology"
                        },
                        new
                        {
                            Name = "Cyclopam",
                            ChemicalComposition = "Dicyclomine,Hydrochloride,Paracetamol",
                            DateOfExpiry = new DateTime(2025, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfTabletsInStock = 500,
                            TargetAilment = "Gynaecology"
                        });
                });

            modelBuilder.Entity("PharmacyMedicineSupply.PharmacyMedicineSupply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MedicineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PharmacyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SupplyCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PharmacyMedicineSupply");
                });
#pragma warning restore 612, 618
        }
    }
}

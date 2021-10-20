﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharmacyMedicineSupply;

namespace PharmacyMedicineSupply.Migrations
{
    [DbContext(typeof(PharmacyMedicineSupplyContext))]
    partial class PharmacyMedicineSupplyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
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

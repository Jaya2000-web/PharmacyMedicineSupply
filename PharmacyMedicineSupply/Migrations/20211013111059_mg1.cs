﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacyMedicineSupply.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicineDemand",
                table: "MedicineDemand");

            migrationBuilder.AlterColumn<string>(
                name: "Medicine",
                table: "MedicineDemand",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "MedicineDemand",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicineDemand",
                table: "MedicineDemand",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicineDemand",
                table: "MedicineDemand");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MedicineDemand");

            migrationBuilder.AlterColumn<string>(
                name: "Medicine",
                table: "MedicineDemand",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicineDemand",
                table: "MedicineDemand",
                column: "Medicine");
        }
    }
}

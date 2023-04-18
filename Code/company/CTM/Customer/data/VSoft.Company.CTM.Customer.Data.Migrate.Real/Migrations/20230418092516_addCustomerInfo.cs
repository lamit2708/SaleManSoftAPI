using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VSoft.Company.CTM.Customer.Data.Migrate.Real.Migrations
{
    /// <inheritdoc />
    public partial class addCustomerInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<DateTime>(
            //    name: "BirthDate",
            //    table: "Customer",
            //    type: "datetime",
            //    nullable: true,
            //    defaultValueSql: "NULL");

            migrationBuilder.AddColumn<int>(
                name: "CustomerSourceId",
                table: "Customer",
                type: "int(11)",
                nullable: true,
                defaultValueSql: "NULL");

            migrationBuilder.AddColumn<string>(
                name: "Hobby",
                table: "Customer",
                type: "varchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValueSql: "NULL");

            migrationBuilder.AddColumn<bool>(
                name: "IsMarrage",
                table: "Customer",
                type: "tinyint(1)",
                nullable: true,
                defaultValueSql: "NULL");

            migrationBuilder.AddColumn<string>(
                name: "Job",
                table: "Customer",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                defaultValueSql: "NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "BirthDate",
            //    table: "Customer");

            migrationBuilder.DropColumn(
                name: "CustomerSourceId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Hobby",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "IsMarrage",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Job",
                table: "Customer");
        }
    }
}

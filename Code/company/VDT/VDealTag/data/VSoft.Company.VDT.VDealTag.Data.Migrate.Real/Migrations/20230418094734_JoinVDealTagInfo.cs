using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VSoft.Company.VDT.VDealTag.Data.Migrate.Real.Migrations
{
    /// <inheritdoc />
    public partial class JoinVDealTagInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "VDealTag",
                type: "datetime",
                nullable: true,
                defaultValueSql: "NULL");

            migrationBuilder.AddColumn<int>(
                name: "VDealTagSourceId",
                table: "VDealTag",
                type: "int(11)",
                nullable: true,
                defaultValueSql: "NULL");

            migrationBuilder.AddColumn<string>(
                name: "Hobby",
                table: "VDealTag",
                type: "varchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValueSql: "NULL");

            migrationBuilder.AddColumn<bool>(
                name: "IsMarrage",
                table: "VDealTag",
                type: "tinyint(1)",
                nullable: true,
                defaultValueSql: "NULL");

            migrationBuilder.AddColumn<string>(
                name: "Job",
                table: "VDealTag",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                defaultValueSql: "NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "VDealTag");

            migrationBuilder.DropColumn(
                name: "VDealTagSourceId",
                table: "VDealTag");

            migrationBuilder.DropColumn(
                name: "Hobby",
                table: "VDealTag");

            migrationBuilder.DropColumn(
                name: "IsMarrage",
                table: "VDealTag");

            migrationBuilder.DropColumn(
                name: "Job",
                table: "VDealTag");
        }
    }
}

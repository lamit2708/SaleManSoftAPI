using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace VSoft.Company.CTM.Customer.Data.Migrate.Real.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, defaultValueSql: "NULL"),
                    Gender = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "NULL", comment: "True: Male, False: Female"),
                    PriorityId = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    IsBought = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Keyword = table.Column<string>(type: "varchar(512)", nullable: true),
                    CustomerSourceId = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    Hobby = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true, defaultValueSql: "NULL"),
                    Job = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, defaultValueSql: "NULL"),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "NULL"),
                    IsMarrage = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            migrationBuilder.CreateIndex(
                name: "FK_CustomerSource_TO_CustomerInfo",
                table: "Customer",
                column: "CustomerSourceId");

            migrationBuilder.CreateIndex(
                name: "FK_Priority_TO_Customer",
                table: "Customer",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "UQ_Phone",
                table: "Customer",
                column: "Phone",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}

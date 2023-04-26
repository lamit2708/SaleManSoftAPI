using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace VSoft.Company.ORD.Order.Data.Migrate.Real.Migrations
{
    /// <inheritdoc />
    public partial class InitOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<long>(type: "bigint(20)", nullable: false),
                    UserId = table.Column<int>(type: "int(11)", nullable: false),
                    DealId = table.Column<long>(type: "bigint(20)", nullable: true, defaultValueSql: "NULL"),
                    IsDraft = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValueSql: "1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "NULL"),
                    EditedUserId = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            migrationBuilder.CreateIndex(
                name: "FK_Customer_TO_Order",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "FK_User_TO_Order",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "FK_User_TO_Order1",
                table: "Order",
                column: "EditedUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}

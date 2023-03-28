using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VSoft.Company.CSO.CustomerSource.Data.Migrate.Test.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerSource",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true, defaultValueSql: "'NULL'"),
                    Gender = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "'NULL'", comment: "True: Male, False: Female"),
                    PriorityId = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    CustomerSourceInfoId = table.Column<long>(type: "bigint(20)", nullable: true, defaultValueSql: "'NULL'"),
                    IsBought = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "FK_CustomerSourceInfo_TO_CustomerSource",
                table: "CustomerSource",
                column: "CustomerSourceInfoId");

            migrationBuilder.CreateIndex(
                name: "FK_Priority_TO_CustomerSource",
                table: "CustomerSource",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "UQ_Phone",
                table: "CustomerSource",
                column: "Phone",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerSource");
        }
    }
}

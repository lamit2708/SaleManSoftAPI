using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VSoft.Company.CTM.Customer.Data.Migrate.Real.Migrations
{
    /// <inheritdoc />
    public partial class addcustomerkeywordcolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Keyword",
                table: "Customer",
                type: "varchar(512)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Keyword",
                table: "Customer");
        }
    }
}

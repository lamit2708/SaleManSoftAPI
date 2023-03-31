using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VSoft.Company.PRO.Product.Data.Migrate.Real.Migrations
{
    /// <inheritdoc />
    public partial class changeQuantitycolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Product",
                newName: "Quantity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Product",
                newName: "Quantity");
        }
    }
}

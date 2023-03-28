using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VSoft.Company.PRO.Product.Data.Migrate.Real.Migrations
{
    /// <inheritdoc />
    public partial class addKeywordProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Keyword",
                table: "Product",
                type: "varchar(512)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Keyword",
                table: "Product");
        }
    }
}

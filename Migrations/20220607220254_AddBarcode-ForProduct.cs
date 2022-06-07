using Microsoft.EntityFrameworkCore.Migrations;

namespace FrameworkEntity.CodeFirst.Migrations
{
    public partial class AddBarcodeForProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Barcod",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Barcod",
                table: "Products");
        }
    }
}

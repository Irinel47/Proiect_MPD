using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_MPD.Migrations
{
    public partial class DiscountUntill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DiscountedUntill",
                table: "Product",
                newName: "DiscountUntill");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DiscountUntill",
                table: "Product",
                newName: "DiscountedUntill");
        }
    }
}

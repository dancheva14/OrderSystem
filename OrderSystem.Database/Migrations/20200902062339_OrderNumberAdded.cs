using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderSystem.Database.Migrations
{
    public partial class OrderNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_BrandDetails_BrandDetailId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Categories_CategoryId",
                table: "Parts");

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_BrandDetails_BrandDetailId",
                table: "Parts",
                column: "BrandDetailId",
                principalTable: "BrandDetails",
                principalColumn: "BrandDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Categories_CategoryId",
                table: "Parts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_BrandDetails_BrandDetailId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Categories_CategoryId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Orders");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_BrandDetails_BrandDetailId",
                table: "Parts",
                column: "BrandDetailId",
                principalTable: "BrandDetails",
                principalColumn: "BrandDetailId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Categories_CategoryId",
                table: "Parts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

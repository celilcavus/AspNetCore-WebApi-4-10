using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi_ETicaret_4_10.Models.Migrations
{
    /// <inheritdoc />
    public partial class ProductEntitesNameUpdated1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prooducts_Categories_CategoryId",
                table: "Prooducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prooducts",
                table: "Prooducts");

            migrationBuilder.RenameTable(
                name: "Prooducts",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Prooducts_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Prooducts");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Prooducts",
                newName: "IX_Prooducts_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prooducts",
                table: "Prooducts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prooducts_Categories_CategoryId",
                table: "Prooducts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

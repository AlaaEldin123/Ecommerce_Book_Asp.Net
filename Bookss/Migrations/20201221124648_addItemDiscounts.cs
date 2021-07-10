using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookss.Migrations
{
    public partial class addItemDiscounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbItemDiscount",
                columns: table => new
                {
                    ItemDiscountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbItemDiscount", x => x.ItemDiscountId);
                    table.ForeignKey(
                        name: "FK_TbItemDiscounts_TbItems",
                        column: x => x.ItemId,
                        principalTable: "TbItems",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbItems_CategoryId",
                table: "TbItems",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TbItemDiscount_ItemId",
                table: "TbItemDiscount",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbItems_TbCategories_CategoryId",
                table: "TbItems",
                column: "CategoryId",
                principalTable: "TbCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbItems_TbCategories_CategoryId",
                table: "TbItems");

            migrationBuilder.DropTable(
                name: "TbItemDiscount");

            migrationBuilder.DropIndex(
                name: "IX_TbItems_CategoryId",
                table: "TbItems");
        }
    }
}

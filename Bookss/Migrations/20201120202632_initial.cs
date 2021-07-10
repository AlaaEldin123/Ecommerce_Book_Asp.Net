using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookss.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCategories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "TbCustomers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCustomers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "TbItems",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SalesPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbItems", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "TbSlider",
                columns: table => new
                {
                    SliderId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Descraption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbSlider", x => x.SliderId);
                });

            migrationBuilder.CreateTable(
                name: "TbSuppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbSupplier", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "TbBusinessInfo",
                columns: table => new
                {
                    BusinessInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessCardNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OfficePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budget = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CutomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbBusinessInfo", x => x.BusinessInfoId);
                    table.ForeignKey(
                        name: "FK_TbBusinessInfo_TbCustomers_CutomerId",
                        column: x => x.CutomerId,
                        principalTable: "TbCustomers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbSalesInvoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DelivryDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    DelivryManId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbSalesInvoices", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_TbSalesInvoices_TbCustomers",
                        column: x => x.CustomerId,
                        principalTable: "TbCustomers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TbCustomerItems",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCustomerItems", x => new { x.ItemId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_TbCustomerItems_TbCustomers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "TbCustomers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbCustomerItems_TbItems_ItemId",
                        column: x => x.ItemId,
                        principalTable: "TbItems",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbItemImages",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbItemImages", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_TbItemImages_TbItems",
                        column: x => x.ItemId,
                        principalTable: "TbItems",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TbPurchaseInvoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbPurchaseInvoices", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_TbPurchaseInvoices_TbSuppliers",
                        column: x => x.SupplierId,
                        principalTable: "TbSuppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TbSalesInvoiceItems",
                columns: table => new
                {
                    InvoiceItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    InvoicePrice = table.Column<decimal>(type: "decimal(8,4)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbSalesInvoiceItems", x => x.InvoiceItemId);
                    table.ForeignKey(
                        name: "FK_TbSalesInvoiceItems_TbItems",
                        column: x => x.ItemId,
                        principalTable: "TbItems",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbSalesInvoiceItems_TbSalesInvoices",
                        column: x => x.InvoiceId,
                        principalTable: "TbSalesInvoices",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TbPurchaseInvoiceItems",
                columns: table => new
                {
                    InvoiceItemId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    InvoicePrice = table.Column<decimal>(type: "decimal(8,4)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbPurchaseInvoiceItems", x => x.InvoiceItemId);
                    table.ForeignKey(
                        name: "FK_TbPurchaseInvoiceItems_TbItems",
                        column: x => x.ItemId,
                        principalTable: "TbItems",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbPurchaseInvoiceItems_TbPurchaseInvoices",
                        column: x => x.InvoiceId,
                        principalTable: "TbPurchaseInvoices",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbBusinessInfo_CutomerId",
                table: "TbBusinessInfo",
                column: "CutomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TbCustomerItems_CustomerId",
                table: "TbCustomerItems",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TbItemImages_ItemId",
                table: "TbItemImages",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TbPurchaseInvoiceItems_InvoiceId",
                table: "TbPurchaseInvoiceItems",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_TbPurchaseInvoiceItems_ItemId",
                table: "TbPurchaseInvoiceItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TbPurchaseInvoices_SupplierId",
                table: "TbPurchaseInvoices",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_TbSalesInvoiceItems_InvoiceId",
                table: "TbSalesInvoiceItems",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_TbSalesInvoiceItems_ItemId",
                table: "TbSalesInvoiceItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TbSalesInvoices_CustomerId",
                table: "TbSalesInvoices",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbBusinessInfo");

            migrationBuilder.DropTable(
                name: "TbCategories");

            migrationBuilder.DropTable(
                name: "TbCustomerItems");

            migrationBuilder.DropTable(
                name: "TbItemImages");

            migrationBuilder.DropTable(
                name: "TbPurchaseInvoiceItems");

            migrationBuilder.DropTable(
                name: "TbSalesInvoiceItems");

            migrationBuilder.DropTable(
                name: "TbSlider");

            migrationBuilder.DropTable(
                name: "TbPurchaseInvoices");

            migrationBuilder.DropTable(
                name: "TbItems");

            migrationBuilder.DropTable(
                name: "TbSalesInvoices");

            migrationBuilder.DropTable(
                name: "TbSuppliers");

            migrationBuilder.DropTable(
                name: "TbCustomers");
        }
    }
}

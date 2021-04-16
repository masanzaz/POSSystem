using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace POSSystem.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "categories",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedByUser = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 102),
                    CreatedIp = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 103),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getUTCDate())")
                        .Annotation("ColumnOrder", 104),
                    ModifiedByUser = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 105),
                    ModifiedIp = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 106),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getUTCDate())")
                        .Annotation("ColumnOrder", 107),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Description = table.Column<string>(type: "varchar(300)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedByUser = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 102),
                    CreatedIp = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 103),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getUTCDate())")
                        .Annotation("ColumnOrder", 104),
                    ModifiedByUser = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 105),
                    ModifiedIp = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 106),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getUTCDate())")
                        .Annotation("ColumnOrder", 107),
                    Identification = table.Column<string>(type: "varchar(20)", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(100)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(100)", nullable: true),
                    Address = table.Column<string>(type: "varchar(200)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "payment_method",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedByUser = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 102),
                    CreatedIp = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 103),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getUTCDate())")
                        .Annotation("ColumnOrder", 104),
                    ModifiedByUser = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 105),
                    ModifiedIp = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 106),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getUTCDate())")
                        .Annotation("ColumnOrder", 107),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment_method", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedByUser = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 102),
                    CreatedIp = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 103),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getUTCDate())")
                        .Annotation("ColumnOrder", 104),
                    ModifiedByUser = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 105),
                    ModifiedIp = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 106),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getUTCDate())")
                        .Annotation("ColumnOrder", 107),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Description = table.Column<string>(type: "varchar(300)", nullable: true),
                    BarCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    InStock = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "dbo",
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedByUser = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 102),
                    CreatedIp = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 103),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getUTCDate())")
                        .Annotation("ColumnOrder", 104),
                    ModifiedByUser = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 105),
                    ModifiedIp = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 106),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getUTCDate())")
                        .Annotation("ColumnOrder", 107),
                    CustomerId = table.Column<Guid>(nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Codigo = table.Column<string>(type: "varchar(10)", nullable: false),
                    PaymentId = table.Column<Guid>(nullable: false),
                    Observation = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orders_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orders_payment_method_PaymentId",
                        column: x => x.PaymentId,
                        principalSchema: "dbo",
                        principalTable: "payment_method",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "orders_detail",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                        .Annotation("ColumnOrder", 101),
                    CreatedByUser = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 102),
                    CreatedIp = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 103),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getUTCDate())")
                        .Annotation("ColumnOrder", 104),
                    ModifiedByUser = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 105),
                    ModifiedIp = table.Column<string>(type: "nvarchar(100)", nullable: false, defaultValueSql: "(CURRENT_USER)")
                        .Annotation("ColumnOrder", 106),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getUTCDate())")
                        .Annotation("ColumnOrder", 107),
                    OrderId = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(9,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders_detail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orders_detail_orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "dbo",
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orders_detail_products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "dbo",
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_orders_CustomerId",
                schema: "dbo",
                table: "orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_PaymentId",
                schema: "dbo",
                table: "orders",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_detail_OrderId",
                schema: "dbo",
                table: "orders_detail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_detail_ProductId",
                schema: "dbo",
                table: "orders_detail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoryId",
                schema: "dbo",
                table: "products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders_detail",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "orders",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "products",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "customers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "payment_method",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "categories",
                schema: "dbo");
        }
    }
}

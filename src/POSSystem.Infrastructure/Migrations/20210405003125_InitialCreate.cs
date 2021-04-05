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
                name: "Categories",
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
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
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
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "dbo",
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                schema: "dbo",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "dbo");
        }
    }
}

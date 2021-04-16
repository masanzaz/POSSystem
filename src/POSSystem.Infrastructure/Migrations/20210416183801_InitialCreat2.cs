using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace POSSystem.Infrastructure.Migrations
{
    public partial class InitialCreat2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModifiedIp",
                schema: "dbo",
                table: "products",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldDefaultValueSql: "(CURRENT_USER)")
                .Annotation("ColumnOrder", 106)
                .OldAnnotation("ColumnOrder", 106);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                schema: "dbo",
                table: "products",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getUTCDate())")
                .Annotation("ColumnOrder", 107)
                .OldAnnotation("ColumnOrder", 107);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByUser",
                schema: "dbo",
                table: "products",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldDefaultValueSql: "(CURRENT_USER)")
                .Annotation("ColumnOrder", 105)
                .OldAnnotation("ColumnOrder", 105);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedIp",
                schema: "dbo",
                table: "payment_method",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldDefaultValueSql: "(CURRENT_USER)")
                .Annotation("ColumnOrder", 106)
                .OldAnnotation("ColumnOrder", 106);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                schema: "dbo",
                table: "payment_method",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getUTCDate())")
                .Annotation("ColumnOrder", 107)
                .OldAnnotation("ColumnOrder", 107);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByUser",
                schema: "dbo",
                table: "payment_method",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldDefaultValueSql: "(CURRENT_USER)")
                .Annotation("ColumnOrder", 105)
                .OldAnnotation("ColumnOrder", 105);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedIp",
                schema: "dbo",
                table: "orders_detail",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldDefaultValueSql: "(CURRENT_USER)")
                .Annotation("ColumnOrder", 106)
                .OldAnnotation("ColumnOrder", 106);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                schema: "dbo",
                table: "orders_detail",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getUTCDate())")
                .Annotation("ColumnOrder", 107)
                .OldAnnotation("ColumnOrder", 107);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByUser",
                schema: "dbo",
                table: "orders_detail",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldDefaultValueSql: "(CURRENT_USER)")
                .Annotation("ColumnOrder", 105)
                .OldAnnotation("ColumnOrder", 105);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedIp",
                schema: "dbo",
                table: "orders",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldDefaultValueSql: "(CURRENT_USER)")
                .Annotation("ColumnOrder", 106)
                .OldAnnotation("ColumnOrder", 106);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                schema: "dbo",
                table: "orders",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getUTCDate())")
                .Annotation("ColumnOrder", 107)
                .OldAnnotation("ColumnOrder", 107);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByUser",
                schema: "dbo",
                table: "orders",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldDefaultValueSql: "(CURRENT_USER)")
                .Annotation("ColumnOrder", 105)
                .OldAnnotation("ColumnOrder", 105);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedIp",
                schema: "dbo",
                table: "customers",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldDefaultValueSql: "(CURRENT_USER)")
                .Annotation("ColumnOrder", 106)
                .OldAnnotation("ColumnOrder", 106);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                schema: "dbo",
                table: "customers",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getUTCDate())")
                .Annotation("ColumnOrder", 107)
                .OldAnnotation("ColumnOrder", 107);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByUser",
                schema: "dbo",
                table: "customers",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldDefaultValueSql: "(CURRENT_USER)")
                .Annotation("ColumnOrder", 105)
                .OldAnnotation("ColumnOrder", 105);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedIp",
                schema: "dbo",
                table: "categories",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldDefaultValueSql: "(CURRENT_USER)")
                .Annotation("ColumnOrder", 106)
                .OldAnnotation("ColumnOrder", 106);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                schema: "dbo",
                table: "categories",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getUTCDate())")
                .Annotation("ColumnOrder", 107)
                .OldAnnotation("ColumnOrder", 107);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByUser",
                schema: "dbo",
                table: "categories",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldDefaultValueSql: "(CURRENT_USER)")
                .Annotation("ColumnOrder", 105)
                .OldAnnotation("ColumnOrder", 105);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModifiedIp",
                schema: "dbo",
                table: "products",
                type: "nvarchar(100)",
                nullable: false,
                defaultValueSql: "(CURRENT_USER)",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true)
                .Annotation("ColumnOrder", 106)
                .OldAnnotation("ColumnOrder", 106);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                schema: "dbo",
                table: "products",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getUTCDate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("ColumnOrder", 107)
                .OldAnnotation("ColumnOrder", 107);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByUser",
                schema: "dbo",
                table: "products",
                type: "nvarchar(100)",
                nullable: false,
                defaultValueSql: "(CURRENT_USER)",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true)
                .Annotation("ColumnOrder", 105)
                .OldAnnotation("ColumnOrder", 105);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedIp",
                schema: "dbo",
                table: "payment_method",
                type: "nvarchar(100)",
                nullable: false,
                defaultValueSql: "(CURRENT_USER)",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true)
                .Annotation("ColumnOrder", 106)
                .OldAnnotation("ColumnOrder", 106);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                schema: "dbo",
                table: "payment_method",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getUTCDate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("ColumnOrder", 107)
                .OldAnnotation("ColumnOrder", 107);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByUser",
                schema: "dbo",
                table: "payment_method",
                type: "nvarchar(100)",
                nullable: false,
                defaultValueSql: "(CURRENT_USER)",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true)
                .Annotation("ColumnOrder", 105)
                .OldAnnotation("ColumnOrder", 105);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedIp",
                schema: "dbo",
                table: "orders_detail",
                type: "nvarchar(100)",
                nullable: false,
                defaultValueSql: "(CURRENT_USER)",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true)
                .Annotation("ColumnOrder", 106)
                .OldAnnotation("ColumnOrder", 106);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                schema: "dbo",
                table: "orders_detail",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getUTCDate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("ColumnOrder", 107)
                .OldAnnotation("ColumnOrder", 107);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByUser",
                schema: "dbo",
                table: "orders_detail",
                type: "nvarchar(100)",
                nullable: false,
                defaultValueSql: "(CURRENT_USER)",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true)
                .Annotation("ColumnOrder", 105)
                .OldAnnotation("ColumnOrder", 105);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedIp",
                schema: "dbo",
                table: "orders",
                type: "nvarchar(100)",
                nullable: false,
                defaultValueSql: "(CURRENT_USER)",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true)
                .Annotation("ColumnOrder", 106)
                .OldAnnotation("ColumnOrder", 106);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                schema: "dbo",
                table: "orders",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getUTCDate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("ColumnOrder", 107)
                .OldAnnotation("ColumnOrder", 107);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByUser",
                schema: "dbo",
                table: "orders",
                type: "nvarchar(100)",
                nullable: false,
                defaultValueSql: "(CURRENT_USER)",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true)
                .Annotation("ColumnOrder", 105)
                .OldAnnotation("ColumnOrder", 105);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedIp",
                schema: "dbo",
                table: "customers",
                type: "nvarchar(100)",
                nullable: false,
                defaultValueSql: "(CURRENT_USER)",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true)
                .Annotation("ColumnOrder", 106)
                .OldAnnotation("ColumnOrder", 106);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                schema: "dbo",
                table: "customers",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getUTCDate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("ColumnOrder", 107)
                .OldAnnotation("ColumnOrder", 107);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByUser",
                schema: "dbo",
                table: "customers",
                type: "nvarchar(100)",
                nullable: false,
                defaultValueSql: "(CURRENT_USER)",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true)
                .Annotation("ColumnOrder", 105)
                .OldAnnotation("ColumnOrder", 105);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedIp",
                schema: "dbo",
                table: "categories",
                type: "nvarchar(100)",
                nullable: false,
                defaultValueSql: "(CURRENT_USER)",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true)
                .Annotation("ColumnOrder", 106)
                .OldAnnotation("ColumnOrder", 106);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                schema: "dbo",
                table: "categories",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getUTCDate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("ColumnOrder", 107)
                .OldAnnotation("ColumnOrder", 107);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByUser",
                schema: "dbo",
                table: "categories",
                type: "nvarchar(100)",
                nullable: false,
                defaultValueSql: "(CURRENT_USER)",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true)
                .Annotation("ColumnOrder", 105)
                .OldAnnotation("ColumnOrder", 105);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiamonShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserAddressAndEditRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 27, 47, 707, DateTimeKind.Local).AddTicks(17), new DateTime(2024, 5, 30, 21, 27, 47, 707, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 27, 47, 707, DateTimeKind.Local).AddTicks(184), new DateTime(2024, 5, 30, 21, 27, 47, 707, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 27, 47, 707, DateTimeKind.Local).AddTicks(182), new DateTime(2024, 5, 30, 21, 27, 47, 707, DateTimeKind.Local).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 27, 47, 707, DateTimeKind.Local).AddTicks(179), new DateTime(2024, 5, 30, 21, 27, 47, 707, DateTimeKind.Local).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 27, 47, 707, DateTimeKind.Local).AddTicks(103), new DateTime(2024, 5, 30, 21, 27, 47, 707, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 27, 47, 707, DateTimeKind.Local).AddTicks(100), new DateTime(2024, 5, 30, 21, 27, 47, 707, DateTimeKind.Local).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 27, 47, 707, DateTimeKind.Local).AddTicks(97), new DateTime(2024, 5, 30, 21, 27, 47, 707, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1401744d-0421-41eb-b9d6-f888aaccca91"),
                columns: new[] { "DisplayName", "NormalizedName" },
                values: new object[] { "Nhân Viên Bán Hàng", "SALESTAFF" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2244), new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2419), new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2416), new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2413), new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2339), new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2336), new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2333), new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1401744d-0421-41eb-b9d6-f888aaccca91"),
                columns: new[] { "DisplayName", "NormalizedName" },
                values: new object[] { "Nhân Viên Giao Hàng", "DELIVERYSTAFF" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiamonShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "FullName");

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4653), new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4838), new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4835), new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4832), new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4751), new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4749), new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4745), new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4746) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Users",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9059), new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9449), new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9446), new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9443), new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9167), new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9163), new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9164) });
        }
    }
}

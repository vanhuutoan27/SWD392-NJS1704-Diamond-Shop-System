using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiamonShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDiscountField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("0e211217-5f97-46d1-b108-4e8bf850b9f6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("19711010-6a80-4aa2-a4c2-564c50c1c6a3"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("20af988c-87c5-4f2b-99f0-e246de7f1fc1"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("293f7261-d8da-48ca-90ce-28cddbda597b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2a69f23c-5efc-43da-b699-9cf948fd9555"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2f3a6f3c-14ac-42af-bd27-36dc8c2c5819"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("382372bf-3bd8-4655-a6ee-03062bb0da76"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3a9eda08-d690-41c8-9edb-dacc54c5dfff"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3e44641a-4330-4d98-8c66-f566e6f5847b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3f29b385-6d57-4b72-ae0d-769e554d3d2d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("43be56ca-0f64-4ae3-80df-6592377205ef"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("47b728d8-97eb-4711-87e1-580a4c57891a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("48c3e983-a424-41a5-9fd2-775273afca0d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("50289d81-6141-4f56-b691-f88debf44aec"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("53754301-b09f-4848-a5bf-8e5b4b5094cd"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6cb03957-405b-4f56-b295-01e373f6087f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6e5f4b84-15cb-467d-b1c9-0ed6c66224f4"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("76aae8c6-e12f-4757-99ba-13a046f8d953"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("79d4a7fb-061e-4c23-8049-889ed249eb27"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("7c4bc23d-25fd-4f6b-b2e7-0cd8d9e529c8"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("80550f5f-0319-4616-b507-42d0184bbd7d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("8d70e40b-7f84-4fd1-8ed2-bc8e75647d71"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("8db48b93-cee9-4fe1-92c3-9b91793ba66b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("9b48bb04-ef4d-4d65-9bd9-097a039937ec"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("9d3ad0d6-1a0a-4ad5-87b9-0e6ddc9f7665"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("ab0f8b83-fb83-4091-8715-b2ed41bba716"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b37d827f-9e65-4c6a-90c8-bd04e0d60ec0"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c3e5f4d0-21b4-43c0-9cae-1fc6870f9df3"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c778cb0b-d5c7-4785-92a7-4bae4fb00f74"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d2d314a8-7353-4c9d-b90a-b63c0e9593d6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d3253453-3488-4eb2-8fa8-f2d721c0a90c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d47bbd27-a85d-4163-b224-91f0fd47a89a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e302add9-9dc4-4eab-ad3e-476113ea55b3"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e49908a5-f4b3-4cf2-b46c-31d04fb34419"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e6d97416-cad5-4473-adac-2e814c3f6d4b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e74b919a-be86-4e10-8152-b412bf27e686"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("ebd4f084-65bb-41d8-a136-513342c1ab67"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("fe8134a5-a6e4-49cf-9741-2d1090f5c419"));

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8716), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8712), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8710), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8694), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8714), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8995), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9025), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9031), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8992), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9003), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9020), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9000), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9028), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9018), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9011), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9023), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9008), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9006), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8988), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8997), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c20d846c-a73b-4356-8736-a51273667bee"),
                column: "DateCreated",
                value: new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "DateCreated", "DateModified", "Description", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("02853299-6803-4099-baf1-e06c4e97d0d6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_1.jpg?alt=media&token=42eda424-48f5-4586-a7e6-fda26c5659be" },
                    { new Guid("039b811c-5c8e-4d92-a81f-14540ae2e4f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m1.jpg?alt=media&token=ce8862c1-380a-479e-a0e9-58634fa2d68a" },
                    { new Guid("06e171c7-a6ca-433b-bb10-79c422b43bf9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("0b243c7c-3694-4f72-a210-820198d069eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_1.jpg?alt=media&token=c8ef04f8-2a5e-4b64-a10e-b3693616f8a3" },
                    { new Guid("0bfef9c3-c8aa-43ee-9486-2fe4c4cf2066"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m1.jpg?alt=media&token=5b52cbae-c5fd-4d97-8af8-5f2d5fb6df1b" },
                    { new Guid("1a84abea-a4fb-41b8-a849-5f8a42af181b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m1.jpg?alt=media&token=3788a61b-0bb2-40cd-a27f-da6d6c078939" },
                    { new Guid("23154a97-f02d-4eb8-860f-893dafe54e12"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("317025c6-976b-43db-bab6-efea60bd6407"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("34ebe402-e539-48ff-ab97-10e756e74635"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("36d279d2-3905-4737-b3a6-77a869ea3a91"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m1.jpg?alt=media&token=1c3dcb9b-9ba2-49e4-a39b-c6c7fa428bc6" },
                    { new Guid("36daf5e0-d15c-47dc-9bec-b1a855871ddc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f376d66d-cf4a-4103-836f-43811290f18c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("41cb6e0e-15b8-45a9-acae-2fb8e747f2a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_4.jpg?alt=media&token=f0761d38-c205-48d8-89fd-84039af48ddf" },
                    { new Guid("4be0b262-0e18-4363-9179-1bc3c0505ad6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_3.jpg?alt=media&token=801a85ce-434c-4eee-9652-3672d8bb4482" },
                    { new Guid("4e026cb8-5d2b-408d-88e3-044f5c519f5a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("4fc20334-bce7-4772-adb7-80a566ad3777"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_4.jpg?alt=media&token=164f4d10-12f3-442c-81d2-eed699c79bd5" },
                    { new Guid("56e66ec0-477f-4159-b22e-50b7e38ad223"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m1.jpg?alt=media&token=2144ca96-674c-454e-b5c4-9141e98af6d7" },
                    { new Guid("6bf2b3bd-cb94-4596-a660-0b529d01ad23"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b9948c96-e456-471d-b523-159b7cf3242c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("6d6721ef-474b-4b7b-851e-9cae7c8e104f"), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9285), null, null, new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_2.jpg?alt=media&token=7a80ce7c-4073-46f7-a1e9-aa9d2196bdd6" },
                    { new Guid("6dcd6861-f02b-44b7-8085-1a7d1e0dc682"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("6de252e0-6e46-4b92-a4b7-42fde671397f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m2.jpg?alt=media&token=33c0ae2b-4f6d-4864-879d-a1c08be6d412" },
                    { new Guid("71ab61d3-28c0-4cf8-b316-d7c0e3711777"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m2.jpg?alt=media&token=001430c6-ef62-4db7-96cf-678ebcd6dea5" },
                    { new Guid("7aedf27f-9ae2-43f2-9640-d66ba19d927f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_1.jpg?alt=media&token=e313cc02-5436-487a-9a3b-71f4985fb733" },
                    { new Guid("7bdbf664-be83-441f-89df-1119e6656b4b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("83a797e1-c3d5-47c1-84fa-0247450f5bd4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("99f8910e-a982-44ca-be37-12101190400b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("a2a80dc6-dcd8-4e77-ac07-1f4d8a4c8a78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m1.jpg?alt=media&token=ec5d2b70-753a-4485-a892-60c5c0938615" },
                    { new Guid("b013a167-b587-4699-bc34-64529ceb08b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m2.jpg?alt=media&token=c7c568ef-cd9b-4889-9fc2-96e478177e97" },
                    { new Guid("b59f0a9f-dc09-4a0a-b32f-bd8ecbc280dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_2.jpg?alt=media&token=42dc5653-5240-4df1-9b39-c4d1975defd7" },
                    { new Guid("b73f2c51-268c-4d31-9965-a810e3395cd5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_3.jpg?alt=media&token=fc95d920-491f-4c8d-a50a-681673bb929d" },
                    { new Guid("c2104673-4796-4b7e-8aa9-80d6e2a07ea7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m2.jpg?alt=media&token=7f01ab19-e4e8-42ea-8278-2ce5b7e50872" },
                    { new Guid("c79f8535-57a0-4eb2-bb79-a0d95f80f14e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m2.jpg?alt=media&token=235c27dd-1417-46da-82ee-af820e415790" },
                    { new Guid("cd3fc107-bccb-43af-9752-c956974d7a1f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("dd22ebe1-7317-4871-aa5a-ac1ae3e0f034"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("e6c567c9-573b-4e36-b7d9-86a96b944c29"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("005da949-dd83-438b-9ee9-aea012d87068"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("ebcb7682-8f8f-47a9-8235-c79f119311f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("ed7bcf1e-1f94-4d2b-8a19-1a3647320e3f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("f2fffef7-c4b4-470e-ac6b-9c3f3110ce33"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("f3001a4a-827e-4b56-8c4b-d3d06813e1fb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m2.jpg?alt=media&token=f5167a68-4c7a-46cf-ad28-e352ab8481e5" }
                });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9150), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9156), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9144), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9136), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9158), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9139), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9153), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9126), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9133), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9147), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9130), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9142), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8832), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8884), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8889), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8856), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8878), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8862), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8829), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8871), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8839), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8891), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8873), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8886), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8851), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8836), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8858), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8849), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8864), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8846), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8869), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8854), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8882), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8866), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8844), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8842), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8826), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8876), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8834), new DateTime(2024, 7, 14, 15, 54, 32, 686, DateTimeKind.Local).AddTicks(8834) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("02853299-6803-4099-baf1-e06c4e97d0d6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("039b811c-5c8e-4d92-a81f-14540ae2e4f6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("06e171c7-a6ca-433b-bb10-79c422b43bf9"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("0b243c7c-3694-4f72-a210-820198d069eb"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("0bfef9c3-c8aa-43ee-9486-2fe4c4cf2066"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1a84abea-a4fb-41b8-a849-5f8a42af181b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("23154a97-f02d-4eb8-860f-893dafe54e12"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("317025c6-976b-43db-bab6-efea60bd6407"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("34ebe402-e539-48ff-ab97-10e756e74635"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("36d279d2-3905-4737-b3a6-77a869ea3a91"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("36daf5e0-d15c-47dc-9bec-b1a855871ddc"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("41cb6e0e-15b8-45a9-acae-2fb8e747f2a2"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4be0b262-0e18-4363-9179-1bc3c0505ad6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4e026cb8-5d2b-408d-88e3-044f5c519f5a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4fc20334-bce7-4772-adb7-80a566ad3777"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("56e66ec0-477f-4159-b22e-50b7e38ad223"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6bf2b3bd-cb94-4596-a660-0b529d01ad23"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6d6721ef-474b-4b7b-851e-9cae7c8e104f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6dcd6861-f02b-44b7-8085-1a7d1e0dc682"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6de252e0-6e46-4b92-a4b7-42fde671397f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("71ab61d3-28c0-4cf8-b316-d7c0e3711777"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("7aedf27f-9ae2-43f2-9640-d66ba19d927f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("7bdbf664-be83-441f-89df-1119e6656b4b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("83a797e1-c3d5-47c1-84fa-0247450f5bd4"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("99f8910e-a982-44ca-be37-12101190400b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a2a80dc6-dcd8-4e77-ac07-1f4d8a4c8a78"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b013a167-b587-4699-bc34-64529ceb08b3"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b59f0a9f-dc09-4a0a-b32f-bd8ecbc280dc"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b73f2c51-268c-4d31-9965-a810e3395cd5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c2104673-4796-4b7e-8aa9-80d6e2a07ea7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c79f8535-57a0-4eb2-bb79-a0d95f80f14e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("cd3fc107-bccb-43af-9752-c956974d7a1f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("dd22ebe1-7317-4871-aa5a-ac1ae3e0f034"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e6c567c9-573b-4e36-b7d9-86a96b944c29"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("ebcb7682-8f8f-47a9-8235-c79f119311f2"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("ed7bcf1e-1f94-4d2b-8a19-1a3647320e3f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("f2fffef7-c4b4-470e-ac6b-9c3f3110ce33"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("f3001a4a-827e-4b56-8c4b-d3d06813e1fb"));

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8700), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8696), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8691), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8675), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8698), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8958), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8986), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8992), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8956), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8966), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8981), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8964), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8989), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8978), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8975), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8983), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8973), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8969), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8952), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8961), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c20d846c-a73b-4356-8736-a51273667bee"),
                column: "DateCreated",
                value: new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "DateCreated", "DateModified", "Description", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("0e211217-5f97-46d1-b108-4e8bf850b9f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("005da949-dd83-438b-9ee9-aea012d87068"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("19711010-6a80-4aa2-a4c2-564c50c1c6a3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("20af988c-87c5-4f2b-99f0-e246de7f1fc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m1.jpg?alt=media&token=2144ca96-674c-454e-b5c4-9141e98af6d7" },
                    { new Guid("293f7261-d8da-48ca-90ce-28cddbda597b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("2a69f23c-5efc-43da-b699-9cf948fd9555"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m1.jpg?alt=media&token=5b52cbae-c5fd-4d97-8af8-5f2d5fb6df1b" },
                    { new Guid("2f3a6f3c-14ac-42af-bd27-36dc8c2c5819"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m2.jpg?alt=media&token=c7c568ef-cd9b-4889-9fc2-96e478177e97" },
                    { new Guid("382372bf-3bd8-4655-a6ee-03062bb0da76"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m2.jpg?alt=media&token=7f01ab19-e4e8-42ea-8278-2ce5b7e50872" },
                    { new Guid("3a9eda08-d690-41c8-9edb-dacc54c5dfff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_1.jpg?alt=media&token=42eda424-48f5-4586-a7e6-fda26c5659be" },
                    { new Guid("3e44641a-4330-4d98-8c66-f566e6f5847b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m2.jpg?alt=media&token=33c0ae2b-4f6d-4864-879d-a1c08be6d412" },
                    { new Guid("3f29b385-6d57-4b72-ae0d-769e554d3d2d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_4.jpg?alt=media&token=164f4d10-12f3-442c-81d2-eed699c79bd5" },
                    { new Guid("43be56ca-0f64-4ae3-80df-6592377205ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_3.jpg?alt=media&token=fc95d920-491f-4c8d-a50a-681673bb929d" },
                    { new Guid("47b728d8-97eb-4711-87e1-580a4c57891a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_3.jpg?alt=media&token=801a85ce-434c-4eee-9652-3672d8bb4482" },
                    { new Guid("48c3e983-a424-41a5-9fd2-775273afca0d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("50289d81-6141-4f56-b691-f88debf44aec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("53754301-b09f-4848-a5bf-8e5b4b5094cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("6cb03957-405b-4f56-b295-01e373f6087f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_4.jpg?alt=media&token=f0761d38-c205-48d8-89fd-84039af48ddf" },
                    { new Guid("6e5f4b84-15cb-467d-b1c9-0ed6c66224f4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m1.jpg?alt=media&token=3788a61b-0bb2-40cd-a27f-da6d6c078939" },
                    { new Guid("76aae8c6-e12f-4757-99ba-13a046f8d953"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f376d66d-cf4a-4103-836f-43811290f18c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("79d4a7fb-061e-4c23-8049-889ed249eb27"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("7c4bc23d-25fd-4f6b-b2e7-0cd8d9e529c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("80550f5f-0319-4616-b507-42d0184bbd7d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("8d70e40b-7f84-4fd1-8ed2-bc8e75647d71"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m2.jpg?alt=media&token=001430c6-ef62-4db7-96cf-678ebcd6dea5" },
                    { new Guid("8db48b93-cee9-4fe1-92c3-9b91793ba66b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("9b48bb04-ef4d-4d65-9bd9-097a039937ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_1.jpg?alt=media&token=c8ef04f8-2a5e-4b64-a10e-b3693616f8a3" },
                    { new Guid("9d3ad0d6-1a0a-4ad5-87b9-0e6ddc9f7665"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("ab0f8b83-fb83-4091-8715-b2ed41bba716"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("b37d827f-9e65-4c6a-90c8-bd04e0d60ec0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m1.jpg?alt=media&token=ec5d2b70-753a-4485-a892-60c5c0938615" },
                    { new Guid("c3e5f4d0-21b4-43c0-9cae-1fc6870f9df3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_1.jpg?alt=media&token=e313cc02-5436-487a-9a3b-71f4985fb733" },
                    { new Guid("c778cb0b-d5c7-4785-92a7-4bae4fb00f74"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m2.jpg?alt=media&token=f5167a68-4c7a-46cf-ad28-e352ab8481e5" },
                    { new Guid("d2d314a8-7353-4c9d-b90a-b63c0e9593d6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("d3253453-3488-4eb2-8fa8-f2d721c0a90c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("d47bbd27-a85d-4163-b224-91f0fd47a89a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_2.jpg?alt=media&token=42dc5653-5240-4df1-9b39-c4d1975defd7" },
                    { new Guid("e302add9-9dc4-4eab-ad3e-476113ea55b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b9948c96-e456-471d-b523-159b7cf3242c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("e49908a5-f4b3-4cf2-b46c-31d04fb34419"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m1.jpg?alt=media&token=1c3dcb9b-9ba2-49e4-a39b-c6c7fa428bc6" },
                    { new Guid("e6d97416-cad5-4473-adac-2e814c3f6d4b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m2.jpg?alt=media&token=235c27dd-1417-46da-82ee-af820e415790" },
                    { new Guid("e74b919a-be86-4e10-8152-b412bf27e686"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("ebd4f084-65bb-41d8-a136-513342c1ab67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m1.jpg?alt=media&token=ce8862c1-380a-479e-a0e9-58634fa2d68a" },
                    { new Guid("fe8134a5-a6e4-49cf-9741-2d1090f5c419"), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9315), null, null, new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_2.jpg?alt=media&token=7a80ce7c-4073-46f7-a1e9-aa9d2196bdd6" }
                });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9184), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9189), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9178), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9192), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9173), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9186), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9160), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9166), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9181), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9164), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9176), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8788), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8846), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8852), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8814), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8841), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8819), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8785), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8834), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8796), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8854), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8836), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8848), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8808), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8792), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8816), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8806), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8821), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8804), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8831), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8811), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8843), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8823), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8801), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8799), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8782), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8839), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 7, 14, 15, 41, 29, 832, DateTimeKind.Local).AddTicks(8790) });
        }
    }
}

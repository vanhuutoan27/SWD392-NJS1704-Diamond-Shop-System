using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiamonShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddReciveDaycolumnForOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("01eed231-0cc0-44f2-b631-8b4e9653736d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("0316b718-ec25-4c02-9641-7931da533d1e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("03b819ec-54fa-49f4-bbf0-1950bb02ffea"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1085fa38-953f-4985-986b-5f5d939c0800"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1d7efae8-02bd-40ef-a233-bcdc3e5e5697"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("25211712-8432-4d90-aadd-30f004e33803"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2a16c3fa-77c9-4c1a-861b-0d0e22dc5e08"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("313965dd-0c89-48cc-b2c8-b5c47452332e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("35ce207a-42d0-4925-a2a9-b1c11d59aef9"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("36342e10-f5bd-4255-878e-9fbf54022965"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("47232d79-3661-43a4-81c3-6c6c0c7575fa"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4f46d147-b899-434d-abbb-e238c0b68261"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("60f49d0a-94f6-4a38-96ad-544d8714d990"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("64da840d-314f-44f7-99d6-09b4d3179036"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("66039dd0-dbb2-4abc-94b5-cef422a7c666"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6ce6546b-3ff8-4a6d-adbe-29fd32cc6db6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6d3c954f-d850-4b22-b9e0-6c677893ccb7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("70362f03-39c1-477d-83ce-2fc2b4c61e5e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("80dac77a-55ca-4218-ba3f-f547fc0d4d5a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("8d095dc0-04c5-48d6-a849-a4f663437f11"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("93605508-9eac-43f7-8b00-704573af8d62"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("98e7efa3-f868-487b-8f3d-0abceedad92d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a41d58ff-d897-40b0-898b-944a9d917304"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a7ee6d34-0bb4-4529-af34-a24cc5c2aec5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a8fa7909-ff6f-4a80-bae1-8cd4383711e6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("aa41898d-5d98-4640-a882-402c2875683f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b29d6f86-f991-4b59-9ac9-9591253b46df"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("ba53940e-3ce6-44ac-a6f7-9e3294fe892d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("bdffcf2e-4136-4bda-827e-ba94c5e397d6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("be947e02-40cb-481e-8ee8-be0762ff272d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c0b649de-7ea9-4dfd-8f73-f03ba81b6daa"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e1d4fe10-219b-4bed-9c2b-6d5f0db82c22"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e51c2ee5-f67f-4c9e-9cb1-88fe56e9a525"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("f08a0cee-79c5-4639-be34-5d8560ca064c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("f4a95b09-b185-4ae0-b3d9-b65a3d469184"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("f8cb0bf6-3240-497d-af62-50f7176ef636"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("fbbb6813-3246-4264-860b-96ecde4c9d39"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("ffe880e9-7af6-4582-807e-7e6de195b607"));

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8095), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8091), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8088), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8073), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8093), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8337), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8362), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8367), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8334), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8345), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8357), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8342), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8365), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8355), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8352), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8360), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8350), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8347), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8328), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8340), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c20d846c-a73b-4356-8736-a51273667bee"),
                column: "DateCreated",
                value: new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "DateCreated", "DateModified", "Description", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("0663503d-ff24-4a64-81e6-85d83c466073"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("073b0b1b-8903-4154-a8b9-4f26828394da"), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8578), null, null, new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_2.jpg?alt=media&token=7a80ce7c-4073-46f7-a1e9-aa9d2196bdd6" },
                    { new Guid("1b92d8fc-77b7-4864-a8fb-4ac1fd0f157f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_1.jpg?alt=media&token=e313cc02-5436-487a-9a3b-71f4985fb733" },
                    { new Guid("2341b751-93b6-43c3-8025-70ca3157a8c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m1.jpg?alt=media&token=2144ca96-674c-454e-b5c4-9141e98af6d7" },
                    { new Guid("302bd418-6297-4252-885b-cfc930b5cdb4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m1.jpg?alt=media&token=ec5d2b70-753a-4485-a892-60c5c0938615" },
                    { new Guid("3086e7d0-47c2-45f8-afd8-5528bf3844b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("3c706475-c113-4b0b-a0dd-d2757fcf0fdb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m2.jpg?alt=media&token=c7c568ef-cd9b-4889-9fc2-96e478177e97" },
                    { new Guid("3cfbd072-4af9-469d-aea0-ebe66ad10200"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_4.jpg?alt=media&token=f0761d38-c205-48d8-89fd-84039af48ddf" },
                    { new Guid("46700f31-fa9c-405d-87a6-1cf4c3f915ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m2.jpg?alt=media&token=33c0ae2b-4f6d-4864-879d-a1c08be6d412" },
                    { new Guid("469b4a98-2b40-4df5-bdf2-91c243b8fddd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m1.jpg?alt=media&token=ce8862c1-380a-479e-a0e9-58634fa2d68a" },
                    { new Guid("4a5c5f56-31cf-48ff-adca-2aec86efdde3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("4c9056e7-998e-4f11-bc55-e892ede406b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_2.jpg?alt=media&token=42dc5653-5240-4df1-9b39-c4d1975defd7" },
                    { new Guid("503d8450-5ff0-49ac-8afd-447f85639672"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_3.jpg?alt=media&token=fc95d920-491f-4c8d-a50a-681673bb929d" },
                    { new Guid("59d8aabb-133c-46cb-a92f-dfcc21f01fff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("5a66dc8f-26fb-4733-83f6-bd28631b4da7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("60c373ac-e800-4aed-a145-d6ab537997b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m1.jpg?alt=media&token=5b52cbae-c5fd-4d97-8af8-5f2d5fb6df1b" },
                    { new Guid("60cd2198-7a2e-46b0-86b8-76eeb5c97c1a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("679ef9a5-40eb-4d73-a756-f1efc7111a70"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_1.jpg?alt=media&token=42eda424-48f5-4586-a7e6-fda26c5659be" },
                    { new Guid("67dbfec9-8504-4732-a438-644468e89097"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m2.jpg?alt=media&token=7f01ab19-e4e8-42ea-8278-2ce5b7e50872" },
                    { new Guid("73b027be-56b9-468f-94a3-b8b0126758c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("745a5a5f-5f74-42ff-a2d5-31b65a5c66b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("7561a16e-2614-4dd3-8e2d-2eada65758fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("81b2b5ad-ed38-49a7-a103-09b30bb4b9a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m1.jpg?alt=media&token=1c3dcb9b-9ba2-49e4-a39b-c6c7fa428bc6" },
                    { new Guid("8312cd2a-bd01-4541-9d5f-7060249e4ce6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m2.jpg?alt=media&token=001430c6-ef62-4db7-96cf-678ebcd6dea5" },
                    { new Guid("8e088577-7a1f-4ed7-9f73-626309b2e27d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("91eaca3d-26aa-45fa-af98-be6ce8e4cf94"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f376d66d-cf4a-4103-836f-43811290f18c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("92fce929-19fa-4a9f-9ab4-36d2115caa97"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b9948c96-e456-471d-b523-159b7cf3242c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("97b02869-aa71-4dc2-9449-308d99ea4b3d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_3.jpg?alt=media&token=801a85ce-434c-4eee-9652-3672d8bb4482" },
                    { new Guid("9eaa7e2f-16f2-47ca-8467-16236096a5cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m2.jpg?alt=media&token=f5167a68-4c7a-46cf-ad28-e352ab8481e5" },
                    { new Guid("a127ec75-32f9-4164-9cf5-2cae87685858"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("b4fb5c6e-1c56-437f-9d89-9adaa1290f41"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("c40b1341-974e-4bc4-a97f-44c52a00ae33"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("c5f7d842-410f-4f62-8acc-dd186d005a32"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m1.jpg?alt=media&token=3788a61b-0bb2-40cd-a27f-da6d6c078939" },
                    { new Guid("d41ba483-cf4d-459c-af5d-13e4c36bdccd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_1.jpg?alt=media&token=c8ef04f8-2a5e-4b64-a10e-b3693616f8a3" },
                    { new Guid("e8fe8590-0487-4230-99ea-608de862e2c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("ebfc0667-3327-4307-8ce7-3cfe7ed153fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m2.jpg?alt=media&token=235c27dd-1417-46da-82ee-af820e415790" },
                    { new Guid("f2084c6a-68ee-4da9-8187-b3fd6f148be8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("005da949-dd83-438b-9ee9-aea012d87068"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("f8910cd7-5342-4ef2-ae4d-e1252506a58e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_4.jpg?alt=media&token=164f4d10-12f3-442c-81d2-eed699c79bd5" }
                });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8472), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8477), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8467), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8458), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8479), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8462), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8474), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8448), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8456), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8469), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8453), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8464), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8190), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8237), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8237) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8213), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8233), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8218), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8188), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8226), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8197), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8243), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8228), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8239), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8208), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8209) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8195), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8216), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8206), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8220), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8204), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8224), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8210), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8235), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8222), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8202), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8200), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8184), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8230), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8192), new DateTime(2024, 6, 17, 14, 10, 9, 116, DateTimeKind.Local).AddTicks(8193) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("0663503d-ff24-4a64-81e6-85d83c466073"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("073b0b1b-8903-4154-a8b9-4f26828394da"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1b92d8fc-77b7-4864-a8fb-4ac1fd0f157f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2341b751-93b6-43c3-8025-70ca3157a8c5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("302bd418-6297-4252-885b-cfc930b5cdb4"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3086e7d0-47c2-45f8-afd8-5528bf3844b9"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3c706475-c113-4b0b-a0dd-d2757fcf0fdb"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3cfbd072-4af9-469d-aea0-ebe66ad10200"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("46700f31-fa9c-405d-87a6-1cf4c3f915ac"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("469b4a98-2b40-4df5-bdf2-91c243b8fddd"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4a5c5f56-31cf-48ff-adca-2aec86efdde3"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4c9056e7-998e-4f11-bc55-e892ede406b0"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("503d8450-5ff0-49ac-8afd-447f85639672"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("59d8aabb-133c-46cb-a92f-dfcc21f01fff"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("5a66dc8f-26fb-4733-83f6-bd28631b4da7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("60c373ac-e800-4aed-a145-d6ab537997b3"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("60cd2198-7a2e-46b0-86b8-76eeb5c97c1a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("679ef9a5-40eb-4d73-a756-f1efc7111a70"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("67dbfec9-8504-4732-a438-644468e89097"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("73b027be-56b9-468f-94a3-b8b0126758c3"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("745a5a5f-5f74-42ff-a2d5-31b65a5c66b5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("7561a16e-2614-4dd3-8e2d-2eada65758fa"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("81b2b5ad-ed38-49a7-a103-09b30bb4b9a8"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("8312cd2a-bd01-4541-9d5f-7060249e4ce6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("8e088577-7a1f-4ed7-9f73-626309b2e27d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("91eaca3d-26aa-45fa-af98-be6ce8e4cf94"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("92fce929-19fa-4a9f-9ab4-36d2115caa97"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("97b02869-aa71-4dc2-9449-308d99ea4b3d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("9eaa7e2f-16f2-47ca-8467-16236096a5cc"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a127ec75-32f9-4164-9cf5-2cae87685858"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b4fb5c6e-1c56-437f-9d89-9adaa1290f41"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c40b1341-974e-4bc4-a97f-44c52a00ae33"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c5f7d842-410f-4f62-8acc-dd186d005a32"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d41ba483-cf4d-459c-af5d-13e4c36bdccd"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e8fe8590-0487-4230-99ea-608de862e2c0"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("ebfc0667-3327-4307-8ce7-3cfe7ed153fe"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("f2084c6a-68ee-4da9-8187-b3fd6f148be8"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("f8910cd7-5342-4ef2-ae4d-e1252506a58e"));

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3042), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3036), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3021), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3040), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3289), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3323), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3329), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3286), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3304), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3318), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3301), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3326), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3316), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3313), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3321), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3309), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3306), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3282), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3297), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c20d846c-a73b-4356-8736-a51273667bee"),
                column: "DateCreated",
                value: new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "DateCreated", "DateModified", "Description", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("01eed231-0cc0-44f2-b631-8b4e9653736d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_4.jpg?alt=media&token=164f4d10-12f3-442c-81d2-eed699c79bd5" },
                    { new Guid("0316b718-ec25-4c02-9641-7931da533d1e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f376d66d-cf4a-4103-836f-43811290f18c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("03b819ec-54fa-49f4-bbf0-1950bb02ffea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m2.jpg?alt=media&token=33c0ae2b-4f6d-4864-879d-a1c08be6d412" },
                    { new Guid("1085fa38-953f-4985-986b-5f5d939c0800"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("1d7efae8-02bd-40ef-a233-bcdc3e5e5697"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("25211712-8432-4d90-aadd-30f004e33803"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("2a16c3fa-77c9-4c1a-861b-0d0e22dc5e08"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("005da949-dd83-438b-9ee9-aea012d87068"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("313965dd-0c89-48cc-b2c8-b5c47452332e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("35ce207a-42d0-4925-a2a9-b1c11d59aef9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("36342e10-f5bd-4255-878e-9fbf54022965"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m2.jpg?alt=media&token=f5167a68-4c7a-46cf-ad28-e352ab8481e5" },
                    { new Guid("47232d79-3661-43a4-81c3-6c6c0c7575fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_2.jpg?alt=media&token=42dc5653-5240-4df1-9b39-c4d1975defd7" },
                    { new Guid("4f46d147-b899-434d-abbb-e238c0b68261"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m1.jpg?alt=media&token=1c3dcb9b-9ba2-49e4-a39b-c6c7fa428bc6" },
                    { new Guid("60f49d0a-94f6-4a38-96ad-544d8714d990"), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3554), null, null, new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_2.jpg?alt=media&token=7a80ce7c-4073-46f7-a1e9-aa9d2196bdd6" },
                    { new Guid("64da840d-314f-44f7-99d6-09b4d3179036"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m2.jpg?alt=media&token=c7c568ef-cd9b-4889-9fc2-96e478177e97" },
                    { new Guid("66039dd0-dbb2-4abc-94b5-cef422a7c666"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m1.jpg?alt=media&token=3788a61b-0bb2-40cd-a27f-da6d6c078939" },
                    { new Guid("6ce6546b-3ff8-4a6d-adbe-29fd32cc6db6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_3.jpg?alt=media&token=fc95d920-491f-4c8d-a50a-681673bb929d" },
                    { new Guid("6d3c954f-d850-4b22-b9e0-6c677893ccb7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m1.jpg?alt=media&token=5b52cbae-c5fd-4d97-8af8-5f2d5fb6df1b" },
                    { new Guid("70362f03-39c1-477d-83ce-2fc2b4c61e5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m2.jpg?alt=media&token=001430c6-ef62-4db7-96cf-678ebcd6dea5" },
                    { new Guid("80dac77a-55ca-4218-ba3f-f547fc0d4d5a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("8d095dc0-04c5-48d6-a849-a4f663437f11"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_3.jpg?alt=media&token=801a85ce-434c-4eee-9652-3672d8bb4482" },
                    { new Guid("93605508-9eac-43f7-8b00-704573af8d62"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m1.jpg?alt=media&token=2144ca96-674c-454e-b5c4-9141e98af6d7" },
                    { new Guid("98e7efa3-f868-487b-8f3d-0abceedad92d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("a41d58ff-d897-40b0-898b-944a9d917304"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m1.jpg?alt=media&token=ce8862c1-380a-479e-a0e9-58634fa2d68a" },
                    { new Guid("a7ee6d34-0bb4-4529-af34-a24cc5c2aec5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b9948c96-e456-471d-b523-159b7cf3242c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("a8fa7909-ff6f-4a80-bae1-8cd4383711e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m2.jpg?alt=media&token=235c27dd-1417-46da-82ee-af820e415790" },
                    { new Guid("aa41898d-5d98-4640-a882-402c2875683f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("b29d6f86-f991-4b59-9ac9-9591253b46df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_4.jpg?alt=media&token=f0761d38-c205-48d8-89fd-84039af48ddf" },
                    { new Guid("ba53940e-3ce6-44ac-a6f7-9e3294fe892d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m1.jpg?alt=media&token=ec5d2b70-753a-4485-a892-60c5c0938615" },
                    { new Guid("bdffcf2e-4136-4bda-827e-ba94c5e397d6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("be947e02-40cb-481e-8ee8-be0762ff272d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_1.jpg?alt=media&token=e313cc02-5436-487a-9a3b-71f4985fb733" },
                    { new Guid("c0b649de-7ea9-4dfd-8f73-f03ba81b6daa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("e1d4fe10-219b-4bed-9c2b-6d5f0db82c22"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("e51c2ee5-f67f-4c9e-9cb1-88fe56e9a525"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("f08a0cee-79c5-4639-be34-5d8560ca064c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_1.jpg?alt=media&token=c8ef04f8-2a5e-4b64-a10e-b3693616f8a3" },
                    { new Guid("f4a95b09-b185-4ae0-b3d9-b65a3d469184"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("f8cb0bf6-3240-497d-af62-50f7176ef636"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_1.jpg?alt=media&token=42eda424-48f5-4586-a7e6-fda26c5659be" },
                    { new Guid("fbbb6813-3246-4264-860b-96ecde4c9d39"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("ffe880e9-7af6-4582-807e-7e6de195b607"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m2.jpg?alt=media&token=7f01ab19-e4e8-42ea-8278-2ce5b7e50872" }
                });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3436), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3441), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3431), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3422), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3444), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3425), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3439), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3413), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3420), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3433), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3417), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3428), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3133), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3188), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3193), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3159), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3181), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3164), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3131), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3174), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3141), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3195), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3177), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3191), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3154), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3138), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3161), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3151), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3166), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3149), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3172), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3157), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3184), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3170), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3146), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3143), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3126), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3179), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3136), new DateTime(2024, 6, 16, 21, 9, 59, 331, DateTimeKind.Local).AddTicks(3136) });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiamonShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataForImageDiamond : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("09a7bd85-b700-4409-98c4-ee5428d80667"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1199a418-b68f-4597-bf9b-cb770759772f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1317491e-6e39-4e97-94c4-8985571ba043"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1a089008-1ef8-45ee-a647-f2ad57fb6ab2"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1cccc592-2386-440b-b525-0d950ce7405e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1f3a48e6-430e-4ed1-af98-cdb292c823ee"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2277932d-ef01-4cd2-a2b5-4696af94af4a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("26265a30-48a8-495f-9bd5-5d1de032518b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("34a2534e-bfde-4566-96b2-507179d6b50f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4bb7728c-b15c-4316-ad1e-6f92f0695958"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("555e5078-d390-4cab-b127-81fe384244a7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("5b6b2190-1769-4805-a285-ca9da73ec785"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6f5ac7eb-297d-4a60-a588-4dc01c801533"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("71bcfd2b-cc86-4bc7-9935-e91796b3835e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("72697767-bc7a-43ec-bc06-584cfb96f535"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("737c7e14-f3b0-42ea-bc91-8c05c819895a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("888f7f39-f29d-4126-9312-8d6699657dac"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a1ea0747-9b03-4458-990e-2c0f2e4635dd"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b9a18ff7-3a00-4a40-9599-f6fef5a1b07d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("be502b7d-4ac8-4672-af22-608343bfc206"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("da618071-5d73-4ca4-b155-4366a440e50a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e5749463-e232-43d2-a827-da6140eb6ce6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("eebde885-72f9-4bf7-afee-713c02df47c7"));

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(424), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(420), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(417), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(401), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(422), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(692), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(722), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(727), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(690), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(702), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(717), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(700), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(715), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(712), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(719), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(710), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(707), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(686), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(697), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c20d846c-a73b-4356-8736-a51273667bee"),
                column: "DateCreated",
                value: new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "DateCreated", "DateModified", "Description", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("0e5f0d80-5d1d-4f41-889a-34c9d9b345b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("13454d9a-36f6-40c5-82a6-1f22d004b95e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m2.jpg?alt=media&token=235c27dd-1417-46da-82ee-af820e415790" },
                    { new Guid("18430e7a-505a-47d7-8767-e799e64bea30"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("1a5b0953-b07e-424e-a793-42385c4b0d91"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_4.jpg?alt=media&token=164f4d10-12f3-442c-81d2-eed699c79bd5" },
                    { new Guid("3611dc10-1f43-4776-a6d8-99a5d201e5b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m1.jpg?alt=media&token=1c3dcb9b-9ba2-49e4-a39b-c6c7fa428bc6" },
                    { new Guid("3d491544-3bee-44fd-a0ca-78979130e033"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_3.jpg?alt=media&token=fc95d920-491f-4c8d-a50a-681673bb929d" },
                    { new Guid("3e5dad0a-200b-42ec-9f35-ce4ab68b027c"), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(945), null, null, new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_2.jpg?alt=media&token=7a80ce7c-4073-46f7-a1e9-aa9d2196bdd6" },
                    { new Guid("465a84da-3cf0-4ca4-869a-90822c55ee69"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("5d711373-e674-4fee-a6db-22e1ed6b0582"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("6033cd2b-2b5e-4fdb-9e31-75b230fffde5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_2.jpg?alt=media&token=42dc5653-5240-4df1-9b39-c4d1975defd7" },
                    { new Guid("60944a63-5211-48b4-b8ef-b3cbc09d2970"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("63a49c67-11d3-4709-b79a-00bfbff873b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("640afe55-c5b7-4e59-bfc0-5948c1a10549"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m2.jpg?alt=media&token=001430c6-ef62-4db7-96cf-678ebcd6dea5" },
                    { new Guid("6bb2d8d4-a29e-42da-a0dc-cac47f13ed84"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_1.jpg?alt=media&token=e313cc02-5436-487a-9a3b-71f4985fb733" },
                    { new Guid("6dc8d799-a3e0-450e-a903-5b3536295da4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m1.jpg?alt=media&token=ce8862c1-380a-479e-a0e9-58634fa2d68a" },
                    { new Guid("6e9ba925-4286-425b-ba54-a767dc46952f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("710221f9-ca09-41ac-af37-5227e683bbfd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("723a5a3f-45fb-445a-b627-b8d9bab53e9c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("761d2f4d-c9e1-4621-add6-6e9705fa1d25"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m1.jpg?alt=media&token=2144ca96-674c-454e-b5c4-9141e98af6d7" },
                    { new Guid("779ad5d7-6bfe-4658-afb2-d839ecc4b578"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m2.jpg?alt=media&token=33c0ae2b-4f6d-4864-879d-a1c08be6d412" },
                    { new Guid("805bd9e6-4f04-4329-bb52-75b9c20cbafb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f376d66d-cf4a-4103-836f-43811290f18c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("83a79299-4644-479b-8f5b-a4e0426452b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("9e3f6cf7-7887-4de9-8f2c-347bfed83668"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_1.jpg?alt=media&token=42eda424-48f5-4586-a7e6-fda26c5659be" },
                    { new Guid("a596cc3a-1895-49c7-87c3-ad86694996df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m2.jpg?alt=media&token=c7c568ef-cd9b-4889-9fc2-96e478177e97" },
                    { new Guid("a5d1ae29-afd5-430c-87fc-c23af3266b06"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("a7d5c530-0dba-4dc2-9b97-c0562c4b09ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m2.jpg?alt=media&token=f5167a68-4c7a-46cf-ad28-e352ab8481e5" },
                    { new Guid("b014b09c-8feb-4fef-a7c1-a99c268ed03e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("bc68df6a-0dbb-4552-b839-c54ac8a57d5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m1.jpg?alt=media&token=3788a61b-0bb2-40cd-a27f-da6d6c078939" },
                    { new Guid("c02260a0-7570-4b19-b91d-2cf5fecec712"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m1.jpg?alt=media&token=ec5d2b70-753a-4485-a892-60c5c0938615" },
                    { new Guid("c1de67d2-f352-4452-a9d8-06f6159ad9dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b9948c96-e456-471d-b523-159b7cf3242c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("d6715fe1-f1e0-4471-8598-67e72818a6f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_3.jpg?alt=media&token=801a85ce-434c-4eee-9652-3672d8bb4482" },
                    { new Guid("d749f81a-a9b6-4389-abd1-aeb56614ad93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_4.jpg?alt=media&token=f0761d38-c205-48d8-89fd-84039af48ddf" },
                    { new Guid("da7af626-9376-405c-abad-49390a29e574"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_1.jpg?alt=media&token=c8ef04f8-2a5e-4b64-a10e-b3693616f8a3" },
                    { new Guid("e0d312bc-a1c0-4d62-8ca9-bb0609bdf6e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m1.jpg?alt=media&token=5b52cbae-c5fd-4d97-8af8-5f2d5fb6df1b" },
                    { new Guid("f69f2156-9bda-468d-b1e7-84989878a309"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("f9905344-1b50-4cf1-9b50-a69a5984e037"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("005da949-dd83-438b-9ee9-aea012d87068"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("fdf3ebd0-2ea5-4179-a858-3770a3a67e92"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m2.jpg?alt=media&token=7f01ab19-e4e8-42ea-8278-2ce5b7e50872" },
                    { new Guid("fe9e8350-a792-471a-98fe-d26b14b7179e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" }
                });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(823), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(828), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(818), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(809), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(830), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(813), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(825), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(800), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(807), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(820), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(804), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(815), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(526), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(580), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(585), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(555), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(576), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(560), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(524), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(570), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(534), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(587), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(572), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(583), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(551), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(531), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(557), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(547), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(563), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(544), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(568), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(553), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(578), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(565), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(541), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(538), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(520), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(574), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(529), new DateTime(2024, 6, 13, 15, 26, 22, 704, DateTimeKind.Local).AddTicks(529) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("0e5f0d80-5d1d-4f41-889a-34c9d9b345b1"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("13454d9a-36f6-40c5-82a6-1f22d004b95e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("18430e7a-505a-47d7-8767-e799e64bea30"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1a5b0953-b07e-424e-a793-42385c4b0d91"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3611dc10-1f43-4776-a6d8-99a5d201e5b7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3d491544-3bee-44fd-a0ca-78979130e033"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3e5dad0a-200b-42ec-9f35-ce4ab68b027c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("465a84da-3cf0-4ca4-869a-90822c55ee69"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("5d711373-e674-4fee-a6db-22e1ed6b0582"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6033cd2b-2b5e-4fdb-9e31-75b230fffde5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("60944a63-5211-48b4-b8ef-b3cbc09d2970"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("63a49c67-11d3-4709-b79a-00bfbff873b5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("640afe55-c5b7-4e59-bfc0-5948c1a10549"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6bb2d8d4-a29e-42da-a0dc-cac47f13ed84"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6dc8d799-a3e0-450e-a903-5b3536295da4"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6e9ba925-4286-425b-ba54-a767dc46952f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("710221f9-ca09-41ac-af37-5227e683bbfd"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("723a5a3f-45fb-445a-b627-b8d9bab53e9c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("761d2f4d-c9e1-4621-add6-6e9705fa1d25"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("779ad5d7-6bfe-4658-afb2-d839ecc4b578"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("805bd9e6-4f04-4329-bb52-75b9c20cbafb"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("83a79299-4644-479b-8f5b-a4e0426452b1"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("9e3f6cf7-7887-4de9-8f2c-347bfed83668"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a596cc3a-1895-49c7-87c3-ad86694996df"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a5d1ae29-afd5-430c-87fc-c23af3266b06"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a7d5c530-0dba-4dc2-9b97-c0562c4b09ae"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b014b09c-8feb-4fef-a7c1-a99c268ed03e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("bc68df6a-0dbb-4552-b839-c54ac8a57d5e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c02260a0-7570-4b19-b91d-2cf5fecec712"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c1de67d2-f352-4452-a9d8-06f6159ad9dc"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d6715fe1-f1e0-4471-8598-67e72818a6f0"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d749f81a-a9b6-4389-abd1-aeb56614ad93"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("da7af626-9376-405c-abad-49390a29e574"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e0d312bc-a1c0-4d62-8ca9-bb0609bdf6e8"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("f69f2156-9bda-468d-b1e7-84989878a309"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("f9905344-1b50-4cf1-9b50-a69a5984e037"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("fdf3ebd0-2ea5-4179-a858-3770a3a67e92"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("fe9e8350-a792-471a-98fe-d26b14b7179e"));

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2237), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2233), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2223), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2207), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2234), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2460), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2485), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2498), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2458), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2468), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2468) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2480), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2465), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2487), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2478), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2475), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2482), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2473), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2470), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2454), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2463), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c20d846c-a73b-4356-8736-a51273667bee"),
                column: "DateCreated",
                value: new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "DateCreated", "DateModified", "Description", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("09a7bd85-b700-4409-98c4-ee5428d80667"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m1.jpg?alt=media&token=1c3dcb9b-9ba2-49e4-a39b-c6c7fa428bc6" },
                    { new Guid("1199a418-b68f-4597-bf9b-cb770759772f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m2.jpg?alt=media&token=33c0ae2b-4f6d-4864-879d-a1c08be6d412" },
                    { new Guid("1317491e-6e39-4e97-94c4-8985571ba043"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m1.jpg?alt=media&token=ec5d2b70-753a-4485-a892-60c5c0938615" },
                    { new Guid("1a089008-1ef8-45ee-a647-f2ad57fb6ab2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m2.jpg?alt=media&token=f5167a68-4c7a-46cf-ad28-e352ab8481e5" },
                    { new Guid("1cccc592-2386-440b-b525-0d950ce7405e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m2.jpg?alt=media&token=235c27dd-1417-46da-82ee-af820e415790" },
                    { new Guid("1f3a48e6-430e-4ed1-af98-cdb292c823ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_1.jpg?alt=media&token=e313cc02-5436-487a-9a3b-71f4985fb733" },
                    { new Guid("2277932d-ef01-4cd2-a2b5-4696af94af4a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("26265a30-48a8-495f-9bd5-5d1de032518b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m2.jpg?alt=media&token=001430c6-ef62-4db7-96cf-678ebcd6dea5" },
                    { new Guid("34a2534e-bfde-4566-96b2-507179d6b50f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m1.jpg?alt=media&token=ce8862c1-380a-479e-a0e9-58634fa2d68a" },
                    { new Guid("4bb7728c-b15c-4316-ad1e-6f92f0695958"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m1.jpg?alt=media&token=5b52cbae-c5fd-4d97-8af8-5f2d5fb6df1b" },
                    { new Guid("555e5078-d390-4cab-b127-81fe384244a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_1.jpg?alt=media&token=42eda424-48f5-4586-a7e6-fda26c5659be" },
                    { new Guid("5b6b2190-1769-4805-a285-ca9da73ec785"), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2715), null, null, new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_2.jpg?alt=media&token=7a80ce7c-4073-46f7-a1e9-aa9d2196bdd6" },
                    { new Guid("6f5ac7eb-297d-4a60-a588-4dc01c801533"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_1.jpg?alt=media&token=c8ef04f8-2a5e-4b64-a10e-b3693616f8a3" },
                    { new Guid("71bcfd2b-cc86-4bc7-9935-e91796b3835e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_4.jpg?alt=media&token=f0761d38-c205-48d8-89fd-84039af48ddf" },
                    { new Guid("72697767-bc7a-43ec-bc06-584cfb96f535"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m2.jpg?alt=media&token=7f01ab19-e4e8-42ea-8278-2ce5b7e50872" },
                    { new Guid("737c7e14-f3b0-42ea-bc91-8c05c819895a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m1.jpg?alt=media&token=3788a61b-0bb2-40cd-a27f-da6d6c078939" },
                    { new Guid("888f7f39-f29d-4126-9312-8d6699657dac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_3.jpg?alt=media&token=801a85ce-434c-4eee-9652-3672d8bb4482" },
                    { new Guid("a1ea0747-9b03-4458-990e-2c0f2e4635dd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m2.jpg?alt=media&token=c7c568ef-cd9b-4889-9fc2-96e478177e97" },
                    { new Guid("b9a18ff7-3a00-4a40-9599-f6fef5a1b07d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_4.jpg?alt=media&token=164f4d10-12f3-442c-81d2-eed699c79bd5" },
                    { new Guid("be502b7d-4ac8-4672-af22-608343bfc206"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_3.jpg?alt=media&token=fc95d920-491f-4c8d-a50a-681673bb929d" },
                    { new Guid("da618071-5d73-4ca4-b155-4366a440e50a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m1.jpg?alt=media&token=2144ca96-674c-454e-b5c4-9141e98af6d7" },
                    { new Guid("e5749463-e232-43d2-a827-da6140eb6ce6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("eebde885-72f9-4bf7-afee-713c02df47c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_2.jpg?alt=media&token=42dc5653-5240-4df1-9b39-c4d1975defd7" }
                });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2608), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2613), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2603), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2595), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2615), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2598), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2610), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2584), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2593), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2605), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2589), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2600), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2316), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2368), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2372), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2341), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2363), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2345), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2313), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2357), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2324), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2374), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2359), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2370), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2337), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2321), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2343), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2334), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2350), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2332), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2355), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2339), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2366), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2353), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2329), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2327), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2310), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2361), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2318), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2319) });
        }
    }
}

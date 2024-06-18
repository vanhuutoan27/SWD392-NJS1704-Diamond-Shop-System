using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiamonShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedDbContextForInvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Orders_OrderId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Users_UserId",
                table: "Invoice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1fbcb54d-14ba-4ebc-9f19-db405c41c6af"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2f10d802-f1cf-443d-9cf7-c3c714d3d4dc"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2f515837-bfd9-4101-b62f-52d2e8e137a7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("34927dca-ff9f-4a66-a8ab-890b66ffd3d0"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3b4159dd-f51e-44f2-86ef-0cf46a970a60"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4586c867-0a4f-46da-adb3-ce0611a3e29b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4c66429f-bf91-49b2-b4be-565349af96d5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4ecd1768-4889-4487-9266-520008edea78"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("53aad37d-00bf-40ed-9456-d09999c7beb8"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("57e19dee-78a2-4a29-b70c-e60c27b9f150"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("57ee5d03-2c31-4761-a989-5fccbf9ae761"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("587cee58-5b9f-42d0-99ba-e0b3c43bc0d5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("5901b28b-52b0-4595-af8b-744f166c2efa"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("5ebfd4d1-7f0b-4a4c-a3c0-82c7df197462"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("5f9d088a-d84b-4bcd-b35e-0f915119651a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("744f4f0a-d7fe-44f6-a9b5-627434d68ba7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("80f3a1e0-78e1-405c-b253-5ccb7ed71283"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("826e30e9-1972-46be-b237-95e1a51f8755"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("898dc690-ba6d-483e-a711-d120b0db516a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("8a77277a-88cb-46d2-85a7-58556d266ae6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("8d765d0e-7be9-4778-9102-98a1319ef125"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("8fdaff88-8f13-4537-81fd-42096a186f42"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("968327d9-74c8-4c37-b751-be9c53c11e71"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("97aae560-99b2-4131-a1bc-2086f81833e9"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("9a010b6a-75a7-41db-990d-6cb176716ec4"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("9cc5ea62-63b0-44f8-9643-5f1d629070ab"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("9de26926-1bd8-4212-953f-95084ce5c0f3"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a49270ae-acbc-4ce3-92c6-935221455753"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a90e9298-c6cb-4b1b-af47-652e472c5d99"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b61a616f-7fa2-4567-a855-fa8a67735654"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("bac50b08-6046-4578-9534-edd8836a3e6b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("be8eb997-afd1-42c5-a087-67cb0a11e089"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c06618e8-196b-4892-9ef8-64ff86d4bd39"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c4f41f1e-0fc0-4f3f-b88b-39b1056313b5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d010a613-fc22-4232-b71b-69faea5c87d0"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d6c71526-7110-491a-8632-2f8c1fc0f9f7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d76a757e-36af-4ca7-ad70-b3a27abbb901"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d80aefa8-46a0-4a17-8112-3bc50a79de51"));

            migrationBuilder.RenameTable(
                name: "Invoice",
                newName: "Invoices");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_UserId",
                table: "Invoices",
                newName: "IX_Invoices_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_OrderId",
                table: "Invoices",
                newName: "IX_Invoices_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "InvoiceId");

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7579), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7575), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7573), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7556), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7576), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7835), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7861), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7866), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7832), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7843), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7856), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7840), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7864), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7853), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7851), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7858), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7848), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7845), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7828), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7837), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c20d846c-a73b-4356-8736-a51273667bee"),
                column: "DateCreated",
                value: new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "DateCreated", "DateModified", "Description", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("0562e5a5-9b6e-4aff-8106-40c2a36af4c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m2.jpg?alt=media&token=7f01ab19-e4e8-42ea-8278-2ce5b7e50872" },
                    { new Guid("07981035-9535-4080-bf9e-829c91a51779"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("1a3f4b95-31bd-422c-90b7-f7b7a5ff4c50"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("1b86383e-e4f4-4b55-8d9e-98019cb89f97"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m1.jpg?alt=media&token=ce8862c1-380a-479e-a0e9-58634fa2d68a" },
                    { new Guid("2aa2e44f-4bcd-4528-866b-8535d8509c25"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_4.jpg?alt=media&token=f0761d38-c205-48d8-89fd-84039af48ddf" },
                    { new Guid("375274b1-98e6-4250-b2da-680fffa00b18"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("45f21df4-78c6-4aef-b873-bf33d64ee6b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_1.jpg?alt=media&token=e313cc02-5436-487a-9a3b-71f4985fb733" },
                    { new Guid("48214c5e-d9e0-490d-a163-8f2f3fd07813"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("005da949-dd83-438b-9ee9-aea012d87068"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("49e4c888-2e1e-4a00-bdba-8f834abc7154"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("4a7c71fb-087d-4c2d-8cae-fa55aeebfcc5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m1.jpg?alt=media&token=5b52cbae-c5fd-4d97-8af8-5f2d5fb6df1b" },
                    { new Guid("4c3ae44b-8bdd-4780-acf1-8ed3272135fc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f376d66d-cf4a-4103-836f-43811290f18c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("4ca8b9f1-d2d8-4a7f-8518-29e3c45337ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m2.jpg?alt=media&token=33c0ae2b-4f6d-4864-879d-a1c08be6d412" },
                    { new Guid("4e466ba8-5348-47f1-a80c-0aafae539238"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_4.jpg?alt=media&token=164f4d10-12f3-442c-81d2-eed699c79bd5" },
                    { new Guid("4f3b7acf-0c15-4998-93de-fe91b56344bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m1.jpg?alt=media&token=2144ca96-674c-454e-b5c4-9141e98af6d7" },
                    { new Guid("645126ae-2a68-4039-8b31-454cdd02c0b8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("65a8cc36-bce5-4835-9df9-f5b9418d17c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_1.jpg?alt=media&token=42eda424-48f5-4586-a7e6-fda26c5659be" },
                    { new Guid("6eba9c01-3cab-45fd-a9aa-1b7f83b5cc26"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_3.jpg?alt=media&token=fc95d920-491f-4c8d-a50a-681673bb929d" },
                    { new Guid("6f04178f-1dcd-4853-9135-0916db53a5aa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m1.jpg?alt=media&token=3788a61b-0bb2-40cd-a27f-da6d6c078939" },
                    { new Guid("6f74b005-0d40-4405-a97b-74d5eff50938"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m1.jpg?alt=media&token=1c3dcb9b-9ba2-49e4-a39b-c6c7fa428bc6" },
                    { new Guid("790d0507-6794-4e59-b860-b8abef91de28"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m2.jpg?alt=media&token=001430c6-ef62-4db7-96cf-678ebcd6dea5" },
                    { new Guid("7dfde50c-0df9-46ac-a210-bf09dfdfb242"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_3.jpg?alt=media&token=801a85ce-434c-4eee-9652-3672d8bb4482" },
                    { new Guid("86b91be2-8a38-4dbe-ba12-b7aebcb0ec18"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("877439e4-4bc9-4f29-972e-68deaf272c2c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m1.jpg?alt=media&token=ec5d2b70-753a-4485-a892-60c5c0938615" },
                    { new Guid("8b56b8d0-c186-4828-a9f1-eaaf033d78b8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("99f75ec6-4682-45d3-9f8c-df6817be287f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_2.jpg?alt=media&token=42dc5653-5240-4df1-9b39-c4d1975defd7" },
                    { new Guid("9c101f07-658c-44bb-b490-5f3e645434a4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m2.jpg?alt=media&token=235c27dd-1417-46da-82ee-af820e415790" },
                    { new Guid("a8adb7fd-966d-481b-a7d7-bc966e270169"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m2.jpg?alt=media&token=c7c568ef-cd9b-4889-9fc2-96e478177e97" },
                    { new Guid("b3aaf79e-e2d3-4f50-aac9-a06fda4bc1b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_1.jpg?alt=media&token=c8ef04f8-2a5e-4b64-a10e-b3693616f8a3" },
                    { new Guid("b77a9e78-595c-46f4-b489-acdccd583b0d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("b8986286-71e8-4b13-9eea-4dbdcbd88185"), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(8073), null, null, new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_2.jpg?alt=media&token=7a80ce7c-4073-46f7-a1e9-aa9d2196bdd6" },
                    { new Guid("c47dbb87-d92b-44aa-a619-5124b79ec972"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b9948c96-e456-471d-b523-159b7cf3242c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("c814b47a-a3e8-432e-a6dd-9607b60d3611"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("c9523869-5611-4553-9a57-3f2b3d16676a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("d747bf77-15f9-45e4-ae4b-522586945f3a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("ddbcb8a0-1599-4d7f-ae27-bf8a6ff4de12"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("e42c7ca7-5ccd-48c2-b659-6c9006645d5c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("f436b5f9-2292-4500-bc25-f2a50ee0f572"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("f5b47716-04f4-4fd5-9972-8776a062c2a4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m2.jpg?alt=media&token=f5167a68-4c7a-46cf-ad28-e352ab8481e5" }
                });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7965), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7970), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7959), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7951), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7973), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7954), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7967), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7942), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7948), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7962), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7946), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7957), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7666), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7716), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7726), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7691), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7711), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7695), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7663), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7705), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7673), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7728), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7707), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7718), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7686), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7670), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7693), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7684), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7698), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7682), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7702), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7688), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7714), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7700), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7679), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7677), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7660), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7709), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7668), new DateTime(2024, 6, 17, 23, 49, 4, 840, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Orders_OrderId",
                table: "Invoices",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Users_UserId",
                table: "Invoices",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Orders_OrderId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Users_UserId",
                table: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("0562e5a5-9b6e-4aff-8106-40c2a36af4c1"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("07981035-9535-4080-bf9e-829c91a51779"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1a3f4b95-31bd-422c-90b7-f7b7a5ff4c50"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1b86383e-e4f4-4b55-8d9e-98019cb89f97"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2aa2e44f-4bcd-4528-866b-8535d8509c25"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("375274b1-98e6-4250-b2da-680fffa00b18"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("45f21df4-78c6-4aef-b873-bf33d64ee6b7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("48214c5e-d9e0-490d-a163-8f2f3fd07813"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("49e4c888-2e1e-4a00-bdba-8f834abc7154"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4a7c71fb-087d-4c2d-8cae-fa55aeebfcc5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4c3ae44b-8bdd-4780-acf1-8ed3272135fc"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4ca8b9f1-d2d8-4a7f-8518-29e3c45337ec"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4e466ba8-5348-47f1-a80c-0aafae539238"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4f3b7acf-0c15-4998-93de-fe91b56344bf"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("645126ae-2a68-4039-8b31-454cdd02c0b8"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("65a8cc36-bce5-4835-9df9-f5b9418d17c3"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6eba9c01-3cab-45fd-a9aa-1b7f83b5cc26"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6f04178f-1dcd-4853-9135-0916db53a5aa"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6f74b005-0d40-4405-a97b-74d5eff50938"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("790d0507-6794-4e59-b860-b8abef91de28"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("7dfde50c-0df9-46ac-a210-bf09dfdfb242"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("86b91be2-8a38-4dbe-ba12-b7aebcb0ec18"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("877439e4-4bc9-4f29-972e-68deaf272c2c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("8b56b8d0-c186-4828-a9f1-eaaf033d78b8"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("99f75ec6-4682-45d3-9f8c-df6817be287f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("9c101f07-658c-44bb-b490-5f3e645434a4"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a8adb7fd-966d-481b-a7d7-bc966e270169"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b3aaf79e-e2d3-4f50-aac9-a06fda4bc1b9"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b77a9e78-595c-46f4-b489-acdccd583b0d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b8986286-71e8-4b13-9eea-4dbdcbd88185"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c47dbb87-d92b-44aa-a619-5124b79ec972"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c814b47a-a3e8-432e-a6dd-9607b60d3611"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c9523869-5611-4553-9a57-3f2b3d16676a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d747bf77-15f9-45e4-ae4b-522586945f3a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("ddbcb8a0-1599-4d7f-ae27-bf8a6ff4de12"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e42c7ca7-5ccd-48c2-b659-6c9006645d5c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("f436b5f9-2292-4500-bc25-f2a50ee0f572"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("f5b47716-04f4-4fd5-9972-8776a062c2a4"));

            migrationBuilder.RenameTable(
                name: "Invoices",
                newName: "Invoice");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_UserId",
                table: "Invoice",
                newName: "IX_Invoice_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_OrderId",
                table: "Invoice",
                newName: "IX_Invoice_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice",
                column: "InvoiceId");

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1648), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1644), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1642), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1622), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1646), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1961), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1989), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1994), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1958), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1970), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1983), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1966), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1991), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1981), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1978), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1986), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1975), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1972), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1954), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1964), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c20d846c-a73b-4356-8736-a51273667bee"),
                column: "DateCreated",
                value: new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "DateCreated", "DateModified", "Description", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("1fbcb54d-14ba-4ebc-9f19-db405c41c6af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("2f10d802-f1cf-443d-9cf7-c3c714d3d4dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m1.jpg?alt=media&token=ce8862c1-380a-479e-a0e9-58634fa2d68a" },
                    { new Guid("2f515837-bfd9-4101-b62f-52d2e8e137a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m1.jpg?alt=media&token=ec5d2b70-753a-4485-a892-60c5c0938615" },
                    { new Guid("34927dca-ff9f-4a66-a8ab-890b66ffd3d0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("3b4159dd-f51e-44f2-86ef-0cf46a970a60"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("4586c867-0a4f-46da-adb3-ce0611a3e29b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_1.jpg?alt=media&token=42eda424-48f5-4586-a7e6-fda26c5659be" },
                    { new Guid("4c66429f-bf91-49b2-b4be-565349af96d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("4ecd1768-4889-4487-9266-520008edea78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("53aad37d-00bf-40ed-9456-d09999c7beb8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_3.jpg?alt=media&token=fc95d920-491f-4c8d-a50a-681673bb929d" },
                    { new Guid("57e19dee-78a2-4a29-b70c-e60c27b9f150"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m1.jpg?alt=media&token=1c3dcb9b-9ba2-49e4-a39b-c6c7fa428bc6" },
                    { new Guid("57ee5d03-2c31-4761-a989-5fccbf9ae761"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("587cee58-5b9f-42d0-99ba-e0b3c43bc0d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_2.jpg?alt=media&token=42dc5653-5240-4df1-9b39-c4d1975defd7" },
                    { new Guid("5901b28b-52b0-4595-af8b-744f166c2efa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_3.jpg?alt=media&token=801a85ce-434c-4eee-9652-3672d8bb4482" },
                    { new Guid("5ebfd4d1-7f0b-4a4c-a3c0-82c7df197462"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m2.jpg?alt=media&token=001430c6-ef62-4db7-96cf-678ebcd6dea5" },
                    { new Guid("5f9d088a-d84b-4bcd-b35e-0f915119651a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("744f4f0a-d7fe-44f6-a9b5-627434d68ba7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("80f3a1e0-78e1-405c-b253-5ccb7ed71283"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m1.jpg?alt=media&token=3788a61b-0bb2-40cd-a27f-da6d6c078939" },
                    { new Guid("826e30e9-1972-46be-b237-95e1a51f8755"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("898dc690-ba6d-483e-a711-d120b0db516a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("8a77277a-88cb-46d2-85a7-58556d266ae6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_1.jpg?alt=media&token=e313cc02-5436-487a-9a3b-71f4985fb733" },
                    { new Guid("8d765d0e-7be9-4778-9102-98a1319ef125"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("8fdaff88-8f13-4537-81fd-42096a186f42"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_1.jpg?alt=media&token=c8ef04f8-2a5e-4b64-a10e-b3693616f8a3" },
                    { new Guid("968327d9-74c8-4c37-b751-be9c53c11e71"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("97aae560-99b2-4131-a1bc-2086f81833e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("9a010b6a-75a7-41db-990d-6cb176716ec4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f376d66d-cf4a-4103-836f-43811290f18c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("9cc5ea62-63b0-44f8-9643-5f1d629070ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m2.jpg?alt=media&token=f5167a68-4c7a-46cf-ad28-e352ab8481e5" },
                    { new Guid("9de26926-1bd8-4212-953f-95084ce5c0f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m2.jpg?alt=media&token=7f01ab19-e4e8-42ea-8278-2ce5b7e50872" },
                    { new Guid("a49270ae-acbc-4ce3-92c6-935221455753"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m2.jpg?alt=media&token=33c0ae2b-4f6d-4864-879d-a1c08be6d412" },
                    { new Guid("a90e9298-c6cb-4b1b-af47-652e472c5d99"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("b61a616f-7fa2-4567-a855-fa8a67735654"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_4.jpg?alt=media&token=f0761d38-c205-48d8-89fd-84039af48ddf" },
                    { new Guid("bac50b08-6046-4578-9534-edd8836a3e6b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m2.jpg?alt=media&token=235c27dd-1417-46da-82ee-af820e415790" },
                    { new Guid("be8eb997-afd1-42c5-a087-67cb0a11e089"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b9948c96-e456-471d-b523-159b7cf3242c"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("c06618e8-196b-4892-9ef8-64ff86d4bd39"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_4.jpg?alt=media&token=164f4d10-12f3-442c-81d2-eed699c79bd5" },
                    { new Guid("c4f41f1e-0fc0-4f3f-b88b-39b1056313b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("005da949-dd83-438b-9ee9-aea012d87068"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FDiamond%2Fdiamond.png?alt=media&token=0a3f7a6f-6f7d-45b3-99b9-f4717fb440f6&fbclid=IwZXh0bgNhZW0CMTAAAR2BcnXK45vA0Hoaapnnbbry7cLNcLop1j5G_VmrBL5HVPoW7Zj_AdjMPqc_aem_AUveMTOkzhDuBxi0Ft2E2QW9v2U1zN_JvweIS3dCfF3aWJajWV7gSkVP3y7xnTP2BSD3kFBLJ_66oQLMy-yRkVrm" },
                    { new Guid("d010a613-fc22-4232-b71b-69faea5c87d0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m1.jpg?alt=media&token=2144ca96-674c-454e-b5c4-9141e98af6d7" },
                    { new Guid("d6c71526-7110-491a-8632-2f8c1fc0f9f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m1.jpg?alt=media&token=5b52cbae-c5fd-4d97-8af8-5f2d5fb6df1b" },
                    { new Guid("d76a757e-36af-4ca7-ad70-b3a27abbb901"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m2.jpg?alt=media&token=c7c568ef-cd9b-4889-9fc2-96e478177e97" },
                    { new Guid("d80aefa8-46a0-4a17-8112-3bc50a79de51"), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2230), null, null, new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_2.jpg?alt=media&token=7a80ce7c-4073-46f7-a1e9-aa9d2196bdd6" }
                });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2104), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2111), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2099), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2088), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2113), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2091), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2108), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2078), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2085), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2102), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2082), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2093), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1797), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1849), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1853), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1822), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1844), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1827), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1794), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1837), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1804), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1856), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1839), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1851), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1817), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1824), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1815), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1830), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1812), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1834), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1820), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1846), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1832), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1810), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1807), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1790), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1841), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1799), new DateTime(2024, 6, 17, 22, 34, 46, 337, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Orders_OrderId",
                table: "Invoice",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Users_UserId",
                table: "Invoice",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

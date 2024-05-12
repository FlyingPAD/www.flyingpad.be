using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Sixth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "05/12/2024 16:37:51",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "04/30/2024 16:38:53");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3c134d48-6d32-4c33-91df-44ef392a0337"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3215), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b728aca5-0d6b-45db-9cfd-395d1bb313f5"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3241), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("28682d89-384b-4bb2-a96a-e4f3d918ad8f"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3244), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("90e49b2e-bf0f-4e0c-8a5b-d2c2304a5390"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3247), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9c1be931-fc51-4814-bc84-ce43efdad34c"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3249), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("44fe90d5-988b-4b1c-97b3-c6f0912af24a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3257), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fb8134fe-650a-4268-899d-3b8740bf0fdb"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3263), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5e16acfe-03ab-433e-8573-a37e1bef6326"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3265), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bcce6d44-1b3c-4b3d-afd3-3f7db44c9cfd"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3267), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("08494fee-25e5-44b2-8cbe-875eba392391"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3273), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0e3bb0d6-5370-4bcb-92de-68af4123529d"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3276), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1aec38ff-e08a-4309-80fa-f3f1da98b6b8"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3278), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1074e387-e915-4fa3-bcfd-fb65003ed69b"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3280), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("505f3247-026f-44a0-9a06-624ca140efdd"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3285), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f34f8db7-8683-4df0-8e7c-0cdabe5b312c"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3287), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3fbc55cd-638f-40eb-86ea-75216002a704"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4485), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1375d0bf-566c-43c6-8af9-53afa0e18c45"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4492), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("08f918b9-e200-4843-89e6-3cb577b8343a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4511), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("acb2cfe9-750d-45b0-b33f-a07a8d9d88db"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4514), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("92059cd6-88a8-4156-871b-5076d576e226"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4517), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("02394fda-a6c4-4187-b585-203e405d7b5d"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4519), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4519) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("60186d1e-86c9-4999-a249-1735d3a5bb7a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4525), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("59e9ccb9-a917-4d4d-8330-bcf427b95a53"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4527), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fd4d52d6-cff2-421a-aca5-963cc605c72e"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4994), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d5f25265-13e8-4a34-850c-099170ac9766"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4998), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4999) });

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[] { 3, new Guid("651fda19-8d39-4b45-b915-a1ad0cf1b326"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5002), "", "", new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5002), "", "# Unrelated Franchise" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dc074700-9d7e-463f-8ff7-7ff06d866702"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5618), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("28fcd7b5-bbda-4fa5-9552-2a68683e33fd"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5625), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("748d5abd-0a03-49ed-bb39-be4108e33a71"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5628), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d315cd59-c663-4f1f-bdc7-fefd7287b4a3"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5631), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fc701a06-8da3-4621-8abf-5b279755778a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5633), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a83a45e8-b510-44ea-845e-ee8adbc48474"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5677), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0f6eded7-6342-463d-9ca7-c59028a612ee"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5679), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("21615a21-6d0f-475d-a81b-48c6565335e1"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5682), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5682) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1eb25c7e-d639-4f9e-98e3-7db056af1d9a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5685), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dd79dd97-9756-4199-9b26-f6200164c05d"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5690), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b7fe1245-ab91-4250-80b9-adc4c277ac7f"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5693), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("adff573c-0f2a-4e98-9bd3-eb99e8151316"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5695), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("17d7bf8e-07a5-4153-8e35-e6c244b939d9"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5698), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("25511e47-4d9b-45a2-9237-a2f67d37c7a6"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5702), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6947d238-e28b-4b07-abe3-0a831411b8fe"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5705), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("17e398f1-aae3-47ac-99ed-4016ff163c51"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5445), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("83220ce9-90f0-4b18-8518-39be1613988b"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5450), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("eefb67d8-b3d3-4162-9cca-1564152df74e"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5452), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("59657d14-c3e3-4a6b-876e-774e49f03173"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5455), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a746ee80-df2c-4e3c-8132-0be59c9e1197"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5460), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3bfc0335-9839-423d-9141-16fe1be6f046"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5464), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("eca46b8c-7a92-47ad-a914-f2fcf1ce37bf"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5466), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1d6aa85f-6dc6-47ab-99cf-a241b822fff1"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5469), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aeb4bd51-79b1-461e-b519-9aac2e6f1b71"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5473), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1b9fef63-3919-4981-9d3e-c39539c12776"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5476), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("063e5a31-461f-4675-90d3-235cfccc1fc9"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5479), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c44ed68e-3150-476d-a9c7-23b9b8461d88"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5481), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5482) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3420fc45-f13c-4365-a6ac-d346ce466dba"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5486), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("79b26276-2c3d-439d-9de6-b3970d805268"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5489), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f244825e-cbf1-46cd-af70-b241e8aa96eb"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5492), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9cac8cd6-1ce3-4bbb-83e4-c4b0400f4370"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5494), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9ee09047-1030-4caa-bb9d-62beab147406"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5499), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("87d69469-41cf-4ec0-88ce-49b6c5812ff5"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5502), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9c10f280-7f1b-45f1-b41e-a652ecb1d448"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5505), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("225ba0aa-0e05-4883-8f78-378dd0967ada"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5507), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5507) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0e67c04b-22a2-4b52-92ff-66423e8d6eae"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5512), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bce2192f-c979-418f-936b-3861e79ae659"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5514), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0e4d15c0-0a52-4e4f-a09c-48c2d29c9d09"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5517), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e846d855-9292-4a8a-967f-c0ee6eb35af0"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5519), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("de098873-6e6a-46b9-ae3a-4e9c6916cc81"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5525), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("96b6c838-3647-45a4-870f-1073695789a4"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5527), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4b7011a6-ca99-4b67-8b79-84f881c739c1"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b15ee5bf-e684-4d88-8684-54df4c39f445"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5532), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2579b4cf-3398-418e-8b82-028c89c54d18"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5537), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("96a7ad3a-ecd6-4013-8de2-630d8ebab0d0"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5539), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3f78b948-1645-49c8-b43a-c5c75db067b1"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5542), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("35b58243-1b97-440c-ad47-896bdb87e54a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5067), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bb0ada47-6c56-4272-9df3-9792a593f41c"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5222), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9e714daf-d6c7-4007-ad45-f788e603fb9f"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5226), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("06b144fe-acf4-4a26-ad7a-5df50796fb2d"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5229), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1e8a31d3-08a2-4caf-892d-a1ccdd66a6ed"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5231), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("19ac183c-75d4-40e9-86b3-63122113deea"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5239), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0604b565-c6ab-47dd-b824-3c058bd5fece"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5241), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5547be6f-d9ff-4c00-bd96-862b99ca97a4"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5244), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fdaad182-61dd-49ba-a410-017044dba588"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5246), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("769facf7-2226-48d2-b634-9acf3c706936"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5874), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "Pseudonym" },
                values: new object[] { new Guid("6bc043bf-3dda-4ee8-a28b-131666addb6f"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5879), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5880), "# Unrelated Model" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("deb7d4b3-b33f-48d2-8e0f-bb668dad44f1"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5886), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5939), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5958), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5963), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5967), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5971), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5975), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5982), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6115), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6120), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6126), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6130), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6133), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6137), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6147), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6150), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6152), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6156), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6159), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6162), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6165), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6170), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6175), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6266), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6327), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b9bb4a48-999a-4046-9c03-901c5c8394ee"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4792), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f9651d64-f663-4821-b036-95ebb96e9b70"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4797), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9a96d03c-930c-476f-b068-cc76db20b0b6"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4806), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a1289ff2-487b-4586-9ac0-1913d65b2cfb"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4808), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("72021ff2-4d5e-4b61-84a3-07557b844668"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4811), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("760bc876-2d5b-4e9a-9d2c-7102b0e4c5a7"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4814), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3a52c1bf-bc9b-447a-8a41-36dbb7f4d5c2"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4819), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f24ad3f8-e949-4361-a41f-dd0876f29b92"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4822), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dc39b8de-a1ee-49a8-b452-a5c1417289e3"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4824), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c1475339-1fc9-4791-b82d-0838e0ea806e"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4827), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aa07273e-b4fe-412e-b197-5e835831f8a0"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7187), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5ae0b3ae-8c7f-4646-971e-e132a8112008"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7191), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9db080a8-3613-4ed2-ae24-951b64f376af"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7194), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0dbb4109-2e68-4fe9-9869-b2437f4fd3ee"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7196), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("00b2e272-6738-4af6-a4b5-601abf765c45"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7202), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5623ea2e-9252-4211-8ce8-846bc6a89122"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7205), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("45e4d9e2-efce-4992-ae4e-893b86e7f5cf"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7208), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0ddece79-2637-41ce-9395-f5d1052cdddf"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7210), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5f5021a1-5e0b-49ae-a5ac-c83557c49d4a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7215), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e3f074a8-9a0c-402b-85d5-662d81c7e1f1"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7218), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a7d7b689-fe80-4a34-857d-81a95ac82740"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7220), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("adf64187-eabd-4edc-ae35-3cd1133bbe42"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7223), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ea27cbd4-1a2e-4a50-9f9d-474a76163f03"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7228), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("89af7c08-323f-4c3c-9836-1a065c83c8c1"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7231), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("de78ea7a-fdd6-4152-b265-3851c97ad499"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7233), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1390ce4a-405d-4c1c-b835-5db66bd96bb6"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7236), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("03010dc8-bb27-4dbd-8f13-2cfdffe100df"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7241), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("10b32608-fb67-4094-9fe6-125957e5bb43"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6851), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("68c79998-3332-45b6-ba2d-9eb9c0a2168a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6857), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3dc567db-a108-40c9-8c36-1d49b855f756"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6859), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("06dc2345-a591-4dbd-8b3b-1084820f471d"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6866), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5bb58d96-7420-4ad0-a6e6-ccd9c7978b55"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6868), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("57a5f47f-7752-48ac-b84b-d8450cb574ec"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6872), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e1657dab-0d1e-4da5-bc25-fbca44dd84da"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6875), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("29434c51-2529-4f7a-b0f6-a9b34448eeae"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6880), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c5e3e443-7034-4052-99af-61eabbbe7824"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6882), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f446ce70-e85d-41d7-b424-c7c310444bdc"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6885), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cf4decfe-66a4-4407-9ebe-c2541a84513c"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6888), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("24b54c67-00d8-47eb-8248-c2a7ab80d932"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6892), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("faaed21c-8ea1-45a6-95ee-4f2b83a59c7f"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6895), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("582f3992-d6fd-4da5-aa17-041c7e65e6b8"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6897), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bd056bbf-6150-43de-a282-ef7f3c64c49e"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6900), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6fd8bee3-ec2e-4bfc-88cd-394b3572d42a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6904), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a3b9ab00-452e-4d5e-b5a0-61d7545d7996"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6907), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0234938e-3a3e-42bf-b4c7-7ed93de2aec0"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6910), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1d6c83fd-8e2f-491c-b0d8-e06032088101"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6912), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bf79e660-bd49-48de-a6ac-771febe04d4b"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6917), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7034da2a-2318-4677-bdef-23b392ebaba8"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6919), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("858d7135-43f3-4c19-a4fc-9969951d931d"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6922), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("24b89c45-9fba-4e1c-a3ec-44d1fe07f838"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6924), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0d4a698a-4f25-4302-a619-9e9eb86870e7"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6929), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6e71db85-ce61-4ec3-8c8d-ff9ed824d73e"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6931), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("35699fd9-0804-4c2f-946f-e6196239d2c6"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6934), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c0852fa2-80c6-4740-92fe-81d0a286d9ce"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6936), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("90247128-0904-4267-93b3-f713e75c2569"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6942), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2e145216-c24f-492a-9c93-9d330f46ec66"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6944), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bd395746-7653-43cf-a8df-4bb2050570fa"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6946), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8a028ffc-1cc0-4690-b24b-0fc06d72e26e"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6949), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("58a94df2-b848-4303-80c5-4b026b73bee6"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6953), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cc0aa1ac-a86f-42e1-b4ae-fdfeb2378b98"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6956), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e5b6062e-bca5-4c73-a072-9aecfbb909d8"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6959), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0df21fcf-6a93-42ce-b099-c9a0dbf2a624"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6961), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f3bdbe6e-5734-46b0-8189-9b756d3e4d4d"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6966), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fdb63666-b78a-4f88-9cd4-a6f827cb87ba"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6968), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0a4c1b03-6cc3-4805-b587-b88dc4620570"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6971), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("767effd8-8691-4745-9874-b59df8903722"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6973), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d1d5bf84-3e8e-412d-8ffd-bbd1ed6e6903"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7024), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("823c96c4-0ef6-42df-aba0-4dfe180c0648"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7027), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c36ccbc5-7a4c-407e-8c8d-35c4872df504"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7030), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6827e155-4ed1-4054-94e8-3b20ebd8b6d3"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7032), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("12667938-2be1-4044-9347-76d663fccf3d"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7037), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("049c35f0-87ce-428a-8515-7fd78fbf2210"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7040), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("142d77bf-162a-41c2-9219-0b9fec0a03d2"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7042), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("679b7949-fe10-4f39-80b6-9d16e3ed7ca2"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7044), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("287d3ad7-a9a6-4e3e-9b90-6596dffb2deb"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7049), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fcf8c0a2-3821-4efb-95af-5ae818bf2868"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7053), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("770e91d4-659e-4c8c-baf0-f6eccd3b9130"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7055), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("531c756a-57c6-4ec4-8251-63db6fc1f055"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7058), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a0565146-ab1e-4a8e-a8f3-b2481cf667f2"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7063), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b28eabb5-d0b2-498a-989c-a03bae3dc83c"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7065), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5a0cffe6-7182-4a08-ac02-3874c237e1a9"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7067), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e23c56b8-2228-4209-8c39-0b277b298db2"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7070), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8a8e5e23-a28d-4ddf-af8e-6771b66496e9"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7074), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("be7f57cf-094f-4962-b9a6-da1b01e3c474"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7077), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9f73855f-3a01-4a7e-87c2-7935874b92f9"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7079), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d4142d4c-664a-4e56-82e0-74aea238f3df"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7082), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2d33dbb0-5506-4c11-a95f-7bc94f10bbd6"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7314), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a79ada2d-9e70-4888-bb43-8deea350fae3"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7319), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9528f253-3e54-44ee-9927-49356f63ec2c"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7321), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1324480e-a4df-4f2b-8b09-8ccb4786c893"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7327), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("50973ad8-29d5-4c43-b8bb-60d522132bbf"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7329), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d3cb03a7-49c8-4234-9451-238d76727607"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7441), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("914afd05-7c52-4835-9cc6-2982659ed8d1"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(8037), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(8038), new byte[] { 226, 64, 126, 14, 171, 205, 55, 55, 148, 245, 19, 201, 117, 73, 223, 52, 137, 24, 197, 52, 110, 2, 233, 25, 136, 202, 70, 171, 103, 223, 164, 118, 17, 102, 24, 74, 119, 154, 247, 34, 149, 200, 31, 4, 117, 186, 135, 29, 173, 140, 125, 126, 101, 22, 229, 32, 188, 70, 190, 146, 197, 141, 130, 12 }, new byte[] { 38, 173, 190, 86, 75, 221, 163, 110, 201, 118, 221, 65, 67, 74, 247, 161, 12, 26, 138, 163, 89, 228, 108, 249, 140, 6, 210, 232, 207, 226, 49, 41, 57, 214, 39, 69, 42, 208, 13, 192, 52, 11, 37, 97, 167, 185, 232, 144, 100, 80, 40, 207, 122, 103, 136, 214, 109, 180, 171, 55, 48, 77, 111, 7, 190, 147, 231, 158, 99, 165, 57, 113, 154, 94, 57, 63, 214, 172, 123, 25, 111, 231, 146, 153, 107, 146, 55, 41, 49, 119, 36, 159, 143, 66, 198, 4, 234, 70, 243, 232, 114, 60, 4, 11, 56, 6, 26, 129, 64, 139, 32, 210, 223, 196, 36, 157, 156, 95, 133, 98, 190, 159, 207, 16, 143, 208, 44, 203 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("3bf233fb-7136-4991-a220-01874f060c1c"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(8146), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(8147), new byte[] { 99, 203, 141, 13, 208, 111, 73, 109, 168, 91, 123, 191, 88, 174, 42, 106, 89, 19, 16, 160, 97, 68, 108, 225, 43, 74, 45, 173, 4, 86, 185, 179, 185, 21, 13, 129, 1, 77, 45, 108, 67, 54, 146, 133, 121, 242, 156, 252, 132, 178, 136, 83, 147, 110, 128, 244, 51, 59, 247, 250, 26, 74, 19, 1 }, new byte[] { 70, 221, 110, 76, 246, 60, 32, 50, 212, 132, 163, 98, 12, 228, 7, 23, 147, 61, 197, 197, 79, 6, 216, 216, 209, 151, 211, 154, 169, 221, 3, 149, 44, 225, 31, 122, 87, 85, 67, 234, 71, 41, 128, 22, 230, 219, 187, 168, 117, 54, 39, 144, 213, 96, 143, 231, 227, 58, 233, 181, 249, 252, 122, 119, 106, 34, 141, 208, 111, 198, 100, 112, 131, 36, 34, 90, 68, 11, 198, 175, 83, 79, 121, 108, 77, 236, 241, 3, 94, 79, 179, 228, 86, 214, 189, 102, 133, 215, 148, 229, 192, 72, 48, 102, 229, 198, 155, 25, 60, 126, 137, 178, 49, 37, 50, 159, 104, 12, 50, 193, 62, 79, 119, 23, 17, 6, 228, 156 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("6b4d0d01-3545-4f4f-b2e0-922c43318a83"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(8242), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(8242), new byte[] { 70, 51, 153, 190, 125, 196, 221, 103, 185, 210, 46, 102, 156, 168, 46, 150, 172, 89, 244, 245, 107, 71, 64, 119, 224, 176, 142, 214, 230, 94, 50, 82, 91, 205, 223, 182, 232, 69, 201, 24, 226, 211, 20, 235, 38, 87, 212, 20, 183, 8, 49, 23, 92, 81, 53, 216, 158, 73, 180, 237, 191, 173, 249, 75 }, new byte[] { 136, 68, 34, 141, 53, 25, 254, 241, 101, 210, 8, 190, 143, 130, 8, 41, 227, 69, 58, 240, 67, 173, 113, 20, 60, 100, 80, 67, 121, 83, 213, 192, 174, 234, 163, 250, 208, 66, 74, 141, 107, 190, 237, 197, 191, 160, 127, 143, 24, 254, 105, 120, 230, 221, 236, 143, 114, 205, 116, 121, 214, 107, 118, 70, 85, 163, 182, 230, 7, 129, 129, 171, 32, 179, 22, 137, 61, 158, 2, 28, 48, 10, 240, 51, 228, 242, 247, 147, 95, 115, 7, 135, 125, 113, 109, 155, 229, 203, 202, 15, 67, 100, 86, 200, 203, 6, 6, 162, 235, 25, 130, 178, 136, 70, 158, 40, 60, 126, 230, 245, 78, 87, 20, 26, 191, 84, 121, 169 } });

            migrationBuilder.InsertData(
                table: "RFranchiseModel",
                columns: new[] { "FranchiseId", "ModelId" },
                values: new object[] { 3, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RFranchiseModel",
                keyColumns: new[] { "FranchiseId", "ModelId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "04/30/2024 16:38:53",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/12/2024 16:37:51");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("238ba5e2-1887-427c-9a0b-8987fa768918"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6159), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2c9af4b0-31b6-4d18-8e56-8a96d54f8c77"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6171), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("48302494-e95f-4a2d-acaf-bb3c704a93a9"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6175), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0c12ebaa-75b1-447b-9a67-6e8bbebd4bdf"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6198), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("35b60bf7-88f5-43ea-9eeb-76cb8e3319f1"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6201), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("91eafc9b-5c74-4dc8-8b96-d44d02ef10cd"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6206), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8b3e2ef8-2de9-4350-a6e0-fa49313d9f4b"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6208), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5cb6b40e-1df5-4f4c-8153-4fd6862dc47c"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6214), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0cff1b8e-1212-4750-b04e-47e4f1a7b31b"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6217), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("08be7449-b335-4f71-a641-ea14b49e3d6c"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6221), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("77642c29-ac64-4ed2-b832-bcd56215dcee"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6224), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9be31343-88af-4d15-bfd7-07fb3fef59a4"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6230), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3068c503-0994-45ee-bd1d-cb05aea69dc3"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6232), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("44e23d0c-c4b2-45c7-bb1f-dd96841fc5ac"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6235), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("63ee6597-c52f-4058-ac24-9e7624d8e65d"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6249), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6c0d61ba-0d05-46a0-9963-d0c755ca00c6"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6261), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f5a16caf-c5c0-4115-9194-e3a55b051004"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6264), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8be1eb0b-f888-4d5e-814e-78bba69c5892"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6268), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("16d5229a-8c90-448c-969e-b78905217b83"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6271), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("eda0b42f-30c0-45b7-b674-5df445fe9f41"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6276), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0f7e0886-7d4b-43cf-934a-13e45af91f3f"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6279), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6279) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("66dd13a7-add6-44fb-9d42-400bd4313c56"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6281), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("29bdb889-927c-460e-a9c4-593f352c21eb"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6284), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1ff54f5a-4d79-4b0b-8d6a-d916cd94f89c"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7060), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dd8d66e1-061a-4f12-a891-ad4d993715df"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7068), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8e98ba8d-f649-40b2-8464-5642889954f0"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7851), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4031da97-b3e8-4ba0-8433-e02441cf23aa"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7856), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c356448c-bea5-40f9-8814-e27ee1640bbb"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7859), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8af70f41-4129-4d1c-bfd4-d1b1ac361102"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7862), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("df1a1930-a069-427f-ae22-2dc6fc1c2f43"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7868), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bf21d211-e5f7-41b8-9bf1-4f6869a48369"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7871), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("82da9195-00d7-43be-90b3-703d94220108"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7873), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a9860e4b-b852-46e9-810f-75379c84a661"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7876), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("37790adf-9747-4f00-8eb9-3ff37f5409ad"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7880), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a151e43c-212d-43ff-b5bb-4ce97cc4ad9a"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7884), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f744c402-d461-4bf0-b0dd-8f8a35e9151f"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7886), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("36c7c12b-7674-4bfa-aadd-3f99f5dce4ca"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7888), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b7ac1f2a-f8d2-4cc4-b497-6e4ee8c71cbd"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7893), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a8721cc2-3405-4ccc-8ffe-a5ea48257285"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7895), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b28f92cb-3e54-4fb0-ac16-c010d1c142fd"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7897), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ac41f78c-964d-44ad-bd74-0f7d53f02a55"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7519), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e482862a-0de2-4692-a274-9a5b04dbd0ed"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7524), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c4202936-22dd-45d0-be87-e2a855bf55b7"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7527), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("140d9469-7f21-4b27-b040-01d694dab266"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7533), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("afc994db-3f84-47d2-948c-43aad870d3b2"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7535), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3318228d-56b1-4ce7-a5ce-7dc586c85acb"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7539), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6df3ba41-f20c-4f47-a97c-0bf74bfd0602"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7542), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6af89790-a3de-45d9-8025-58442c273aba"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7547), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("930b1ada-1a24-4471-b97c-9632ffff8498"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7549), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6eac8e29-6aac-4b81-97f3-cac1c4fc557b"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7553), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ff5fb38a-2f73-4959-bcbe-9b9c10be68a4"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7555), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3c9d9775-34f3-4bc4-85c4-ead2abf3718a"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7560), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8c150f3b-1f16-472a-b0c6-dd7270ce2a54"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7562), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4267dfe1-5d12-4b87-ad14-cafc848dfd96"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7681), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5f467a18-8551-4bcb-bec0-f09ed526f742"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7685), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("018ef7f3-8fcd-4470-9d47-3e480fd0d682"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7691), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("74715159-9069-4c32-a07b-42efad6cd8af"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7693), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d5616ed0-68a7-4948-baba-436ebc16a248"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7698), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1f2a70d6-7e27-4271-a806-bad9e0b23761"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7701), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c4a0e947-8aa8-4726-8bf5-31541cec8e23"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7706), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b1bcf762-2d90-4ee4-b399-ca1cec04985e"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7708), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("49e89abd-7298-402b-a095-e761a23eab05"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7710), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7011d05e-a9cd-4c4a-befd-8786cab1e6ea"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7713), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3ffaabc7-8634-4893-9b43-533a9906e729"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7718), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5d7e06d6-75b5-4103-8bfc-8cd5d99b016e"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7720), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1fcccd82-f6e5-496b-84cb-a119feba714b"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7723), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("05de15d8-931f-4de4-9e05-d8e10b7df7ca"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7725), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("36bf6001-8ad2-44e4-a6bc-01655a6564b5"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7730), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1cc8289e-924e-41e6-8da7-e18d0554f9a8"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7732), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c66e0945-c6a0-44c7-b6e5-a9392c1282fd"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7735), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c08b25c9-337d-42cf-a2ca-08fc1af9a2b6"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7737), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bafb49d1-da34-42d5-a5e3-5f4b8bd5318d"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7188), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3a17fc51-bc84-4d8e-be5f-bc7898f2b904"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7195), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("844728bd-8c04-4c17-b89b-a56976dc8002"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7198), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("47d095f9-5647-47bf-bc5c-0a67568d12d7"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7200), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("93f71c15-6476-47b4-a8fa-fb53d6a63106"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7206), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("88a9b80e-657c-4bd5-91ea-ac7d38f75aa8"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7212), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e903bc06-47fd-4742-b6d6-445e5e4be96a"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7215), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("826fd663-dbc0-4288-a167-6b63b216ade2"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7217), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("810e894c-9b5c-4c71-8461-a3ff73c721b4"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7222), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("83abf3a0-fbdb-4da1-b7b8-cd4133b83a54"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8167), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "Pseudonym" },
                values: new object[] { new Guid("a1ab384d-b9b0-4eac-ba4d-935c2c162381"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8177), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8177), "/ Unrelated Model" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e2160379-702e-49dc-88d9-d404e07d0c13"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8180), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8250), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8266), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8271), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8280), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8286), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8292), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8295), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8298), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8301), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8305), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8308), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8313), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8316), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8319), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8322), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8326), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8329), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8333), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8336), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8342), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8345), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8349), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8352), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8451), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8519), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c49ea46a-ad2e-4b90-9bf2-e48bb5ae11f9"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6578), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("84a886b3-bd34-4dce-9318-9c9906b274cf"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6585), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0ba166cd-2e8c-4cd8-832e-c29e73e25a19"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6588), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2352afd4-86f7-444e-a567-41896afb5821"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6635), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("127a795e-7a9a-493c-80b6-00a4faae75d4"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6643), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("65849a20-36b0-4f53-a0f4-f2ac01314511"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6648), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d1172649-3f84-4679-9c5a-d23b0cb32359"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6651), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dfa0f128-46c9-4fd2-8703-ad0ba1c71660"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6653), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7a867a4c-b2de-4d83-8e6b-6522438acee2"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6658), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a8c2f6ce-0e2a-4856-ab23-d124c9e15cc6"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6662), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c8807dca-7e59-450e-a568-46e1c22491ec"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9483), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4476fa42-28bd-4be5-8914-bcad1b218234"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9487), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cc111694-f683-42e3-b248-2be5220fa556"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9493), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("afbee7db-124d-4c53-a487-8e9c135e7378"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9496), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("84311f89-bbd7-4185-8b11-a7f302a109be"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9499), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9a904bce-9bd5-40cc-96e0-2674d76290b0"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9503), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b9469765-950b-49fc-92a4-f1eb033e6f9e"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9508), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9eff39b6-a320-4c50-8055-5055f4884beb"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9553), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("177ab84b-2d02-4096-a209-5a09978e80fc"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9555), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("05f2f700-92aa-4064-9268-25cffde445b4"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9559), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e49ea568-ff67-4000-95c2-6b63de94fd29"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9565), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ad75ca02-2e5f-4e47-8a5e-6a824481e64c"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9568), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f2eb8994-c8b5-4282-ac66-1ae2d4790924"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9570), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("07561d6d-84f1-44bc-a921-8363f73b5905"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9572), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5552b546-30a3-47f8-9359-e182757e6fdd"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9577), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b34a53d1-fad1-4500-b70e-5c2a0ef778da"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9580), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f71c7164-fe26-4b32-8d28-18c7aba4354d"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9582), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cc7a9a57-f83e-4963-aedd-cc0aeff6a79c"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9114), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bdfc90f2-4c20-499f-80e6-6d8c8eff115c"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9124), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e3ba890d-bfbc-4f9e-9fcd-3772f933be66"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9127), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3ad94217-13eb-4d85-aa7a-5e9f701a78ed"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9130), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bc059fe8-4c5a-4172-8c29-15660c00e0b2"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9132), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("344a4603-de54-4f3f-8107-d700270747b3"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9137), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6533e436-0789-4962-ae00-628cd37024ed"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9140), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("07d1e470-d204-4c44-a246-82a7401db210"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9142), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("88624a9a-64d7-4280-b089-80d378d43773"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9145), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8e12b29d-8b7e-4492-8dc5-f20d223fe8af"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9151), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8bd64f4e-5095-4a6d-a319-945d755f7abf"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9154), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("97c1e952-a782-4ab0-804e-8672a9f62106"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9156), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f8de9d2d-4680-4406-860e-dcc54a93c5c7"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9159), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("758fa8cd-3c21-4e61-8a94-b962062b9dd2"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9163), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e0f02d8f-2593-42d8-8cde-b786703be79c"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9208), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ac5f134f-de8f-42b1-9dc4-014f95dc6f88"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("05299acc-e4a0-4e31-b01c-f62ae17c89a4"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9214), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("50de37df-5dce-4eb4-b276-cf85bb8aed32"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9221), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6f624c1d-20b3-400e-ac6b-651e5ce4516d"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9224), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9f9cf2fb-e5fa-4096-9c7a-d8bcdc2cf89e"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9226), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0dd38b2f-7039-4c0a-b23a-6dd92ff186ce"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9229), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("93849aad-a843-46c3-b6e0-7850c91728f3"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9234), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7c2f0450-c8d9-4783-b931-85608f259d67"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9236), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ab16b318-6301-443c-8797-d704cf02f453"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9238), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fb12a00c-6843-4c0e-8cf3-bb2f98058c0c"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9241), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ff756c7c-dcd1-4f0f-8175-b99acfdd061f"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9245), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a3dd067a-d9eb-4578-a0e8-30e1cdc9b00b"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9248), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("eafd1844-d24a-4083-86da-50528572890b"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9250), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("918dd03f-aefb-4cc3-a26b-212fdebca6d2"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9252), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b32c9bca-2a3b-4689-b37d-2d69b4697503"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9257), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("10658728-b65b-4fad-a1cf-779e4130baaf"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9259), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c19d4624-6d6d-41ba-aed7-23383c9c5d32"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9262), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8b8027e8-846d-4a3a-ba86-b33f4ab9207c"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9264), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("65550dbd-030e-4169-b7d7-5024dd34c71f"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9270), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0e01dc0f-2085-498a-8f85-8efbd4466f6c"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9272), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1d886b8e-1423-4e0a-9417-bfbc5c4f16d1"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9275), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7bad02e6-029b-4168-8618-8ff5179f18eb"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9277), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("81ed8ab5-4a3f-4c53-8a74-999935888048"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9282), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ac6cbd4c-d6d3-4abf-aab4-59792e9928e7"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9285), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("573680ea-2bcc-4164-ad5f-2090f89d996b"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9287), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("31e9cb4b-570b-497d-885e-cc5733ea4e24"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9290), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b56a24b2-349c-480c-82c8-44554ea95e8d"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9294), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("91c2d23c-ad95-4c18-bfaa-c1204952e4f6"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9297), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("62d7df7c-e4a5-4b72-846f-8c6e6e51c130"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9299), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4f2b0e54-c47d-474d-9422-b4b8a2dbf864"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9301), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a15605cf-2519-41d4-bf14-b6f641032357"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9306), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b4b39f2b-ec68-44d5-ad03-69e5bbb4a165"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9308), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1f6b0913-aaf6-4d21-a056-999cbe1be5b3"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9311), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ae4e3b41-08af-4933-965b-8898e892a31b"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9313), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("65ea7050-c8fb-47a9-9973-cf8436b0e839"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9317), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("92d2c463-9996-45a1-8680-e7458d965077"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9320), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("833698c7-af2a-43b9-8d45-3e1636ecafd2"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9322), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("11b0258b-cd3f-4420-bbd1-8d811de44e47"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9325), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0d6f62a4-3abf-4aef-88a5-c7de3d1e237a"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9329), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0ad1f675-763c-4b79-af3e-7769247cc1e4"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9332), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b1bc343d-4833-47ec-a0aa-d26ff3ef0e95"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9334), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("951d1739-fcd2-43f6-8c3e-600a5bb9df6a"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9336), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("adbd1346-25de-40ee-b18c-8e3dcb37702a"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9341), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("361a71af-c596-4d76-9cfc-93ff66d7d8eb"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9343), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bc30e35d-4e04-4bd7-942c-5fd3da6d7ef5"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9684), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e920030e-abdc-4f3d-ac69-2857dfcfdb39"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9692), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4ff733ec-bcba-4b3a-b13b-a85ed723a788"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9694), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7f9a6e69-bee5-496f-9c1d-8da1adfa7b0b"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9697), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("91c8ff1f-3e11-4d58-9112-c3b5353c9a58"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9699), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("756a2fe6-00d0-4376-b961-5e723fba191e"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9776), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("6bf57c12-2ec4-49b1-bb72-0d1a4260c462"), new DateTime(2024, 4, 30, 14, 38, 53, 805, DateTimeKind.Utc).AddTicks(413), new DateTime(2024, 4, 30, 14, 38, 53, 805, DateTimeKind.Utc).AddTicks(413), new byte[] { 55, 70, 171, 25, 155, 11, 88, 217, 201, 36, 248, 47, 213, 208, 56, 24, 230, 7, 56, 6, 95, 5, 199, 166, 7, 215, 76, 124, 187, 190, 173, 160, 34, 37, 81, 27, 209, 209, 224, 158, 207, 18, 32, 153, 71, 163, 51, 228, 203, 28, 58, 106, 90, 50, 141, 96, 250, 22, 62, 98, 177, 25, 98, 160 }, new byte[] { 248, 37, 81, 242, 97, 245, 198, 241, 227, 141, 9, 64, 43, 210, 149, 13, 59, 82, 68, 88, 180, 130, 54, 173, 251, 149, 227, 86, 218, 218, 80, 113, 96, 251, 37, 70, 174, 44, 154, 147, 11, 254, 4, 125, 207, 174, 177, 190, 159, 202, 228, 160, 145, 168, 74, 178, 240, 223, 147, 101, 86, 234, 17, 206, 143, 218, 247, 73, 232, 202, 196, 159, 24, 30, 181, 159, 227, 67, 96, 43, 173, 44, 58, 79, 6, 254, 147, 122, 221, 64, 61, 117, 232, 123, 173, 162, 121, 82, 182, 82, 103, 172, 171, 62, 159, 223, 139, 230, 193, 163, 171, 98, 182, 207, 108, 71, 209, 167, 64, 109, 244, 190, 202, 36, 156, 176, 111, 88 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("5cca149f-c18f-4c2e-bf41-c1ef7faeca21"), new DateTime(2024, 4, 30, 14, 38, 53, 805, DateTimeKind.Utc).AddTicks(535), new DateTime(2024, 4, 30, 14, 38, 53, 805, DateTimeKind.Utc).AddTicks(536), new byte[] { 194, 55, 146, 109, 181, 184, 41, 40, 79, 16, 188, 170, 199, 111, 35, 28, 200, 154, 65, 151, 167, 200, 111, 74, 179, 89, 53, 229, 173, 79, 72, 150, 10, 49, 251, 164, 201, 240, 154, 67, 34, 94, 102, 64, 88, 246, 55, 113, 193, 175, 126, 152, 68, 66, 68, 63, 182, 73, 140, 179, 145, 166, 72, 93 }, new byte[] { 27, 54, 177, 242, 220, 227, 41, 251, 175, 43, 1, 83, 3, 90, 252, 156, 170, 148, 57, 22, 16, 74, 83, 113, 161, 237, 102, 250, 58, 82, 206, 118, 62, 163, 72, 200, 109, 45, 189, 83, 104, 69, 206, 71, 165, 139, 221, 122, 80, 218, 51, 146, 247, 195, 18, 203, 63, 89, 205, 135, 184, 250, 7, 67, 218, 231, 20, 8, 186, 89, 144, 113, 122, 220, 7, 99, 99, 221, 101, 29, 113, 115, 211, 86, 138, 15, 8, 217, 14, 242, 39, 182, 1, 106, 211, 124, 11, 195, 238, 138, 186, 211, 59, 198, 248, 173, 136, 47, 114, 13, 194, 158, 237, 138, 170, 192, 178, 18, 107, 1, 57, 78, 116, 43, 3, 58, 7, 143 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("6b4d964b-8967-4703-a800-33abe4de5e90"), new DateTime(2024, 4, 30, 14, 38, 53, 805, DateTimeKind.Utc).AddTicks(613), new DateTime(2024, 4, 30, 14, 38, 53, 805, DateTimeKind.Utc).AddTicks(614), new byte[] { 108, 61, 231, 92, 136, 3, 94, 71, 20, 238, 146, 63, 233, 119, 43, 39, 203, 195, 229, 37, 247, 125, 152, 110, 49, 71, 62, 192, 170, 243, 215, 198, 135, 73, 104, 71, 71, 17, 128, 165, 45, 74, 202, 28, 21, 221, 38, 232, 9, 206, 48, 47, 68, 75, 117, 65, 250, 227, 163, 42, 93, 165, 128, 26 }, new byte[] { 117, 190, 230, 100, 215, 134, 167, 250, 28, 213, 178, 203, 70, 65, 212, 178, 31, 124, 163, 51, 12, 9, 77, 147, 134, 138, 65, 221, 239, 238, 215, 171, 88, 206, 133, 18, 162, 90, 41, 188, 248, 35, 32, 61, 9, 90, 223, 28, 47, 153, 108, 230, 133, 34, 111, 173, 73, 95, 249, 50, 58, 72, 202, 207, 86, 59, 230, 219, 154, 252, 244, 57, 143, 62, 140, 96, 163, 0, 23, 13, 158, 59, 232, 40, 48, 208, 191, 226, 59, 34, 132, 149, 108, 16, 149, 63, 35, 3, 33, 186, 154, 14, 238, 192, 237, 249, 128, 244, 155, 235, 189, 7, 129, 242, 6, 46, 30, 232, 155, 255, 45, 176, 4, 143, 247, 167, 90, 189 } });
        }
    }
}

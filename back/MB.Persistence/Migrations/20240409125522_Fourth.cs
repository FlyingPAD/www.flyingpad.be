using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MB.Persistence.Migrations;

/// <inheritdoc />
public partial class Fourth : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData(
            table: "RFranchiseMedia",
            keyColumns: new[] { "FranchiseId", "MediaId" },
            keyValues: new object[] { 1, 1 });

        migrationBuilder.DeleteData(
            table: "RFranchiseMedia",
            keyColumns: new[] { "FranchiseId", "MediaId" },
            keyValues: new object[] { 2, 1 });

        migrationBuilder.AlterColumn<string>(
            name: "Name",
            table: "Tasks",
            type: "nvarchar(50)",
            maxLength: 50,
            nullable: false,
            defaultValue: "04/09/2024 14:55:21",
            oldClrType: typeof(string),
            oldType: "nvarchar(50)",
            oldMaxLength: 50,
            oldDefaultValue: "04/06/2024 13:31:29");

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("75d46add-07b7-4b83-abee-ca35ab6e75c8"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8214), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8216) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("07d442ba-fcfd-4eae-a9b6-c60346f46bb6"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8223), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8224) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d5021186-7119-45ae-bc9e-16b213a91bb7"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8233), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8233) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("123c9ff4-72cf-43e7-afaf-81e519619440"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8235), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8236) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d154b420-bf20-4b04-b0e7-c995bd8348c3"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8237), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8238) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4f0eee6d-5c31-4bd9-a054-29d0b24fac70"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8241), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8241) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("fce29fbc-6e4b-4078-aed4-e9fd789b88db"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8244), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8245) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8a744220-3731-432f-846d-609f2b26434f"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8246), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8246) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a38b8f71-01db-4c00-90f3-8956554910f1"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8248), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8248) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0c238225-5264-4e2f-ab53-f967db5f0ba6"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8250), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8250) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("46bd5b20-b253-463e-8031-f8eff490ac2a"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8253), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8253) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d5079614-f5c7-48d5-9ace-80d7ad82e299"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8255), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8255) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("fd2f9e92-1c76-47a6-8f66-6128bc3c3a3d"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8257), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8257) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0396c81a-4c97-4d1a-aa52-a1ec7ba8e1aa"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8258), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8258) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c7df0bc2-c9c6-4c3c-9f19-cc335b79149f"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8261), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8262) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0455fd6e-3a8c-4c55-a582-fb5cdae75ce6"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8263), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8263) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("7b3e5295-53d2-4372-bb57-65b2105c0f6e"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8265), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8265) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 18,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("983a0aa4-a309-4f7d-97e7-93fe786c2468"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8267), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8268) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 19,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("925403f2-0b51-4962-924b-04fdf99c7cf7"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8270), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8271) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 20,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a199c15d-aa14-4893-b45b-744197d61dd6"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8272), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8272) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 21,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ef0b4635-a96a-4d3f-b4c1-b16ea97ee3ee"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8274), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8274) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 22,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a1df4c82-543e-4d2d-8e65-74de96117bf4"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8276), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8276) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 23,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("53d9cf61-276f-41cd-a5a9-4898bb8aa198"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8279), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8279) });

        migrationBuilder.UpdateData(
            table: "Franchises",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b48c2434-d90e-452e-ac77-86c86aaaab81"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8516), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8516) });

        migrationBuilder.UpdateData(
            table: "Franchises",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0be700d5-0718-49c3-b723-bcbbaa959e21"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8523), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8524) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3710833a-f0db-4c08-95b5-4216d1293664"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8865), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8866) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9b759cd9-9e52-4f72-93cd-6ed4b2d4b5da"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8872), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8872) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4461c6e3-db79-4661-b890-37cba1d6ca1e"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8874), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8874) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e886835d-ce70-407a-88d2-955fd72bccb3"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8878), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8878) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("96ecba2c-1fb5-44fe-8c7e-5762804660ea"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8880), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8881) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3f5f1097-d1d8-4abe-b7be-74146fbe705b"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8884), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8884) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("508661c3-bac1-4fe8-a24d-8857be1e6b78"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8886), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8886) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c73323ff-7d53-426e-b29c-fc823bfa47ca"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8890), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8890) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d106942b-4d2f-419b-8d33-0f30db1c2346"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8892), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8892) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("39cd1a15-0162-4b4c-829b-0539a915330e"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8895), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8895) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b6055549-a4b0-4913-b157-186aa6cf6f82"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8897), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8897) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b13bf468-970b-420b-82a5-baf2a32664d4"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8901), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8901) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8e4b16af-c50a-4ff7-8f59-6e7c68594f51"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8904), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8904) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6d953d5c-a836-4021-bc67-fcfaa5d4e22e"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8907), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8907) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("89767ffb-36ca-46e4-8c85-5fdcab6d06b9"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8909), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8909) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b1ba0a83-cda0-4e5a-afa0-d8f9b020a6d2"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8673), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8674) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3d9f68ae-a829-4408-bf3f-200182bd60e8"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8681), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8682) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("af336891-ffef-4722-8721-4abf6d8be134"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8687) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("85c76af1-21a3-43e3-b4d0-847110a79f42"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8690), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8690) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("00483056-6981-47a0-b47e-e5abc895cf78"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8693), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8693) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6171fdac-1dbb-404d-8506-d63b38ead4a4"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8696), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8697) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8497942f-8140-4b63-91a9-81f8d9dc0ddc"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8701), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8701) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("96fe5003-70cc-4fba-9943-763f568270b2"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8703), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8704) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("201eae66-b687-49e1-8d77-313c61037721"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8706), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8706) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3dfd95aa-95f3-45af-a790-15b71eccc13b"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8709), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8709) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ebe28bd1-709c-40e7-87d8-28ffa1007576"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8713), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8714) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ce14f831-86cd-4aaa-8b2f-bcaf91afe79d"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8715), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8716) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3779c480-e5af-4d42-b59c-af4f98e6ec2a"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8718), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8718) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("46d90171-e743-4746-be46-8c809f554dcc"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8720), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8721) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("2a0421ce-0447-445a-9705-9e5ad7747489"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8724), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8725) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("54e24703-c174-41ff-a8a2-1a5f17e2b92d"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8727), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8727) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("db6d1217-8bd4-4e15-9c02-ef2130d99f7e"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8729), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8729) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 18,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("7bb5b89a-5a00-464b-a6c9-5517e31c2d41"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8765), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8766) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 19,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("138beda3-9e33-44fd-ad87-d640193ab5bf"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8770), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8770) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 20,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("894c2b83-7e1b-445e-b9e1-9021dc205935"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8772), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8773) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 21,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f17695fa-1226-4890-b7da-5e73c977ed07"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8775), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8775) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 22,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6c206636-dbae-4f88-8f07-e5f726044619"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8777), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8777) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 23,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4028a28c-2516-4f8a-9cae-96ba1f4c00c6"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8783), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8783) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 24,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9e275ccb-5e6b-4608-bc5c-5e9898b0ec5a"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8785), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8786) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 25,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("21e00bdf-659d-4b58-8369-0913ce720c25"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8788), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8788) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 26,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b2fe64e0-5a1c-4ef3-89b7-7efa332d4aec"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8790), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8791) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 27,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("add096f6-be28-4df8-9920-2acc2b29a120"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8794), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8795) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 28,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d09c1f38-9435-4ddf-bd84-df1102819e3f"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8797), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8797) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 29,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("58152ed2-cea7-4189-bf9a-948b66e6ec6a"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8799), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8799) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 30,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f62eac67-34c2-4c04-945d-ea14a3709881"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8801), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8801) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 31,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0ea4782f-fd4a-497f-9027-ba1ff7afe106"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8805), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8806) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified", "Name" },
            values: new object[] { new Guid("21d91dd8-90d5-4e37-a933-6f49eadeeca8"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8548), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8548), "# Unrelated" });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified", "Name" },
            values: new object[] { new Guid("cef75850-e136-4d11-be17-d1841b6bed87"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8552), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8552), "# Unknown" });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified", "Name" },
            values: new object[] { new Guid("a60b7c9b-7570-4cb0-b672-cb051525c26d"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8554), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8554), "# Super Franchise" });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified", "Name" },
            values: new object[] { new Guid("475c34e0-07f9-4e95-9640-2789f656c8c3"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8557), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8558), "TV" });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified", "Name" },
            values: new object[] { new Guid("451b6901-4e56-4f4e-be26-5fbcd7f70f31"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8559), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8559), "Radio" });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified", "Name" },
            values: new object[] { new Guid("018335f6-aeb1-4c1b-a041-3801ac48a484"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8562), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8562), "YouTube" });

        migrationBuilder.InsertData(
            table: "Medias",
            columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
            values: new object[,]
            {
                { 7, new Guid("3052e44a-64b6-4c20-9ce3-a43c2b320881"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8563), "", "", new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8564), "", "Capcom" },
                { 8, new Guid("d5013281-0e9f-4eca-9665-681b111e9044"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8567), "", "", new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8567), "", "Square-Enix" },
                { 9, new Guid("3e2a6b5d-92ec-4553-9962-24f3a1f158a0"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8569), "", "", new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8569), "", "Flying PAD" }
            });

        migrationBuilder.UpdateData(
            table: "Models",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9746dc52-86d0-4e9f-89e1-b6984595a082"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9067), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9068) });

        migrationBuilder.UpdateData(
            table: "Models",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5bc73ccf-4e01-4e1b-9a61-38faea4c4886"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9075), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9076) });

        migrationBuilder.UpdateData(
            table: "Models",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3fa019f2-94bd-44c4-b61e-ef00ebfc73d6"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9078), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9078) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9112), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9112) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9138), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9138) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9146), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9146) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9150), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9150) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9153), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9153) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9157), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9157) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9159), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9160) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9162), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9162) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9167), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9167) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9172), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9172) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9181), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9181) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9184), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9184) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9186), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9187) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9189), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9190) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9192), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9193) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9195), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9196) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9198), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9198) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 18,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9202), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9202) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 19,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9207), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9208) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 20,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9210) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 21,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9214), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9215) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 22,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9217), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9218) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 23,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9220), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9220) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 55,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9282), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9282) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 85,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9321), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9321) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e60bebbd-7b7d-45ac-a886-96cea90e2354"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8391), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8392) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("52231342-0e7f-4927-b9be-9e7d5fe50e4b"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8397), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8397) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("cad5e9ea-e19e-4a18-96a5-4d7152e12992"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8399), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8399) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a7e52799-3dff-4de3-a747-357034b4e05b"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8404), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8404) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c97497cd-f310-485e-a2ad-3f0169921ac6"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8406), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8406) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5f324f98-0254-4df7-9a82-1e6e90601410"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8408), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8409) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ff459a69-379b-4bb8-a960-526bac2e4336"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8410), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8411) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("7d2e7f5d-7479-436e-a99b-3a7e1addad38"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8439), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8439) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e1c8c5cc-0ccf-4cfc-9658-ddeab69ff121"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8441), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8441) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("702033e9-b499-4ea3-96ed-a3f3742e66b3"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8444), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8444) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("fe4d2fa7-aa43-4ab2-98db-3788151a27bc"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9883), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9883) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4479628f-ada0-4fd3-b60a-59406a3c79d6"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9887), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9887) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("7a935ec5-b9d0-4ce5-9139-d6dd99573a61"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9891), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9891) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("efb32cce-b8fc-441d-bbe9-fde8c9df2821"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9893), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9893) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("502e111d-bd8f-401e-8714-60c92f9fde66"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9894), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9895) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c8b4a147-06a7-4555-a9ed-097cfd905a66"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9897), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9897) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1495468a-1f6a-4af0-9899-25bc755cffe7"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9900), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9901) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6d56d926-a4a2-4b0b-bca0-d2738472a208"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9902), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9902) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("77222e70-5baf-461f-92b3-d65428ed047a"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9904), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9904) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("21544c3f-cd21-4f11-b369-af5fc86148ed"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9906), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9907) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("bfa8de3b-35bf-4c54-be4c-997c035d6182"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9933), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9933) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("592ac1f8-d542-47b2-9e2b-64d798ffcf82"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9935), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9936) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("acc9a6da-dbe2-4af9-83fc-b6e0bd877f97"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9937), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9938) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6d91747e-b057-4968-a587-d9b4886fd267"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9939), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9940) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a8b1aed7-3e22-4e2c-99f0-8f463e89ae6f"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9944), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9944) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b9703c78-b063-4c0c-b220-7413655e113b"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9946), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9946) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("93b6ff2d-ce21-4d97-98c3-9d2066d6c6db"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9948), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9948) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("93ee90eb-362c-446a-b156-55144e036087"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9665), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9665) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f2ae020f-9c56-4d9e-b814-c74e8db52904"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9671), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9672) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9038a1a3-2c29-406a-8551-19063c4f34c3"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9674), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9674) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("2f89d1cd-91e7-45a2-8c82-3d0775b8502c"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9675), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9676) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("35bbc49c-9f8a-4d94-b27a-376d886931be"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9677), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9677) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("35d517ec-0e9a-4155-a51d-5886672f8087"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9681), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9682) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("917e7621-0429-4b06-b1cf-f9792d232c96"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9683), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9684) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a18fa975-1e20-404c-b988-dedf3a11685c"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9685), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9685) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("56d14ff4-b207-46da-b069-ee459f629413"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9687), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9687) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("530022fe-c75c-499c-9838-fb481e2fe327"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9691), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9691) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d04eb623-9ef2-4c6f-9c4b-ebd2702c584e"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9693), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9693) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("46833c45-8dac-4c1c-afc9-3dd18e8050b5"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9695), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9695) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("94bc239b-a54d-4f49-8ac6-384826249b1c"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9697), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9697) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5ace4ad8-3728-415f-979c-7bc3643d9172"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9700), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9700) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("32240f18-6b36-420c-b5d7-bb0b5581b501"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9702), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9702) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4a1d40db-05de-46ad-8d69-7d243e6c2958"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9703), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9704) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1e026a79-5670-4fb3-af5e-23c286be8436"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9705), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9706) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 18,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e7379c4e-d6b7-4fee-a9ad-812da69b9cea"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9735), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9735) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 19,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f138bbf8-a052-412c-b522-6b8bb6c9563c"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9737), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9737) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 20,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("574aa8cd-2615-4572-b4b2-594f1f8f8858"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9739), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9739) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 21,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0c246e9a-f4c0-4861-82d4-ee2a5a4743cf"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9741), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9741) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 22,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("064856bb-fd54-4b97-988a-402b1cd0131f"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9744), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9744) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 23,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ca077f83-bb9f-4eb2-9727-7cb35b28fb76"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9746), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9746) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 24,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4ad2f488-0e84-4f25-adb7-d49b9fe03bc5"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9747), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9748) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 25,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("efb88d74-ccee-4601-9327-d9709e9c2d19"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9751), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9751) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 26,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ffc9962d-1168-4ce0-a892-7861015440c1"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9754), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9754) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 27,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("505f6ac7-6c0a-43e6-a49e-6a5ece4a1d83"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9756), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9756) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 28,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("44d0e8d0-37dc-4e9c-a9e2-964b7ca2be69"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9757), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9758) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 29,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("51230685-de5d-47c2-8037-0c7760a5d117"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9759), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9759) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 30,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("aadccf3a-f8ae-4d7f-8995-39286a1aba55"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9763), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9763) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 31,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("95ae2acf-69c6-42c2-b7c4-59d4bc3eb9f5"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9765), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9765) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 32,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("958c2b0f-6288-455f-9b3b-dcaee77267bd"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9767), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9767) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 33,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0d0980c1-6734-4678-93bd-c84e6246e4e4"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9768), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9769) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 34,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a7153a4f-52d4-47e3-8186-7dff1fa1e076"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9773), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9773) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 35,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ebcd3a86-8a47-4b93-bd7a-5429ae336be7"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9774), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9775) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 36,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4423dccc-aa7d-487d-b585-e43cdc2a75ab"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9776), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9776) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 37,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("08ec107c-c9ec-4526-bbff-6dd66d401229"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9778), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9778) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 38,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("fbe866ec-3a03-49b2-8d59-929558ad5fcb"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9781), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9781) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 39,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("94e41be2-39f0-4220-86f5-ee2bbe74a6a7"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9783), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9783) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 40,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4b5c7064-ba41-43eb-95f1-1dee07f0210c"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9785), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9785) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 41,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0b7ed9a0-9d92-44c6-8ebd-9377bc33ca84"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9787), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9787) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 42,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("2390fcda-5fc3-4c7d-964e-152e877f596c"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9790), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9790) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 43,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e13262bc-6538-47a4-8749-e3462078c271"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9793), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9793) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 44,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f46c64cd-ac45-4f94-af76-79aaf8046078"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9795), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9795) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 45,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("59cd0069-26bb-4cfa-ab4c-a6e9a00272d3"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9797), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9797) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 46,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5f332b61-f8b6-496c-8c3d-63da0c09e90b"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9800), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9801) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 47,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6c89f4b6-fe5a-4b57-ae42-0bf097e43aec"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9802), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9802) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 48,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ddef18ad-0013-418c-ab29-e7abd3401084"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9804), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9804) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 49,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9b602702-b6fa-4d9a-b050-aeba17ce9a63"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9806), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9806) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 50,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("452229a9-3adb-43c9-897f-7c17b4fa6910"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9809), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9809) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 51,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a878cd88-5548-499c-bf04-36be0ae8e457"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9811), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9811) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 52,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0f8d5ccb-4439-49ae-9587-015ec5857042"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9812), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9813) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 53,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("33d8ece9-cba0-42d3-a291-265295e99772"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9814), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9815) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 54,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3c4d592d-91c5-40f3-83d2-3ea31a49c187"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9818), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9818) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 55,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0ed2c5df-8b61-4fa8-8a58-202b9846a7ac"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9819), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9820) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 56,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0d0baed2-3160-405b-a905-22235bd4dac0"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9821), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9821) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 57,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("01308e9f-e8d6-4b36-963e-70417fbb876a"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9823), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9823) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 58,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f76dd298-a27f-4766-9d2e-55b1c3314a91"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9826), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9827) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 59,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("aef674a7-7eb0-430c-9236-5b946824e634"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9828), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9828) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f1ce8bf6-1afc-40b0-9a6e-236fb16d9e86"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9985), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9985) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("2c113b0e-09b5-4222-9ac6-d098482813aa"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9989), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9989) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("342e700f-538c-438f-964d-3277ed838d72"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9991), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9991) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3698886f-8c2e-4fca-b9e4-97708a0b1639"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9993), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9993) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("00528e5f-6598-4eb2-be13-4d161df26e46"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9995), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(9995) });

        migrationBuilder.UpdateData(
            table: "Tasks",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ca4d904b-aaae-4ff8-aff2-646de39e8fd7"), new DateTime(2024, 4, 9, 12, 55, 21, 966, DateTimeKind.Utc).AddTicks(24), new DateTime(2024, 4, 9, 12, 55, 21, 966, DateTimeKind.Utc).AddTicks(25) });

        migrationBuilder.UpdateData(
            table: "Users",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
            values: new object[] { new Guid("07bcafe3-d8d8-48ca-b358-1171d16ff87a"), new DateTime(2024, 4, 9, 12, 55, 21, 966, DateTimeKind.Utc).AddTicks(553), new DateTime(2024, 4, 9, 12, 55, 21, 966, DateTimeKind.Utc).AddTicks(553), new byte[] { 183, 54, 239, 160, 108, 60, 75, 88, 194, 18, 102, 27, 19, 146, 124, 84, 19, 27, 217, 127, 31, 182, 214, 230, 26, 183, 195, 161, 170, 42, 139, 176, 224, 229, 204, 205, 112, 57, 211, 14, 34, 47, 171, 95, 183, 249, 114, 27, 254, 152, 63, 101, 30, 120, 99, 63, 62, 34, 69, 186, 10, 28, 25, 254 }, new byte[] { 27, 136, 75, 97, 236, 106, 194, 195, 241, 222, 109, 83, 166, 246, 167, 174, 120, 10, 112, 119, 165, 109, 53, 214, 191, 159, 204, 140, 172, 123, 73, 83, 194, 194, 15, 30, 86, 166, 253, 243, 171, 220, 87, 47, 53, 178, 80, 156, 53, 29, 198, 31, 126, 187, 147, 29, 36, 114, 122, 123, 240, 30, 224, 160, 252, 52, 96, 25, 207, 203, 31, 138, 151, 197, 164, 17, 140, 227, 235, 15, 159, 187, 195, 159, 137, 49, 48, 48, 250, 188, 23, 237, 50, 166, 66, 36, 223, 35, 59, 157, 67, 0, 222, 22, 199, 50, 247, 202, 156, 124, 200, 170, 95, 224, 238, 201, 48, 64, 144, 184, 59, 213, 171, 84, 176, 147, 198, 229 } });

        migrationBuilder.UpdateData(
            table: "Users",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
            values: new object[] { new Guid("566b35bd-5d0b-437a-a09e-2fa66c543853"), new DateTime(2024, 4, 9, 12, 55, 21, 966, DateTimeKind.Utc).AddTicks(585), new DateTime(2024, 4, 9, 12, 55, 21, 966, DateTimeKind.Utc).AddTicks(585), new byte[] { 77, 105, 159, 221, 0, 44, 225, 44, 69, 105, 160, 7, 170, 238, 67, 192, 85, 126, 103, 18, 4, 38, 23, 52, 32, 64, 35, 155, 156, 138, 209, 196, 118, 254, 176, 236, 230, 45, 148, 232, 197, 17, 54, 187, 114, 147, 168, 78, 150, 216, 91, 177, 110, 56, 10, 183, 206, 127, 244, 116, 87, 188, 38, 130 }, new byte[] { 121, 173, 208, 91, 15, 22, 206, 63, 5, 244, 109, 252, 202, 118, 36, 166, 9, 200, 155, 46, 131, 187, 233, 130, 126, 120, 30, 218, 117, 169, 36, 115, 4, 253, 112, 17, 136, 218, 159, 184, 95, 207, 18, 181, 198, 129, 78, 24, 164, 165, 64, 78, 6, 96, 248, 93, 211, 203, 233, 84, 240, 163, 85, 159, 42, 29, 77, 40, 42, 182, 144, 141, 185, 213, 232, 80, 57, 178, 54, 224, 21, 106, 139, 87, 192, 106, 158, 151, 155, 61, 77, 140, 68, 189, 65, 134, 1, 8, 169, 241, 37, 24, 111, 126, 106, 131, 151, 227, 116, 20, 220, 44, 109, 110, 240, 117, 187, 6, 97, 252, 195, 12, 18, 159, 110, 210, 112, 110 } });

        migrationBuilder.UpdateData(
            table: "Users",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
            values: new object[] { new Guid("92941bcd-3c54-4a06-b158-93e07b61690f"), new DateTime(2024, 4, 9, 12, 55, 21, 966, DateTimeKind.Utc).AddTicks(613), new DateTime(2024, 4, 9, 12, 55, 21, 966, DateTimeKind.Utc).AddTicks(613), new byte[] { 218, 28, 56, 18, 75, 78, 185, 145, 78, 141, 1, 222, 220, 119, 11, 157, 94, 197, 132, 187, 24, 158, 182, 148, 223, 28, 252, 181, 243, 137, 52, 13, 64, 201, 140, 193, 21, 221, 214, 255, 35, 213, 203, 125, 138, 35, 236, 85, 62, 47, 85, 183, 30, 101, 20, 119, 207, 174, 45, 73, 196, 168, 173, 218 }, new byte[] { 206, 178, 49, 175, 109, 35, 231, 152, 198, 185, 132, 199, 198, 204, 74, 96, 10, 144, 18, 54, 30, 215, 12, 89, 137, 222, 155, 151, 250, 171, 8, 211, 75, 133, 197, 84, 165, 217, 226, 242, 149, 211, 0, 70, 187, 5, 247, 170, 12, 170, 172, 23, 104, 60, 249, 48, 238, 57, 151, 121, 212, 100, 158, 192, 190, 116, 145, 135, 72, 129, 72, 86, 88, 67, 149, 1, 36, 16, 14, 7, 129, 152, 149, 25, 143, 109, 153, 65, 8, 229, 198, 17, 16, 241, 45, 51, 205, 58, 176, 45, 178, 44, 190, 20, 184, 147, 191, 161, 100, 161, 224, 174, 65, 186, 50, 61, 64, 13, 102, 252, 186, 181, 139, 98, 44, 221, 214, 23 } });

        migrationBuilder.InsertData(
            table: "RFranchiseMedia",
            columns: new[] { "FranchiseId", "MediaId" },
            values: new object[,]
            {
                { 1, 9 },
                { 2, 7 }
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 8);

        migrationBuilder.DeleteData(
            table: "RFranchiseMedia",
            keyColumns: new[] { "FranchiseId", "MediaId" },
            keyValues: new object[] { 1, 9 });

        migrationBuilder.DeleteData(
            table: "RFranchiseMedia",
            keyColumns: new[] { "FranchiseId", "MediaId" },
            keyValues: new object[] { 2, 7 });

        migrationBuilder.DeleteData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 7);

        migrationBuilder.DeleteData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 9);

        migrationBuilder.AlterColumn<string>(
            name: "Name",
            table: "Tasks",
            type: "nvarchar(50)",
            maxLength: 50,
            nullable: false,
            defaultValue: "04/06/2024 13:31:29",
            oldClrType: typeof(string),
            oldType: "nvarchar(50)",
            oldMaxLength: 50,
            oldDefaultValue: "04/09/2024 14:55:21");

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8ed60d79-2ac7-48eb-a5fd-9458e8682e14"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(253), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(256) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("be53838e-dd2e-4dbc-b573-4bac4ed28917"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(262), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(262) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4c216d62-5928-41a9-a2d3-da63c701d2b0"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(264), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(264) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("61627f8f-f0ae-4919-bad6-334a74f04c94"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(279), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(279) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b0a35e7d-4994-460c-8c32-a8bd15176ac8"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(280), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(281) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("7bffe96f-da50-4871-ba5c-089fc1897a8e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(284), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(284) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("030ab34b-ba56-46a5-928e-11b346206815"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(285), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(286) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("04c00af3-971e-4195-b43d-537a81e83cb3"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(290), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(290) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1cff4163-ae5b-49a7-bfbe-7fae03078af6"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(291), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(292) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("dbb51a55-c98e-4bc9-bdc8-b7956856dc87"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(294), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(294) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1dea18fc-1330-4294-8b35-6cc2fdbb8301"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(296), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(296) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f3345717-52dc-440f-84f6-89d2bf502da1"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(299), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(300) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f930197d-2c07-491e-beb9-f70016bb7a4e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(301), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(301) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8a476fc1-cfa1-481d-bee0-4af370b17a8a"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(303), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(303) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("22412c75-7d7b-4e96-b400-91d56b173956"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(305), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(305) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("adec451c-509c-440e-9e37-d7159fbd2d3d"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(308), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(308) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("16e0dce1-8e42-424f-abb4-7912ffb0e2e2"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(309), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(309) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 18,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("36e98b29-a932-4f72-8b84-eab08ffef188"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(312), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(312) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 19,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("13aab240-2aaa-44dd-916e-38c51edbbbdb"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(313), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(314) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 20,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("697b2675-46d8-478b-86bb-650ed7a16dad"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(317), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(317) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 21,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("583cf76e-2825-4fed-bc0b-c30152c2bec6"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(318), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(319) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 22,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b52730da-57b4-4289-bcce-b584aca8b30b"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(320), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(320) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 23,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("95198e92-2b29-4b2f-8467-9655c0608644"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(322), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(322) });

        migrationBuilder.UpdateData(
            table: "Franchises",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d53cc831-1214-4e96-91dc-3233e52456cb"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(562), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(562) });

        migrationBuilder.UpdateData(
            table: "Franchises",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c8403f4f-631c-4b02-9e9b-ebb982579a06"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(567), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(567) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a798f918-3a41-4a13-b09f-bb2683df2dc4"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(832), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(832) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f0732f0a-6590-4edb-98d0-5f95c6050eea"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(836), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(836) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("30fe06d2-9504-4e7f-ada9-aa8f4b25d38b"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(838), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(838) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("972a279f-9ce9-488b-bb90-d2e2f437b178"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(841), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(842) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8a40d8da-1a9d-4f00-a7ae-a0196366e12c"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(843), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(843) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a8f484a0-e0de-4ca2-9b75-fc6b73fe8ebe"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(845), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(846) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9bd3fafa-976c-4764-893e-93f72db3d3dd"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(847), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(847) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4984d831-4d77-41ac-b5a8-b81a8b36bdad"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(850), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(850) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("2633b494-c92a-428d-a70f-34b47eac630d"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(852), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(852) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("94f99ec9-e074-4441-9cd6-77384a46427c"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(854), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(854) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c17e0e7f-aa62-4e9c-835a-51f5d2ce2b40"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(856), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(856) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c76a4a1b-6547-48d0-a473-3d24c7eb5370"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(859), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(859) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("09224533-fc6e-4cb8-87de-15bb8b2d0d48"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(860), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(860) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9ca4da26-b2fd-438e-9187-9f0ce9223b41"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(862), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(862) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("85f50cbf-f025-4261-8b79-2625db1308e9"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(863), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(864) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4497d3e1-646f-4e8e-beaa-c46b631c678b"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(693), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(693) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("304f2d35-1468-4ab1-bb39-91b8c2d050e6"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(698), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(699) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("13602224-73cc-4d05-99fd-24b6f9514281"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(702), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(702) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("40be5835-5fdf-4e8d-a557-d70ebb2f110e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(704), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(704) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("79a0e0d2-53ae-42fa-a384-7d4e206e1fbc"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(706), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(706) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("49f19fd8-6ccd-4de7-8562-0021f80b6db5"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(708), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(709) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1b2e0d50-6380-47f6-a3c1-88bcc80b806c"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(712), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(712) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("50b1074e-e80e-4772-9b11-f17e66aa2809"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(713), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(714) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("24316e18-3129-42d3-b2c5-1179cd869e2a"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(715), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(715) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a80e5c6b-927f-4f43-8544-50caaae27362"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(717), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(718) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f664c9c5-4495-4f8f-94be-6c57e94c713f"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(721), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(721) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c4659192-1a25-4c4a-b81c-ecc8f2b90297"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(723), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(723) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("92b7e8e7-b2fa-480c-8549-0348cf393cd6"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(724), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(724) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("cb4667ce-6e5f-4e94-a2c4-0c3cf1175f68"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(726), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(726) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("99e4dc1d-19a1-4d6b-bfb5-34573c147859"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(729), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(729) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ca6c040c-6522-41fc-92c8-538671fd1273"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(731), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(731) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("af973d27-c784-4239-ac7b-a10f6d9e4631"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(733), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(733) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 18,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("69a8bfcb-c0ae-4751-b07d-ac2bd0697fa0"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(735), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(735) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 19,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4dfbab3b-c690-4eda-a189-20bc48055010"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(738), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(739) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 20,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("40ee16b8-67c7-4019-a5eb-0107133d3d23"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(740) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 21,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("81c21734-da4a-4243-a112-0add75618152"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(742), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(742) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 22,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c4cc7b18-5024-4666-9dbc-e8a576010ee2"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(744), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(744) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 23,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b6fb58dc-4f62-4813-a9b3-8f55ff5c1c68"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(747), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(747) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 24,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8cce2af9-1bf5-4f2a-b50c-50c7a44c0879"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(748), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(749) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 25,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("31152f17-047a-4173-a195-6800aa986b9e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(750), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(750) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 26,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e4fde121-b9e0-4ca8-bb9a-6681554a8961"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(752), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(752) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 27,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("7d040b11-7ec9-48c0-9837-92899d27b309"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(755), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(755) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 28,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3e1e7d86-6c54-433a-8c28-9a21b9707427"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(757), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(757) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 29,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1aca0aa1-fe29-4ae4-baa5-9749f93b18dc"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(759), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(759) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 30,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ca92ba23-dc79-40e1-a443-3148a1ef6dc9"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(761), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(761) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 31,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("494066cd-3476-4f80-bd5c-357a29fac954"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(764), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(764) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified", "Name" },
            values: new object[] { new Guid("7a98eba3-72d1-4580-b6f7-49136e2297ab"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(595), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(595), "# Super Franchise" });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified", "Name" },
            values: new object[] { new Guid("126068c1-869d-4b6e-80f6-7d4470bd9e45"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(599), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(599), "TV" });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified", "Name" },
            values: new object[] { new Guid("f7b1889e-e441-4340-847f-701ba5af50ce"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(601), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(601), "Radio" });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified", "Name" },
            values: new object[] { new Guid("95dae497-5a1c-481e-8bc7-2f2a605ed73e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(602), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(602), "YouTube" });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified", "Name" },
            values: new object[] { new Guid("d3ba1937-228e-484e-a9c9-af7a16f0c7d2"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(606), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(606), "Capcom" });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified", "Name" },
            values: new object[] { new Guid("97b47065-c471-4761-9675-cbe801217905"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(608), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(608), "Square-Enix" });

        migrationBuilder.UpdateData(
            table: "Models",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d810e7b8-d276-4bab-a780-2d8fdca7d9fd"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(960) });

        migrationBuilder.UpdateData(
            table: "Models",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d85a4a75-1554-4157-bab1-b2a901efe158"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(964), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(964) });

        migrationBuilder.UpdateData(
            table: "Models",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("224f1e6c-e919-4b9e-bea5-04c4fe8da061"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(966), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(966) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1013), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1013) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1035), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1035) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1040), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1040) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1042), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1042) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1044), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1045) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1049), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1049) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1052), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1052) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1054), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1054) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1056), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1056) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1061), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1061) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1063), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1063) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1065), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1066) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1068), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1068) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1070), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1070) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1072), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1072) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1074), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1075) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1077), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1077) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 18,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1081), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1081) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 19,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1083), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1083) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 20,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1085), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1086) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 21,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1089), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1089) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 22,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1091), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1091) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 23,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1093), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1093) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 55,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1129), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1129) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 85,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1152), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1152) });

        migrationBuilder.InsertData(
            table: "RFranchiseMedia",
            columns: new[] { "FranchiseId", "MediaId" },
            values: new object[,]
            {
                { 1, 1 },
                { 2, 1 }
            });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4245265b-67d5-42ac-a6d5-a91c096acb30"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(430), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(430) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("db901a0f-27f0-43a2-a574-1729cd3d9dc5"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(434), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(434) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f9b7f985-47d2-40d5-87cc-2ad7547026c5"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(435), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(436) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("490545e4-fa37-44e4-83fe-a3de3ea26118"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(437), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(437) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("007d2387-2ce1-44a8-9cf0-27d6077e3594"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(441), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(441) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("48183059-8e8d-4219-a2f4-5eac01c49ea5"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(443), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(443) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("13418ede-a6c3-4168-a974-a5d82489d72b"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(445), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(445) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("60c27473-1cd3-4304-8c63-78788e0bba3a"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(446), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(447) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e52df9a4-d4dd-44a9-b02e-2692ea28e5b1"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(449), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(450) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c04ada94-08f0-4d3c-bed4-8def697d426b"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(452), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(452) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f2c50ae2-e448-4529-a4f9-1af9e571d479"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1696), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1696) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a966a306-918d-452c-90f2-76579cc6a99d"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1700), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1700) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4f358b44-b82c-46f3-b1db-6c79815d7529"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1702), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1702) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("da3f0778-4999-476d-b257-9c1f33829da7"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1704), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1704) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1a54e1b4-6120-4e2d-b871-16ca33872080"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1706), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1706) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6492544c-c442-482b-aab5-7b4b49e49725"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1709), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1710) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ddff9f13-abd1-4d1b-a1ee-3e58826f393a"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1713), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1713) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4ced923c-ceaf-4d00-be8d-9628b2f7b4b7"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1715), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1715) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a357aa49-36e9-4f0c-892a-e9d0baceec94"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1716), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1717) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9198a499-eca0-4c43-a7b8-7f3927529e48"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1720), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1720) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("daa11680-74e6-4e38-a61a-263e78ad0a13"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1722), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1722) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8616949f-e47d-4d89-b08b-26d420a54831"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1724), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1724) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d111e0a3-8db9-4dee-b29b-df8abac554dc"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1725), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1726) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1426243e-83b5-4f16-8b3b-d6594a94e009"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1729), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1729) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("657e04cd-8087-47d3-b9e0-a4494d69964e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1730), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1731) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d6b409e5-6f07-4ab7-a8cd-ca5dae730cea"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1732), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1732) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("64c36060-b375-4ed4-b98d-26dabdf89f88"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1734), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1734) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8f93d106-ead1-4413-af45-2de0ae75725b"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1492), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1492) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("deb80b0c-3363-46a1-aafd-808f0efcdf39"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1497), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1497) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f4bc9ca9-5a21-49b6-ab17-0c6adc847a47"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1499), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1499) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6e9aa355-08df-42dc-a2ee-987c73bff61f"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1500), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1501) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("30863b64-ca97-422f-9050-031480caafcb"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1504), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1504) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("01554cde-fb57-4fc8-8215-148d8918df6e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1506), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1506) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a3700724-4713-4e02-bc15-db3e017539e6"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1508), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1508) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1a3199a3-8cb8-4514-b8d2-728b9d34eebf"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1509), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1510) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9a6ec3b2-962c-4fb3-a733-d71391b9f71e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1512), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1513) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d3ca846f-0f45-49f3-abf7-26a68aa287f2"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1515), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1515) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ea802b5a-c340-41cf-892f-4203e805c81c"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1517), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1517) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c9857c7d-b2f0-4b47-8dbf-fe53603924f7"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1518), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1518) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f45e5598-3e37-4c0b-8b64-a5649ed12b96"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1521), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1522) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f64a1d95-fdad-4a13-8efd-67e39af73e4a"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1523), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1523) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c12eadf4-9591-42c9-86cd-739983ecfb59"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1525), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1525) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("55be5989-6467-4c79-8e53-03ddd72e5032"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1526), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1527) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4fc1533c-3563-4c62-8220-187bd59edb08"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1530), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1530) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 18,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f3cdd03e-61ae-416b-95f6-a1f01ea265d7"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1532), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1532) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 19,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("396b74cd-59c9-4da5-a6ff-2ecb07808f38"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1534), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1534) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 20,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("346301d6-1ded-410b-a687-e7b06f57f88f"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1535), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1536) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 21,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f5c65bfc-2992-481d-9cab-9e44accd3850"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1539), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1539) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 22,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0fe26d2e-d5ec-4c73-a9d8-248bd6140517"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1540), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1541) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 23,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("85361032-424f-48db-8b6e-1d3a6a0b7c0e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1542), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1542) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 24,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d2cc46d9-6629-4deb-9cd0-37576799e369"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1544), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1544) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 25,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("74ca2c79-acb4-435a-9c16-b6a44f3083b0"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1547), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1547) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 26,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c2a53ec1-cebe-48a6-9930-ab905ba38084"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1549), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1549) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 27,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("54f385ad-c2c8-4e3c-83af-d8c5b6425f65"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1550), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1551) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 28,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9dec9230-97da-441d-b882-cda37c109f24"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1552), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1552) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 29,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c4421d89-f0ca-4fe8-ba98-3a0fe037a1c4"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1555), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1555) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 30,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ec403fe9-7975-4cb5-9b16-814e90d83ea6"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1557), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1557) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 31,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("15b1bb7e-b11d-4be0-b4c4-34e954815e83"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1559), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1559) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 32,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e42bdb67-4216-4749-806f-d156e3c29d69"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1581), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1581) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 33,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("312e17cd-3a35-4c28-8bc4-78170888fa86"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1584), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1585) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 34,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("2ccf89b4-2fe5-425d-ac68-c2e2f6bd9efd"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1587), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1587) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 35,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6de6987a-8dab-4844-9669-f6cd0435651f"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1589), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1589) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 36,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4fe78da1-0d02-4441-84f7-c446fabb15c3"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1590), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1590) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 37,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3eeeff71-8592-402e-874e-a2dd502e8869"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1594), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1595) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 38,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1f907bf8-a3ed-4044-9193-7f15e81f4c5f"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1596), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1596) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 39,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("10a0150b-50d2-47ae-ad5b-37fe45ac4c1c"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1598), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1598) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 40,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("921bf06f-8144-40db-aa8c-3014e71a3d95"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1600), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1600) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 41,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c8ce1228-7a97-455c-8e5a-1a59cfc18645"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1603), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1603) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 42,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("99892c91-7ee0-40cf-a7d8-adf814a2fbac"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1604), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1604) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 43,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c772f7ea-9d15-41d2-bc33-34404fe5d79e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1606), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1606) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 44,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0dde932c-02b5-4871-a6f5-b1d96f1a84a7"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1608), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1608) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 45,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("737903de-e8be-4ea1-8ce4-d3c41fa176c8"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1611), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1611) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 46,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5fff6825-9834-4343-9df1-c04eb247b33e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1612), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1613) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 47,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("789e9d63-5ea7-46dc-b7ce-cbe611d3ea79"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1614), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1614) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 48,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3a059724-962b-4eb0-82a6-aa93390ce70b"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1616), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1616) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 49,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("bcd6a455-f6d4-47c2-9134-a18c5507d2e5"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1619), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1619) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 50,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6f08331d-f399-4532-beaa-3c7f8a3cc7c2"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1621), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1621) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 51,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c60c00eb-fc40-45e4-ae05-8d212d820e5c"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1622), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1622) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 52,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("73f038e1-1cee-4d97-9a18-e01ea5ee7e11"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1624), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1624) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 53,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("172e9710-b18c-4eb7-8a6e-f787e9fe0afd"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1627), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1627) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 54,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c8cfd769-3cf9-4089-bca2-f32f7236bcfa"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1629), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1629) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 55,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f09e9a6f-a07d-404e-b548-c70988358cf7"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1630) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 56,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c62c2566-acaf-40b9-8332-fb05a17f434b"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1632), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1632) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 57,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c76b5ede-cb31-4312-a5bf-cbee334ea855"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1635), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1635) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 58,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("79cf17f0-04d5-49d6-a1fa-0aec52f16ada"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1637), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1637) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 59,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ca9c6a1c-645a-4338-a4ba-e41f3d7e8a08"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1638), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1639) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("97f78e79-205e-4abb-9356-7fb40d9c26d2"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1802), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1802) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6b949d09-98cc-43b4-b654-9613c146dd42"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1804), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1804) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("aad9a93d-69e0-47c4-b8ca-4b674b27e9c8"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1806), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1806) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ca4f09c3-967a-47e3-8c78-402d73862992"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1808), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1808) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6bcaa7a4-5d6c-4d84-b457-7ea90d0fefbd"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1811), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1811) });

        migrationBuilder.UpdateData(
            table: "Tasks",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e898bc83-f993-4c66-9f4d-4e3240a09067"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1843), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1843) });

        migrationBuilder.UpdateData(
            table: "Users",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
            values: new object[] { new Guid("3d47edda-8256-42e6-8dcf-a190e011e121"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(2308), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(2308), new byte[] { 137, 218, 71, 40, 62, 55, 248, 147, 190, 238, 234, 72, 149, 246, 60, 242, 127, 184, 177, 212, 55, 113, 146, 95, 153, 90, 141, 3, 58, 223, 225, 130, 114, 211, 157, 6, 104, 151, 116, 90, 140, 55, 123, 34, 17, 167, 72, 38, 32, 67, 54, 235, 75, 120, 178, 123, 107, 133, 192, 243, 100, 154, 136, 5 }, new byte[] { 52, 176, 70, 168, 171, 250, 192, 42, 203, 219, 62, 149, 231, 233, 168, 113, 95, 89, 20, 18, 189, 148, 12, 101, 148, 149, 104, 60, 167, 192, 135, 44, 229, 43, 67, 65, 65, 196, 18, 237, 66, 231, 160, 24, 215, 141, 175, 228, 9, 140, 179, 148, 88, 115, 109, 242, 171, 164, 67, 211, 211, 11, 223, 26, 213, 165, 210, 61, 130, 53, 28, 7, 47, 92, 181, 144, 175, 228, 36, 154, 162, 161, 180, 138, 213, 16, 210, 34, 69, 28, 45, 171, 52, 166, 71, 145, 253, 252, 171, 92, 189, 84, 154, 177, 40, 246, 10, 211, 79, 183, 48, 184, 103, 178, 122, 105, 195, 119, 124, 86, 147, 50, 5, 233, 107, 84, 253, 32 } });

        migrationBuilder.UpdateData(
            table: "Users",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
            values: new object[] { new Guid("5100986e-42a0-4291-8f4d-d9636b3a8e25"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(2348), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(2348), new byte[] { 183, 192, 43, 209, 252, 108, 72, 200, 3, 121, 139, 83, 56, 175, 136, 47, 254, 41, 132, 146, 252, 46, 190, 181, 149, 6, 46, 240, 172, 116, 188, 35, 87, 173, 16, 130, 136, 88, 231, 198, 152, 210, 111, 33, 157, 98, 98, 38, 86, 176, 146, 137, 11, 11, 225, 55, 43, 215, 239, 7, 157, 112, 80, 106 }, new byte[] { 198, 243, 58, 199, 180, 158, 133, 249, 121, 173, 27, 199, 187, 65, 56, 133, 3, 155, 184, 240, 46, 238, 29, 167, 196, 6, 67, 144, 89, 45, 105, 158, 64, 14, 97, 204, 188, 149, 195, 238, 227, 9, 177, 28, 236, 147, 127, 248, 98, 28, 42, 218, 69, 237, 128, 187, 120, 61, 85, 246, 222, 227, 81, 82, 247, 7, 144, 157, 190, 252, 76, 128, 67, 1, 224, 110, 238, 141, 139, 175, 107, 75, 0, 227, 75, 77, 103, 32, 3, 108, 215, 152, 19, 189, 173, 116, 6, 201, 27, 242, 49, 11, 111, 164, 5, 234, 0, 48, 197, 30, 250, 136, 72, 240, 156, 209, 32, 232, 219, 230, 125, 117, 216, 26, 157, 136, 119, 237 } });

        migrationBuilder.UpdateData(
            table: "Users",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
            values: new object[] { new Guid("2bd90384-7fac-4fd8-91c7-76e31d7ddcc8"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(2376), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(2376), new byte[] { 31, 101, 110, 7, 238, 11, 34, 124, 133, 201, 26, 221, 92, 139, 135, 85, 198, 6, 168, 51, 165, 29, 129, 83, 146, 208, 229, 37, 163, 157, 32, 112, 115, 12, 236, 173, 88, 114, 77, 123, 35, 173, 42, 41, 75, 228, 12, 231, 254, 106, 155, 226, 159, 54, 5, 28, 24, 109, 186, 236, 103, 136, 25, 20 }, new byte[] { 106, 198, 128, 83, 166, 228, 191, 33, 233, 175, 15, 86, 55, 55, 50, 139, 149, 204, 106, 173, 78, 227, 161, 161, 150, 146, 242, 56, 182, 252, 13, 92, 67, 49, 23, 138, 237, 150, 13, 237, 192, 155, 64, 90, 148, 117, 224, 237, 111, 126, 26, 185, 221, 127, 159, 6, 247, 194, 199, 248, 27, 28, 109, 49, 38, 84, 121, 237, 15, 233, 26, 180, 54, 75, 110, 7, 11, 225, 142, 168, 254, 136, 23, 218, 232, 156, 91, 22, 131, 102, 168, 182, 101, 247, 84, 87, 237, 211, 1, 146, 66, 73, 113, 206, 155, 186, 25, 143, 48, 146, 54, 210, 96, 31, 111, 104, 255, 38, 137, 75, 178, 56, 228, 250, 32, 26, 35, 81 } });
    }
}

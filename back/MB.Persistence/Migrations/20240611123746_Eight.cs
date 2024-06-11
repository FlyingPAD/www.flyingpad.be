using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Eight : Migration
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
                defaultValue: "06/11/2024 14:37:44",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/12/2024 17:11:42");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7ccdd2fa-7d01-408c-a8b9-535ccf3f5817"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6896), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("47c9f5c5-eb25-4a33-aa2f-39429cacc4e7"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6924), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fa8a10fb-5e1b-4ed7-afff-68d07cb2a6ef"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6927), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e08ca57d-f336-43d8-b516-f35713df856e"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6930), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3497a2f1-bf76-4ed3-92c0-c46baac80e59"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6997), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("745374b5-66f8-4958-bc9b-99ced1fbe4be"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7005), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8a47e260-e57a-4221-a0e5-b7deeb90c164"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7008), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("05360fe3-f823-4a2e-b3b3-d30170b18690"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7011), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6d6ef8d5-9d77-4b49-8f8a-c4416ec44bcf"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7013), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("80c56f5f-f66a-4de0-9b0d-e51d671925ab"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7018), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4f2501ff-9c3b-4d3a-ab11-18fa0241d38e"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7021), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("15f5b8f1-12fd-481e-bdce-20eeea0db205"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7023), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4fd394e8-7eb4-4073-8143-80c722be9cbc"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7025), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ce63d747-09d6-49e9-a629-a534e4eb2887"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7030), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("82c17f29-e010-44cc-b5f3-7edb14a6424b"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7032), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8c1f8546-824f-44bf-a8cc-492b1e2b91bc"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7034), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b8e04a0b-39ea-489a-ae99-a93e4e7205c1"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7037), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("be6b99b7-2bed-4d87-92c1-a587b0e01b40"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7042), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ce684293-bdc1-434d-9446-ed4d605c3a4f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7045), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("024e1852-becd-4108-a997-47b38b8cb7fe"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7047), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e7aa0691-0144-404b-af23-c515682ef43a"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7049), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0444e7a4-0370-4196-a22f-4752a1c8a9f3"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7054), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e56e271b-2fa9-4e84-bc0a-5db1187f539f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7056), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("691c0b84-8319-405f-b21c-38f0d55a3863"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7471), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2816ce50-fb09-4e11-9251-c465c1c40406"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7475), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cf5b28bd-1b2c-4912-a2b5-b4c0e606fc77"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7478), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("70eb41bf-a3f2-4586-b357-385408f72d95"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7923), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8fd5f220-c616-4042-a0bd-5c336cda9025"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7930), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f59cc250-15f0-42ec-8892-1499603f0248"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7933), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ac06bbf3-d23a-42bf-9664-df7856068370"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7936), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d73af9d5-45af-4006-b13b-8cd8194d7af3"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7939), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b90e82d0-d321-4c13-b34a-c5347d036149"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7944), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7953e451-4411-48a8-935f-a7355dc30f8f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7947), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6ef51581-9957-45ae-9500-10627dcc4c90"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7949), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5e822b30-ed3b-4717-b110-e0e1f987300c"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7951), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("674bcded-28d5-493a-82ac-074810683155"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7990), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8959e4c8-80bd-4bb0-a10f-c8dd65f48baf"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7993), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("95c61da0-c691-429f-8aba-7f0cd2b029d7"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7995), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("42fa1627-ab06-4484-8afe-a7162fed92a7"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7997), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e347d844-fec4-4f10-a36c-7bf521e7e6aa"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8002), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("36ccee98-9ba2-49b3-86a6-4f468d041296"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8005), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1d7c0942-5557-4983-a5da-68daaf394e74"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7756), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f98503c0-969a-4c8a-9f98-87299d4cab7d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7762), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a4d1ebc8-9317-4441-a190-e980dadf48e3"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7764), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e09caf96-0e48-4ba1-a2e7-7660b1a39f9d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7767), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1c466b8a-1939-42aa-97be-48d78b4d5609"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7772), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("96e72593-3e57-4be9-bceb-84e8169fe1bd"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7776), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2d080e5d-6e4d-484d-83e4-39c845a8734f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7778), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bd51c397-1b01-4277-8c0e-8ceef439c31b"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7781), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("73f8fbe9-0105-470e-8f06-ebecb00bc785"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7786), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("97afbc6f-4f31-48a3-aa1f-e350c11b5b04"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7789), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("99406cfb-276a-4608-a809-27a8d4f887d8"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7791), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6d84a6b4-6257-443f-b919-bf77bcc787dc"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7794), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9962e05d-0d81-42b4-adb3-54a8199b9abd"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7798), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("70c7f2e0-21fc-4754-9ddd-438c8e46b919"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7801), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5a6614d2-4c36-4df0-a5ae-7367c5e94211"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7804), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ee5f993d-ce9b-4fdb-a17f-77410cf75d97"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7807), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d245e5d0-94fe-432a-955c-2c14d5de1782"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7812), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5ce956b3-6014-42dc-bc11-2d9918c23487"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7815), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5b2fbc81-07d0-40b3-ac67-2ca6ce648974"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7818), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("452d62eb-2c45-4403-887f-529661b72943"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7820), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("554bbb31-fb5d-4dc1-93f6-d262f36a9093"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7825), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0e9dc69d-b790-49f1-8646-67d20851004c"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7827), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaab73bf-aa5b-40ff-a5ed-ae69447311b8"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7830), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("448fda35-a1a9-452e-9df7-95ececb62e6d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7832), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("18436d3c-54c2-4a45-91c4-9c8b699c6c21"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7837), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("de425b9a-d142-475b-a327-d9f99cb1ba93"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7840), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5313b918-0abd-44bc-8956-d89425321c25"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7842), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e78acc9b-c853-464d-923b-8d12fa319ce1"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7845), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("75d6d2ab-c1a9-429f-8571-8b28474a8906"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7849), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ce27c661-c737-474b-9bae-987cdb5029c6"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7852), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("116cb20d-08f2-4ff1-bed5-3ab193e0d1de"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7854), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4ef64c20-88f6-4380-8e57-9eb9a4c39c49"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7528), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c44d4c9b-aae2-46eb-969c-cf6a70e99110"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7536), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f4919d6c-5f59-499c-b902-8eb720d9e651"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7539), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7347c632-7626-4639-8f42-4d0ae12ff876"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7541), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1a646501-8fe3-4d27-91da-8d52b169bddf"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7543), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("14c73d84-a4a5-4b32-b9ae-99319020c61e"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7549), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4ca9ce92-c4a0-41c6-8974-124c8806069f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7604), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d37e276f-a8aa-41e6-8c68-a1f65ba80d2b"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7607), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("40d26052-44f6-40ee-a2f2-b4d5067a2171"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7610), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9299102c-8108-405c-8fe4-8ff65db071a8"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8151), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d4426b59-eb60-4d5d-ba9c-06824c11a6ca"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8156), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0bdfb4af-ed39-4c10-a986-5840bccc3f18"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8162), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8211), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8229), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8235), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8241), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8244), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8252), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8256), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8259), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8262), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8348), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8352), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8356), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8359), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8366), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8370), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8374), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8377), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8381), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8384), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8387), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8390), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8395), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8398), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8481), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8539), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("afc90a0c-7a36-4f80-8a39-f1f18a93b735"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7310), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8472c4ce-2f2d-4144-99d6-bd6c16430983"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7315), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3d53fc06-8c18-4932-aa11-41ab858b6e5e"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7321), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("edbe7767-906f-426e-b5a8-3a70d9148ac5"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7324), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("247bae8b-356a-4850-802f-2cd56cf5de2a"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7326), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c72c0c76-2a64-4053-ad1f-c37ef4b4d114"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7330), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0da60357-704b-40fc-88d3-8472f651a03b"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7335), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8deed359-6d10-45bb-908e-13cdc2a688e9"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7337), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("63de03fe-3944-43b0-a3f7-8117e00b8d18"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7340), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5556265a-b582-4119-9c05-52cfcb5e2b7e"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7343), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2850bb3a-6297-4d31-8478-0d40866c4a57"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9374), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ea89f995-e61f-4e0f-b6ab-148c2066e3f1"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9378), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8009ae51-6a45-466b-b79b-0867109e405d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9381), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ca542795-319d-4310-a679-2185e31fd319"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9386), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a62c6acb-c291-4a63-8fa8-a8c6a02cd00c"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9389), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e8ce58ba-cf4f-4cc8-9d2a-82b237b9e761"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9392), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("80828076-73b5-4975-87e8-8c10afda0983"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9395), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f228f852-c17e-4f35-9d8e-f06d8ce18e6c"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9399), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b5022900-0b6f-4e3e-9803-ad4b85c80fbb"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9402), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1bdd0e32-4dd3-456c-a892-de8661a81484"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9405), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ff9bd06a-83e2-431e-9011-b5209be13a4b"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9407), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a4f897e4-98b3-4cfc-a30c-59640f00ff79"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9412), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("943c37be-587e-49ad-9b1c-d04b2f7e7b16"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9415), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ae3afa31-f734-4cd9-9403-72f7f3201479"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9417), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8df38f78-99db-4ec3-9a5b-5053cfa8e06d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9420), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("382fefc4-4ee4-417e-950c-2c76d330210f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9424), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8d26f261-d9d4-4065-a51d-05a2f8fdac95"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9427), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("207815b3-62ea-49c9-84f4-ee6386f4b46d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9046), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e3ccd4cb-e71d-403a-a90c-9be85cd8ee26"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9052), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("43bb6992-eb5a-4582-a3c1-80d2c9546923"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9058), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("16aac054-c5ed-4d95-881e-e00cdf349231"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9061), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a7edd5ab-32a9-4cff-829e-d987e8249edf"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9063), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e3acd550-a287-461c-9dcd-725d3a872466"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9066), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("063eb61d-e592-4f61-88e7-afd9ad631d31"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9070), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("016a26bd-573c-4248-a899-10e96adae30c"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9073), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("28565e0a-d5a8-4abc-958f-2309f264616f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9075), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("858ddee5-9f04-427a-964d-04f1927afc3d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9078), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8752f321-6f9d-466f-a58b-e579a4024dbf"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9083), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2e54cd12-61b2-49d7-a04e-656aacf99bce"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9085), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e4cabb31-8123-4879-9f3f-a0ae5acfe05f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9088), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("371acea0-d6ab-4340-a5cf-ea65e2c42ecc"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9090), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cf0ad7e8-e105-4685-950f-c0346aa2fd1a"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9095), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4f807341-568e-469d-98d5-ba3ad87bdac6"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9097), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4e8b7c47-e6c6-4051-8252-7101f51e2ae2"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9100), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a2469dca-12eb-4357-99cb-8c7526f9fe6a"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9103), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("245e9e2d-baf0-4227-bafe-2ae5fc9b3f8f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9108), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("94f6f38e-8a19-4d23-a73e-3a34b9f332fe"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9111), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b055f823-789a-450d-b78f-f4394c82a0f1"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9113), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e917ba79-b2ea-4236-a1c0-ccc7f2519d7b"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9115), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c9fe0d0f-3578-43d0-9375-ee8548c4d2d5"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9120), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9cfeb419-488f-418b-9917-b33277083df5"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9122), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("77178ee2-b586-42f1-b867-c2c8d01fadd2"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9125), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c890f1ac-e5c7-4ff0-8e0e-42a05fcb16db"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9127), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b9158afe-2728-48db-8e6e-61f0317ee9ce"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9132), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d7dd942d-f139-4ef8-8a74-3263f867e572"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9134), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a4b62fb0-9164-4ba6-95c3-544179fd790c"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9137), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bb4c9ceb-6d89-4ee8-9d0f-f51fbf8f9f57"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9139), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3c5d9650-60da-46af-b90e-f806cde9204d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9144), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dcc6e551-9417-4c63-856e-5748e28c592f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9146), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f69f1a80-896f-49f8-be55-b0b17128c785"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9148), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a52c8e70-9ea6-4434-9d96-9fa4ca07e7ef"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9151), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6cbf52c6-58d5-44a7-92ac-ecea088788e8"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9156), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("02d985ae-009f-492f-8516-a2153af3f950"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9159), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6d808b91-f3aa-4919-af90-a1c0c7d30df2"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9161), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("117da4fa-32ef-4762-a56a-727f0e14853e"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9164), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("277303b9-e449-472d-9fd7-560702bfac56"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9169), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("93b7febe-6671-45c8-ba98-4857fc2cbcf6"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9172), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a3c1036d-35fc-4eaa-aefc-c80b4def2239"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9174), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1f7e86b0-1920-48ad-8b2f-d53cac869f80"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9176), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("277bae86-a481-469e-bc13-f23ad47934f9"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9181), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("368d6614-f2c5-4ada-8b83-2f0094065258"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9226), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dca4cc8d-c892-4041-a8f8-48c1dfd6156c"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9229), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b30f4c4e-a047-4ebf-8703-fb5c64e3f6b4"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9231), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0584c1e4-93d9-4d3b-a402-a6ee51d61f80"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9236), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3af6f82e-9ab3-4748-a39c-da71109d12b1"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9239), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ec2de1b3-6a53-435c-9437-9b6f1b2e168d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9241), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("08a2829e-92d2-4c40-bcfc-f3581aaaa794"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9244), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9ea52a12-a7ce-48ab-ba8a-4280884c6335"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9248), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1996f0d3-b094-4a59-8934-5fc8152c8ae8"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9251), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("53efcdc8-6070-4dc5-9262-c1cb29e80f79"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9253), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9773b096-714d-4e22-8c36-eb15f6abaede"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9255), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("969b2dcf-a213-4233-9552-5e2e63c3b908"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9260), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("608cd796-289d-4792-9e29-bf1a993d89a1"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9263), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d1132d62-0996-48d2-b0a5-c30265efe1a5"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9265), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("11c13252-f45a-492f-9b4c-2c634a32815f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9267), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("053d5412-4fe6-4f57-a232-1db1df540e6c"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9272), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a3e4b57a-d153-4de5-b597-2b90d5562390"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9489), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8974e4b1-ac04-475a-a568-423cdea60210"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9494), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("009cec29-9427-4d00-ba85-ef0da6486057"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9499), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("13cfa2f0-0ccb-437d-a9c9-b5a2f510bf27"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9501), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("24cce47c-3c8e-4b20-a9ad-ee9f4a853541"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9504), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a0d58b1e-a6d6-4c9e-adba-f33d5c0efe71"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9554), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("470ab25d-e803-4a76-b0b0-d67d9ec72622"), new DateTime(2024, 6, 11, 12, 37, 44, 684, DateTimeKind.Utc).AddTicks(71), new DateTime(2024, 6, 11, 12, 37, 44, 684, DateTimeKind.Utc).AddTicks(72), new byte[] { 224, 75, 101, 183, 124, 16, 85, 65, 3, 75, 141, 54, 171, 179, 12, 243, 84, 196, 75, 180, 47, 135, 109, 62, 103, 113, 82, 134, 5, 57, 157, 56, 197, 140, 65, 49, 17, 180, 98, 253, 171, 51, 40, 52, 155, 183, 74, 249, 141, 16, 183, 229, 64, 48, 175, 215, 118, 39, 179, 179, 186, 163, 55, 164 }, new byte[] { 40, 21, 85, 85, 117, 226, 82, 67, 95, 28, 192, 255, 168, 65, 241, 12, 112, 118, 69, 29, 190, 97, 30, 81, 63, 222, 233, 239, 150, 37, 189, 150, 188, 237, 64, 215, 128, 11, 132, 4, 96, 218, 194, 128, 60, 105, 57, 112, 122, 53, 142, 35, 36, 100, 154, 206, 156, 219, 165, 45, 230, 120, 76, 178, 168, 118, 209, 92, 68, 123, 215, 34, 198, 224, 178, 239, 187, 248, 171, 10, 51, 104, 64, 224, 241, 2, 111, 171, 138, 211, 235, 14, 155, 215, 200, 114, 241, 235, 170, 139, 168, 102, 222, 43, 70, 153, 191, 10, 131, 157, 145, 44, 85, 240, 179, 35, 116, 142, 126, 169, 250, 196, 217, 63, 238, 9, 221, 203 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("e76130ea-7ff4-420c-8951-017cbd30b077"), new DateTime(2024, 6, 11, 12, 37, 44, 684, DateTimeKind.Utc).AddTicks(180), new DateTime(2024, 6, 11, 12, 37, 44, 684, DateTimeKind.Utc).AddTicks(180), new byte[] { 52, 21, 59, 133, 50, 143, 118, 242, 195, 200, 47, 233, 239, 174, 125, 95, 45, 223, 119, 75, 85, 169, 235, 33, 179, 245, 190, 195, 243, 43, 73, 103, 138, 218, 243, 254, 208, 111, 253, 136, 116, 105, 202, 85, 216, 174, 168, 92, 75, 75, 69, 38, 39, 211, 60, 184, 82, 82, 156, 64, 68, 215, 240, 159 }, new byte[] { 93, 208, 37, 208, 50, 99, 220, 175, 218, 249, 216, 222, 102, 137, 134, 217, 239, 175, 30, 181, 71, 168, 164, 60, 164, 101, 224, 92, 230, 134, 197, 19, 191, 20, 255, 158, 151, 65, 137, 140, 202, 43, 65, 42, 219, 9, 238, 233, 58, 0, 2, 176, 177, 72, 221, 243, 152, 12, 108, 89, 252, 238, 138, 254, 166, 156, 169, 108, 60, 169, 194, 45, 193, 15, 158, 56, 5, 63, 190, 2, 11, 209, 217, 182, 182, 104, 180, 208, 106, 95, 227, 29, 45, 161, 92, 195, 183, 219, 237, 231, 253, 171, 138, 85, 53, 163, 44, 42, 15, 119, 107, 195, 92, 120, 220, 25, 22, 106, 79, 141, 224, 137, 174, 237, 24, 89, 204, 88 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("cde59053-f9c5-450c-b5f0-93536e8cb416"), new DateTime(2024, 6, 11, 12, 37, 44, 684, DateTimeKind.Utc).AddTicks(249), new DateTime(2024, 6, 11, 12, 37, 44, 684, DateTimeKind.Utc).AddTicks(250), new byte[] { 123, 170, 197, 156, 225, 39, 134, 4, 102, 94, 189, 158, 55, 3, 230, 168, 135, 81, 237, 62, 254, 157, 226, 206, 211, 248, 247, 152, 112, 177, 193, 92, 147, 135, 127, 88, 74, 108, 75, 219, 243, 56, 211, 104, 109, 116, 118, 172, 105, 27, 19, 109, 40, 193, 189, 68, 81, 52, 66, 174, 223, 18, 139, 97 }, new byte[] { 139, 24, 251, 128, 83, 59, 83, 141, 162, 201, 147, 148, 198, 70, 48, 0, 20, 131, 69, 154, 20, 3, 38, 156, 134, 198, 225, 85, 33, 171, 192, 85, 87, 242, 224, 246, 120, 30, 20, 8, 215, 66, 238, 105, 132, 219, 82, 116, 115, 52, 106, 137, 74, 227, 14, 96, 77, 160, 129, 73, 97, 220, 219, 154, 29, 14, 2, 163, 98, 217, 233, 149, 7, 252, 150, 184, 139, 42, 86, 24, 238, 17, 51, 90, 62, 182, 7, 59, 163, 91, 222, 224, 239, 0, 22, 18, 172, 126, 73, 250, 0, 148, 182, 194, 197, 227, 130, 152, 214, 238, 217, 154, 112, 253, 143, 64, 149, 206, 9, 133, 222, 195, 144, 175, 107, 58, 151, 249 } });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "EntityId", "Birthdate", "BusinessId", "Created", "CreatedBy", "Email", "FirstName", "LastName", "Modified", "ModifiedBy", "PasswordHash", "PasswordSalt", "Role" },
                values: new object[] { 4, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e128655e-8e27-4ea4-9404-ed947ca3fab6"), new DateTime(2024, 6, 11, 12, 37, 44, 684, DateTimeKind.Utc).AddTicks(339), "", "test@test.com", "Admin", "...", new DateTime(2024, 6, 11, 12, 37, 44, 684, DateTimeKind.Utc).AddTicks(339), "", new byte[] { 179, 247, 229, 113, 166, 108, 80, 142, 125, 195, 216, 241, 169, 143, 200, 160, 115, 33, 143, 125, 204, 55, 240, 64, 245, 101, 201, 54, 136, 177, 24, 146, 219, 37, 144, 11, 172, 97, 167, 204, 86, 80, 235, 72, 162, 146, 213, 119, 188, 138, 135, 57, 225, 86, 242, 169, 163, 111, 34, 126, 135, 152, 202, 229 }, new byte[] { 157, 46, 140, 10, 232, 114, 24, 94, 208, 215, 69, 73, 176, 124, 12, 240, 41, 58, 135, 192, 103, 231, 175, 123, 51, 230, 191, 185, 113, 68, 59, 88, 43, 252, 75, 32, 236, 209, 81, 229, 91, 36, 156, 187, 244, 135, 192, 91, 48, 205, 180, 89, 225, 200, 175, 151, 108, 211, 126, 135, 57, 10, 26, 35, 212, 43, 63, 86, 56, 112, 56, 108, 68, 191, 97, 85, 10, 212, 87, 208, 124, 137, 108, 140, 184, 213, 166, 184, 39, 221, 83, 232, 132, 121, 105, 81, 255, 66, 0, 192, 215, 1, 215, 228, 20, 191, 177, 22, 160, 117, 200, 67, 231, 138, 30, 124, 154, 198, 81, 67, 93, 196, 236, 130, 55, 165, 160, 130 }, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "05/12/2024 17:11:42",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "06/11/2024 14:37:44");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b3298b07-a268-4ed7-8650-e5d151c9977c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("31d933b4-d303-42d9-921a-73bd0f28fa67"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2059), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("347fb103-2998-4a79-8eb0-6df9d5de0c80"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2080), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("99c501d7-1e10-437c-a11a-fd52ef458159"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2084), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("73ac5219-ba34-4b78-a85f-dc89f55a073d"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2086), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6412f531-34cf-4202-926b-4a95e2bd7f24"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2091), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("60d302c3-92a1-47a3-8ce3-c8f0e5568d6c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2097), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fc0ffb5e-f2ac-466b-b3c1-e181df4e65c4"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2099), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e5c011eb-15c0-4b8a-8421-866d9230c710"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2101), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("62682e99-eb8c-4b5a-a3c7-cb1aa0b56802"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2105), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("14400be5-693b-4ba1-9a3b-a9a2dc979d31"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2110), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bcaa58f1-df36-43fa-8adb-b7dc645ce1a9"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2112), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9dd83f53-9e80-4e2f-b3b4-205e266f33e3"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2115), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("62cf9345-6295-425f-b1e0-12d4c21dd3e1"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2118), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a3a31702-0995-43c4-b890-b7f142484277"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2131), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d1fd37b8-44dd-4695-a6ab-22930a88baa7"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2139), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("55e35651-9c10-4b0d-ba8e-59cad3564573"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2141), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3eea8526-bda2-41e3-88da-30d379179536"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2145), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("15029cdf-47ed-4341-87e6-fba6480155c1"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2150), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e1b7eaae-1f21-4188-965e-e9d385f17ef1"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2152), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d5c018b3-10b1-4ef6-bf2b-4267b28ecb6a"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2154), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("db9dec69-627b-4b50-a428-a5e02f6f80c7"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2157), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b4776570-a6ac-45a5-85bd-271173d878f4"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2162), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9173954c-2e61-42d8-86c4-c4381da9303f"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2599), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("49fe2b43-0a30-4ce5-b571-ae0fe2f5c283"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2608), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5b9b1b35-3b3c-4b8f-9747-94036e4206d0"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2611), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("47f7a956-20d6-4444-ae23-bad40e24ca3e"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3098), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7220d844-818d-4668-a65e-5a6d1c1fa82b"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3107), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("37531ffa-57de-41ed-82bb-433fec609960"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3113), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d71eeaf7-cad6-44d4-8ed1-d1f365b246b4"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3115), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d4071dc1-00f9-4766-a511-8002bb0f9cb4"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3118), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b174a555-cd5c-45ee-a73b-3addfa732d0f"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3121), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1e7c98ae-5688-4384-a372-154e068317c1"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3125), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d0873cc0-a19f-4a13-b754-d477c9172c31"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3128), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4cf9717c-7c84-4644-9cd9-3628d009f95a"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3130), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4f74982b-42ed-4d11-9739-454afccb3c91"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3134), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2dca5bb3-61b5-41ef-8113-930661c6733e"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3138), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("83df39d4-5e88-4e0c-86a1-65b0f552b94a"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3141), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2cb96481-280f-4dd1-a90e-4049c2796d1f"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3143), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("06ea4b3d-4bcd-4e02-bc2d-b76b629de597"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3146), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("86cbebde-9663-4cdd-8fae-dc757dac6439"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3150), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6222729b-e13e-4d3b-8adf-47f1461db0ca"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2854), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("91ed2e5d-a65c-477d-a964-f12c4f29cc93"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2862), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ebebc216-4cc4-4135-a29c-5a4a500aab0a"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2864), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("95ad96fa-1dca-40a2-9e52-67f3faeb5e45"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2867), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a445c1e8-4863-44b1-8625-1fce97f38a5f"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2870), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9bfc6fdd-8aea-4a4c-b266-1218160896ce"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2876), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8ac9e511-ca52-42f5-babe-4a4c69077c3e"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2879), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e8c52004-4642-4e33-a03a-572d8502deb1"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2881), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d84ad548-132a-4663-be79-a6770f4ab162"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2884), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8474db70-073e-4491-8c47-ddfe01c835b6"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2890), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1a213fd2-bf92-4ac8-ba59-813b36be21bf"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2893), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2638bbef-70c4-496c-99a0-18f3fb86f00e"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2895), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4d8ebb45-0d54-46c7-864a-c622fba40902"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2899), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0755bcf8-285d-41c9-9a77-e42cb482a3f6"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2904), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b85f06ee-9fdc-4f46-b6ad-12904165d1f5"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2906), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fde65f0f-ffd4-4ade-a16e-f288e16eddf3"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2909), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e1e06cd7-e851-4d11-adb6-ee7ca6b37c63"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2912), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("eda2fd18-78fd-462f-b081-ea7ec075c385"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2918), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("68203fd4-f699-43a8-9517-66333a185bc9"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2920), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5d6b00c2-e9b8-4253-8285-805c8878118c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2923), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("57cbdae6-b9b9-40e6-a857-5a12ad797610"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2925), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5216d239-7e49-4bec-b7fb-10fd21798c12"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2930), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("93cb12f0-fd82-4bc7-8fa4-cff71a42b74c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2933), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("05846865-a4d9-4ffe-ab12-4a52f20fda53"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2987), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("485e54df-2acd-4876-bcc4-80f6989f6b1a"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2990), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("faf97024-f3d6-4fc3-b425-994e517f5cee"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2995), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0c9038c3-98a0-4904-8a63-f23a8c0fd045"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2998), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8c779978-2bda-4586-bc76-e8d9286acfa3"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3000), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("27fceaae-8b4c-4549-8f15-3fa577e6a192"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3003), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2771034f-9e76-49ce-bc93-5e2dc6b22b8d"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3008), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f280acf4-181f-430c-8ace-55a6fc1713a8"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3010), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("87b1758d-3c3d-478a-baf7-4d84d5489812"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2665), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e63e72bb-06ac-4fa5-b5b5-5a93a82a76b7"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2670), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f84163e4-3299-417c-9df4-c71ffb170254"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2676), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e7716080-6346-4e1e-b13d-8184e0699972"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2679), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2679) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bb9aa620-433a-4f00-9978-97625810e8eb"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2682), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("493142f0-106d-4081-8b63-a9ff67ad722a"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2686), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("808fad30-ea4d-435e-8315-9017fa29d082"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2691), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("27dd13f9-b079-4dbb-9420-defa530ecd2a"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2693), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e58b6e70-e1ce-4265-a5ce-f2443529a472"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2696), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7efc2dab-185b-46d9-b39e-60b7af60b55d"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3352), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f6c0b849-de21-492c-a6ff-4851db7b58fa"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3358), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f0306a36-3fe0-4e63-a94a-f619cd5c510e"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3361), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3429), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3452), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3457), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3461), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3464), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3471), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3475), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3481), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3484), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3488), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3491), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3494), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3497), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3500), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3504), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3510), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3513), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3517), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3518) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3520), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3523), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3526), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3530), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3533), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3615), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3755), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("93eab10a-2197-4e3a-9c78-bdabb8d424ac"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2352), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("04516f01-eab8-45b0-9ba1-136fd39cc302"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2357), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("56ebd286-ecff-4395-af77-255e40580452"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2360), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a2a3ad1e-8b8a-437e-ba97-d5786f57623d"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2367), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("50301ea8-c73b-4af9-b141-4993632a8880"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2369), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5b92b180-996f-4cb5-b8b2-75a839eef4e3"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2373), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4ac85276-19c9-45da-bed8-ff29f4b3dd1b"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2375), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b5d4ad54-78e9-4824-96d7-d9ab727ce68c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2380), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9f640b70-4bae-4745-9757-80933e128a59"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2383), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b23da1db-0020-4bef-a1d6-4299afb0c601"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2386), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7ffe702a-76d9-4284-8c07-064ed097bf2c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4749), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e8bf6892-41a8-4ed4-a0a5-dea4929f1916"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4754), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("556a0f0b-efa6-47f5-85a8-c30db187ad62"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4756), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("eb944089-6c1c-4118-932f-12f590dfbe43"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4759), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9c9ac839-1009-487d-b1fb-540cdb16bde3"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4764), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7ee3fd5e-c36d-4746-a8aa-3e6abf08fdad"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4767), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("be66656b-984a-4f8f-8f9a-3fd50f685a85"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4770), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("58044fbd-8a7d-446c-87b4-2f3b159275dc"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4773), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0077aa58-140b-4f3b-98ad-0ffc0f90f0cf"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4777), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1a2f09c6-4629-42b3-8668-45f22559631a"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4781), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a50500af-ecc8-412f-a234-76d147941b05"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4784), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9c8ead9a-e2ca-43b8-9b10-3be3ad97a079"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4787), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5e747004-0d04-4ea4-88f0-8de412cf9ff3"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4791), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("eec40e85-016b-4546-9c2b-46e5bb8d6bb9"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4794), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0dcf8a9f-1604-45b0-89a5-b15b8c3aa3ce"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4797), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("81ae1758-db12-4f2b-8af9-106593bdd910"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4799), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8f1046e5-b42d-4bfb-a3ef-d6b5c1483553"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4853), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("18300afb-a944-4ac0-8188-77ba71bfc678"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4392), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2856d7f8-6c0f-4f3b-b6b8-43256253c3d3"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4398), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4398) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("447bd929-be2d-4a82-8548-7137327df96c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4401), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a37d4196-ea55-4bb5-8627-2f823763c61e"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4408), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9c8c1f53-b910-4a34-b37f-854f20591813"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4410), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d7372b9c-c611-4edb-8a88-476b443ecfad"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4414), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fde151ed-b365-4f50-a31c-ff136aab4f56"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4416), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e0dae36a-b3dc-4e4f-a701-6b0097cd4bbf"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4421), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4421) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("905e9a60-f8c3-497a-908e-57416e08f0e8"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4423), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e3fa901d-3be7-469f-a71e-de3e4c2388a9"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4427), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6c32dda5-69fe-4a86-b184-dd144dc54d60"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4429), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5ee80f1e-108b-468e-872d-fa080ee2664f"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4434), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("061b8e60-96e1-487a-b522-21803e5c7524"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4437), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("98dce441-438a-48d7-97f2-3a195532ccf5"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4439), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5a024f8a-82ed-46c9-af29-30e08443fb40"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4442), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ab0a732a-0207-4b36-8c89-04d03cba6704"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4447), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bad5be4c-4906-4e70-8af1-bde123da7e4d"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4450), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c92c55ed-e80c-47c3-9ff9-0882004e523c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4453), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("54b75ab5-0aeb-47e7-b117-d51f7e587853"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4455), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7e15a84f-fdd9-4d9a-8476-af04fbb17c68"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4460), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("23eed29f-1e78-4784-aa69-26e70874c6d5"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4463), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3a6b4af9-e475-4017-9997-b021e6b08ecf"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4465), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3737b8b6-1efa-4f63-aa24-0670dbb3db89"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4468), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b3db5bbb-2801-495a-aea8-6671e200bb14"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4521), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bf151d2e-b45e-4bd1-b6f0-9d7eae392fd7"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4524), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ab611273-fef3-4cd8-939e-93060f30ce68"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4526), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bd50549e-8910-40e5-ae06-7974fe0febec"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4529), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8e99f058-9284-4ff4-9fe1-a1514a89e3b6"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4533), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("150cad84-ec06-448d-b7ca-ff1352cc22f7"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4536), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cb0b90d4-212f-49e1-9ea5-42b7a1ef0a54"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4538), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("eb37fffb-50c2-46c8-ac73-5b985f4d8ff6"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4541), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1df9bf34-73eb-4217-95ba-8e4c16e34315"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4545), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("361328b0-c5e6-4c9f-8739-eefb3f4b86ae"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4548), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3657f45c-e073-4880-bf42-8d66278fe598"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4552), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f198a466-045c-48bd-9aa7-403f8dc99358"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4555), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f8e72661-d557-40dd-92a2-21dea9863314"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4561), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0cdf139d-0d40-4ed3-8e5d-c53df299f662"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4564), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9281d33e-8afd-4288-8b55-337066fa502e"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4566), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("846777b5-a852-4e6f-9e1a-4359b11ea4c3"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4569), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4b5c1b82-81b1-435b-895d-172ad4dc83ad"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4573), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2df7d35b-353b-4c77-a4a1-bb8f86c96bcb"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4576), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("325ecf45-00f7-46d8-9086-e913a7e7fb05"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4578), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6bb96e72-e67c-4601-9ece-a5ede8bef8a8"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4581), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("38baf420-a8a0-41c7-8fe0-25460e453533"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4585), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2e932bdc-6bfc-402a-8e76-10b54e1cd423"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4588), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8c7bd863-8c93-4151-8647-9b0280546984"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4590), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9f4dbc61-3ab0-4568-b2e6-e8bdbce63ba6"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4593), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("318ca68f-06bf-49f5-a245-b8360558be9b"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4597), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7d6c4320-88a9-4b90-b3ec-7a09f478823d"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4600), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f4ba3555-3743-4017-a386-db54d7d4de84"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4602), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0ff0b0c3-2146-4915-9076-51b2f041ec1f"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4604), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8a3e8db7-b4cf-4e87-bbf2-8eefb8045065"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4609), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4e41dc96-968a-4b2c-b4c6-6c51b8db8009"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4611), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("29c626ab-7b03-48a9-90e2-142f945c0deb"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4614), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("251cd4b2-6575-4bd3-a8b9-7e5503e3693e"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4616), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3c56129e-bf19-4fb6-be2c-09f167aa5019"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4621), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("53bcd0fe-4748-44a7-bd45-5cddcf899ced"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4623), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9c726a2d-3c80-45fc-b82b-126f1a065ea7"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4627), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7d14c5e3-3a12-4d1e-b9b2-eebfe0311d24"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4629), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("72a5f069-aa42-4b7c-a4d6-bf9ccd52bbb7"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4936), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bb999f8b-1ae1-4e58-9801-272f9af9115b"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4940), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("907fed9f-03b3-4a73-9e8e-2e51eb6b1fdc"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4942), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("29d7927c-2d1e-4fe9-950b-f362ccfa27cf"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4948), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6381b03f-ba04-4772-bdfd-5c2e69efdff9"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4951), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7fe9aa93-c52a-498b-9859-01908ff281ea"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(5013), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("c1990336-88a4-4d57-a5d2-b9232afaac2c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(5622), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(5622), new byte[] { 165, 54, 209, 30, 39, 34, 16, 114, 181, 216, 155, 191, 214, 227, 188, 63, 175, 201, 64, 60, 128, 2, 245, 6, 230, 201, 251, 191, 67, 144, 170, 117, 146, 165, 104, 76, 47, 95, 253, 228, 93, 130, 242, 48, 33, 149, 126, 183, 154, 10, 20, 76, 71, 94, 219, 229, 5, 87, 140, 202, 26, 235, 134, 194 }, new byte[] { 201, 49, 78, 88, 161, 80, 15, 1, 254, 101, 131, 28, 89, 115, 111, 56, 6, 248, 149, 234, 251, 126, 18, 168, 132, 59, 210, 0, 140, 79, 119, 245, 201, 19, 86, 206, 24, 81, 130, 192, 149, 118, 5, 61, 147, 129, 216, 207, 229, 8, 180, 222, 8, 161, 200, 138, 139, 110, 21, 68, 248, 127, 238, 200, 185, 215, 4, 21, 226, 9, 35, 225, 52, 219, 228, 50, 34, 208, 185, 254, 73, 56, 2, 76, 39, 132, 119, 6, 117, 28, 214, 16, 20, 103, 107, 36, 234, 173, 69, 184, 35, 135, 239, 56, 213, 48, 117, 142, 122, 9, 72, 131, 231, 79, 246, 108, 18, 69, 162, 121, 31, 25, 142, 117, 101, 136, 111, 70 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("e080ba9b-d77b-4b09-bc1f-7631b484032b"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(5748), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(5749), new byte[] { 168, 19, 199, 167, 235, 39, 22, 129, 221, 2, 211, 145, 33, 86, 252, 215, 83, 12, 179, 185, 12, 117, 119, 93, 211, 184, 203, 195, 89, 254, 165, 72, 54, 95, 174, 1, 226, 114, 193, 148, 120, 147, 208, 186, 87, 204, 141, 146, 229, 255, 233, 107, 69, 255, 61, 80, 198, 17, 75, 63, 58, 125, 81, 135 }, new byte[] { 217, 155, 228, 154, 119, 40, 25, 54, 143, 157, 208, 162, 196, 12, 226, 161, 29, 35, 65, 77, 112, 188, 245, 218, 141, 11, 123, 219, 73, 190, 70, 194, 109, 51, 246, 141, 34, 193, 91, 35, 3, 90, 36, 227, 217, 100, 5, 212, 140, 227, 183, 140, 126, 246, 172, 252, 209, 149, 145, 31, 44, 169, 227, 245, 67, 218, 227, 13, 185, 253, 80, 115, 118, 144, 141, 8, 19, 147, 110, 222, 78, 40, 137, 1, 114, 229, 184, 57, 218, 226, 174, 208, 204, 151, 210, 188, 147, 168, 105, 44, 47, 101, 221, 47, 219, 121, 253, 137, 15, 251, 65, 67, 180, 154, 206, 170, 150, 146, 212, 107, 29, 69, 168, 137, 254, 196, 96, 212 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("30b7db03-6426-4940-8d1d-f0c6a4eefa01"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(5836), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(5836), new byte[] { 151, 130, 254, 155, 82, 66, 24, 212, 61, 73, 22, 114, 113, 162, 142, 24, 26, 121, 240, 84, 204, 118, 182, 251, 212, 57, 231, 241, 151, 16, 220, 14, 201, 173, 37, 42, 198, 11, 140, 132, 7, 107, 173, 60, 44, 240, 27, 44, 35, 131, 123, 166, 253, 228, 103, 58, 253, 87, 120, 90, 205, 8, 102, 13 }, new byte[] { 13, 28, 39, 107, 42, 33, 159, 174, 87, 60, 74, 242, 164, 30, 50, 25, 143, 223, 193, 77, 212, 70, 2, 9, 151, 54, 217, 220, 183, 185, 8, 255, 160, 61, 133, 72, 139, 70, 149, 198, 40, 217, 126, 11, 97, 247, 245, 105, 180, 26, 168, 196, 250, 32, 171, 241, 98, 170, 167, 222, 186, 51, 151, 154, 125, 148, 43, 245, 94, 181, 1, 227, 235, 103, 88, 251, 230, 56, 237, 182, 29, 170, 254, 174, 182, 63, 168, 67, 124, 156, 129, 133, 95, 136, 43, 138, 103, 88, 65, 78, 152, 228, 90, 219, 57, 121, 130, 95, 238, 61, 106, 130, 136, 216, 6, 172, 8, 73, 64, 174, 238, 86, 96, 94, 60, 244, 130, 221 } });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations;

/// <inheritdoc />
public partial class Fifth : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropPrimaryKey(
            name: "PK_Board",
            table: "Board");

        migrationBuilder.RenameTable(
            name: "Board",
            newName: "Boards");

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
            oldDefaultValue: "04/09/2024 14:55:21");

        migrationBuilder.AddPrimaryKey(
            name: "PK_Boards",
            table: "Boards",
            column: "EntityId");

        migrationBuilder.CreateTable(
            name: "Books",
            columns: table => new
            {
                EntityId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Books", x => x.EntityId);
            });

        migrationBuilder.CreateTable(
            name: "RBookFranchise",
            columns: table => new
            {
                BookId = table.Column<int>(type: "int", nullable: false),
                FranchiseId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_RBookFranchise", x => new { x.BookId, x.FranchiseId });
                table.ForeignKey(
                    name: "FK_RBookFranchise_Books_BookId",
                    column: x => x.BookId,
                    principalTable: "Books",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_RBookFranchise_Franchises_FranchiseId",
                    column: x => x.FranchiseId,
                    principalTable: "Franchises",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "RBookModel",
            columns: table => new
            {
                BookId = table.Column<int>(type: "int", nullable: false),
                ModelId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_RBookModel", x => new { x.BookId, x.ModelId });
                table.ForeignKey(
                    name: "FK_RBookModel_Books_BookId",
                    column: x => x.BookId,
                    principalTable: "Books",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_RBookModel_Models_ModelId",
                    column: x => x.ModelId,
                    principalTable: "Models",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
            });

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
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a1ab384d-b9b0-4eac-ba4d-935c2c162381"), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8177), new DateTime(2024, 4, 30, 14, 38, 53, 804, DateTimeKind.Utc).AddTicks(8177) });

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

        migrationBuilder.CreateIndex(
            name: "IX_RBookFranchise_FranchiseId",
            table: "RBookFranchise",
            column: "FranchiseId");

        migrationBuilder.CreateIndex(
            name: "IX_RBookModel_ModelId",
            table: "RBookModel",
            column: "ModelId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "RBookFranchise");

        migrationBuilder.DropTable(
            name: "RBookModel");

        migrationBuilder.DropTable(
            name: "Books");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Boards",
            table: "Boards");

        migrationBuilder.RenameTable(
            name: "Boards",
            newName: "Board");

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
            oldDefaultValue: "04/30/2024 16:38:53");

        migrationBuilder.AddPrimaryKey(
            name: "PK_Board",
            table: "Board",
            column: "EntityId");

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
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("21d91dd8-90d5-4e37-a933-6f49eadeeca8"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8548), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8548) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("cef75850-e136-4d11-be17-d1841b6bed87"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8552), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8552) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a60b7c9b-7570-4cb0-b672-cb051525c26d"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8554), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8554) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("475c34e0-07f9-4e95-9640-2789f656c8c3"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8557), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8558) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("451b6901-4e56-4f4e-be26-5fbcd7f70f31"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8559), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8559) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("018335f6-aeb1-4c1b-a041-3801ac48a484"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8562), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8562) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3052e44a-64b6-4c20-9ce3-a43c2b320881"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8563), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8564) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d5013281-0e9f-4eca-9665-681b111e9044"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8567), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8567) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3e2a6b5d-92ec-4553-9962-24f3a1f158a0"), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8569), new DateTime(2024, 4, 9, 12, 55, 21, 965, DateTimeKind.Utc).AddTicks(8569) });

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
    }
}

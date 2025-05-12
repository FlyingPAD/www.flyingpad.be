using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Definitions_Fix : Migration
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
                defaultValue: "05/12/2025 11:10:34",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/11/2025 08:16:01");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4611), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4639), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4643), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d3e4f5a6-b7c8-9d0e-1a2b-3b4c5d6e7f80"), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4646), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4667), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4670), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4672), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4675), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4677), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4679), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4682), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4688), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4693), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4697), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4699), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4702), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4632), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Goal", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4636), "Complete your profile (add name, birthdate)", new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4704), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4707), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4755), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4759), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4764), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4767), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4792), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4794), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4797), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4801), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4803), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4805), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4811), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4816), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4816) });

            migrationBuilder.InsertData(
                table: "AchievementDefinitions",
                columns: new[] { "EntityId", "BusinessId", "Category", "Code", "Created", "CreatedBy", "DoneMessage", "Goal", "IconUrl", "Modified", "ModifiedBy", "Title", "XpReward" },
                values: new object[,]
                {
                    { 33, new Guid("e2a3b4c5-d6e7-8f90-1a2b-3c4d5e6f7a8b"), "level", "Level8Achieved", new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4769), "Administrator", "You reached level 8!", "Reach level 8", null, new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4769), "Administrator", "Level 8 Achieved", 0 },
                    { 34, new Guid("f3b4c5d6-e7f8-901a-2b3c-4d5e6f7a8b9c"), "level", "Level9Achieved", new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4771), "Administrator", "You reached level 9!", "Reach level 9", null, new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4772), "Administrator", "Level 9 Achieved", 0 },
                    { 35, new Guid("a4c5d6e7-f8a9-012b-3c4d-5e6f7a8b9c0d"), "level", "Level10Achieved", new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4774), "Administrator", "You reached level 10!", "Reach level 10", null, new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4774), "Administrator", "Level 10 Achieved", 0 },
                    { 36, new Guid("b5d6e7f8-a9b0-123c-4d5e-6f7a8b9c0d1e"), "level", "Level11Achieved", new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4777), "Administrator", "You reached level 11!", "Reach level 11", null, new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4777), "Administrator", "Level 11 Achieved", 0 },
                    { 37, new Guid("c6e7f8a9-b0c1-234d-5e6f-7a8b9c0d1e2f"), "level", "Level12Achieved", new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4779), "Administrator", "You reached level 12!", "Reach level 12", null, new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4780), "Administrator", "Level 12 Achieved", 0 },
                    { 38, new Guid("d7f8a9b0-c1d2-345e-6f7a-8b9c0d1e2f3a"), "level", "Level13Achieved", new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4782), "Administrator", "You reached level 13!", "Reach level 13", null, new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4782), "Administrator", "Level 13 Achieved", 0 },
                    { 39, new Guid("e8a9b0c1-d2e3-456f-7a8b-9c0d1e2f3a4b"), "level", "Level14Achieved", new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4787), "Administrator", "You reached level 14!", "Reach level 14", null, new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4788), "Administrator", "Level 14 Achieved", 0 },
                    { 40, new Guid("f9b0c1d2-e3f4-567a-8b9c-0d1e2f3a4b5c"), "level", "Level15Achieved", new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4790), "Administrator", "You reached level 15!", "Reach level 15", null, new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4790), "Administrator", "Level 15 Achieved", 0 }
                });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8778), new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8795), new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8799), new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8802), new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8820), new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8823), new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8826), new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8829), new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "MaxExperience", "Modified" },
                values: new object[] { new Guid("a3f1e23c-b7d6-4f8a-9e0f-123456789abc"), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2042), 281, new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "MaxExperience", "MinExperience", "Modified" },
                values: new object[] { new Guid("b2e1c4d5-e6f7-0a1b-2c3d-4e5f6789abcd"), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2049), 518, 282, new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "MaxExperience", "MinExperience", "Modified" },
                values: new object[] { new Guid("c3d2e1f4-a5b6-7c8d-9e0f-abcdef012345"), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2053), 799, 519, new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "MaxExperience", "MinExperience", "Modified" },
                values: new object[] { new Guid("d4e3f2a1-b6c5-8d7e-0f9a-1234bcdef567"), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2056), 1117, 800, new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "MaxExperience", "MinExperience", "Modified" },
                values: new object[] { new Guid("e5f4a3b2-c1d0-9e8f-7d6c-5b4a3c2d1e0f"), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2065), 1468, 1118, new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "MaxExperience", "MinExperience", "Modified" },
                values: new object[] { new Guid("f6a5b4c3-d2e1-0f9a-8b7c-6d5e4f3a2b1c"), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2068), 1850, 1469, new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2068) });

            migrationBuilder.InsertData(
                table: "LevelDefinitions",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "LevelNumber", "MaxExperience", "MinExperience", "Modified", "ModifiedBy" },
                values: new object[,]
                {
                    { 7, new Guid("07b6c5d4-e3f2-1a0b-9c8d-7e6f5a4b3c2d"), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2070), "Administrator", 7, 2261, 1851, new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2070), "Administrator" },
                    { 8, new Guid("18c7d6e5-f4a3-2b1c-8d7e-9f8a7b6c5d4e"), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2072), "Administrator", 8, 2698, 2262, new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2072), "Administrator" },
                    { 9, new Guid("29d8e7f6-a5b4-3c2d-7e8f-0a9b8c7d6e5f"), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2074), "Administrator", 9, 3160, 2699, new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2074), "Administrator" },
                    { 10, new Guid("30e9f8a7-b6c5-4d3e-6f7a-1b2c3d4e5f6a"), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2076), "Administrator", 10, 3646, 3161, new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2076), "Administrator" },
                    { 11, new Guid("41f0a9b8-c7d6-5e4f-7a8b-2c3d4e5f6a7b"), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2078), "Administrator", 11, 4155, 3647, new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2078), "Administrator" },
                    { 12, new Guid("52a1b0c9-d8e7-6f5a-8b9c-3d4e5f6a7b8c"), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2080), "Administrator", 12, 4685, 4156, new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2081), "Administrator" },
                    { 13, new Guid("63b2c1d0-e9f8-7a6b-9c0d-4e5f6a7b8c9d"), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2086), "Administrator", 13, 5236, 4686, new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2086), "Administrator" },
                    { 14, new Guid("74c3d2e1-f0a9-8b7c-0d1e-5f6a7b8c9d0e"), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2088), "Administrator", 14, 5807, 5237, new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2088), "Administrator" },
                    { 15, new Guid("85d4e3f2-a1b0-9c8d-1e2f-6a7b8c9d0e1f"), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2090), "Administrator", 15, null, 5808, new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2090), "Administrator" }
                });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2551), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2568), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2572), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2575), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2603), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2607), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8698), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8705), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8708), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8711), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8714), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8717), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8727), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8729), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8731), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8734), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8736), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8738), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8741), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8743), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8748), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8750), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8752), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8755), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8757), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8757) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "05/11/2025 08:16:01",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/12/2025 11:10:34");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2821), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2919), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2923), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d3e4f5a6-b7c8-9d0e-1f2a-3b4c5d6e7f80"), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2926), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2929), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2950), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2953), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2956), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2958), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2960), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2963), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2965), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2968), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2973), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2976), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2980), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2838), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Goal", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2843), "Complete your profile (add name, birthdate, avatar)", new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2983), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2985), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2987), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2989), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2991), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2996), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2998), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3000), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3002), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3005), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3007), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3010), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3014), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3019), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3319), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3338), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3343), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3346), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3350), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3353), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3355), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3377), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "MaxExperience", "Modified" },
                values: new object[] { new Guid("3f1e2d4c-5b6a-7d8c-9e0f-1a2b3c4d5e6f"), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6678), 99, new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "MaxExperience", "MinExperience", "Modified" },
                values: new object[] { new Guid("7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d"), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6687), 199, 100, new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "MaxExperience", "MinExperience", "Modified" },
                values: new object[] { new Guid("12345678-9abc-def0-1234-56789abcdef0"), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6690), 399, 200, new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "MaxExperience", "MinExperience", "Modified" },
                values: new object[] { new Guid("0fedcba9-8765-4321-0fed-cba987654321"), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6693), 699, 400, new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "MaxExperience", "MinExperience", "Modified" },
                values: new object[] { new Guid("abcdef01-2345-6789-abcd-ef0123456789"), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6695), 999, 700, new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "MaxExperience", "MinExperience", "Modified" },
                values: new object[] { new Guid("09876543-21fe-dcba-9876-54321fedcba0"), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6697), null, 1000, new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4202), new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4222), new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4225), new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4228), new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4249), new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4252), new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(492), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(499), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(502), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(504), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(507), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(510), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(520), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(522), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(525), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(527), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(529), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(535), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(537), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(542), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(544), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(547), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(549), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(551), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(551) });
        }
    }
}

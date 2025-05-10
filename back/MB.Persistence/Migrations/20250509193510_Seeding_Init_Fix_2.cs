using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Seeding_Init_Fix_2 : Migration
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
                defaultValue: "05/09/2025 21:35:09",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/09/2025 21:25:47");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4429), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4454), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4457), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4460), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4461) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4463), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4485), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4488), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4490), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4492), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4495), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4497), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4499), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4501), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4502) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4506), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4508), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4511), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4446), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4450), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4513), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4516), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4518), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4520), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4522), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4527), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4529), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4532), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4534), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4537), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4540), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4542), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4544), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4548), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 469, DateTimeKind.Utc).AddTicks(1741), new DateTime(2025, 5, 9, 19, 35, 9, 469, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7046), new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7061), new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7065), new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7069), new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7072), new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7074), new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7094), new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7096), new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(435), new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(442), new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(444), new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(447), new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(449), new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(451), new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7708), new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7724), new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7728), new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7731), new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7749), new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7753), new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3894), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "Name" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee3"), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3901), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3901), "# New Files" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified", "Name" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee2"), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3904), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3904), "Audio" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3907), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3909), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3911), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3921), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3924), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3926), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3928), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3931), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3933), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3935), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3938), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3943), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3946), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3948), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3950), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3952), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3953) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "05/09/2025 21:25:47",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/09/2025 21:35:09");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9774), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9810), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9813), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9836), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9839), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9842), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9845), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9848), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9851), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9853), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9856), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9861), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9863), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9869), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9871), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9873), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9801), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9805), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9876), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9879), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9881), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9886), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9888), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9891), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9893), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9895), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9898), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9901), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9903), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9913), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9925), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9927), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 50, DateTimeKind.Utc).AddTicks(969), new DateTime(2025, 5, 9, 19, 25, 47, 50, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4638), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4662), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4779), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4784), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4787), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4793), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4815), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9059), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9069), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9072), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9075), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9077), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9080), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(196), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(219), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(223), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(227), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(230), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(234), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8287), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "Name" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee2"), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8295), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8295), "Audio" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified", "Name" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee3"), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8299), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8300), "Document" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8302), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8305), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8308), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8311), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8314), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8333), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8337), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8340), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8343), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8345), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8349), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8352), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8355), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8360), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8363), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8365), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8366) });
        }
    }
}

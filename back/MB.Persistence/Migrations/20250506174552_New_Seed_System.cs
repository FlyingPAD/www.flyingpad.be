using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class New_Seed_System : Migration
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
                defaultValue: "05/06/2025 19:45:51",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/06/2025 07:00:23");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2654), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2680), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2684), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2688), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2711), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2714), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2717), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2720), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2723), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2726), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2728), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2732), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2737), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2740), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2743), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2746), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2672), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2676), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2749), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2751), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2754), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2757), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2762), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2765), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2768), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2772), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2775), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2778), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2792), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2795), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2800), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2803), new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2804) });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name", "Pseudonym" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000001"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(433), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(434), "", "# Unknown Artist", "" },
                    { 2, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000002"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(440), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(440), "", "/ Unknown 2D Animator", "" },
                    { 3, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000003"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(444), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(444), "", "/ Unknown 2D Illustrator", "" },
                    { 4, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000004"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(448), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(448), "", "/ Unknown 3D Animator", "" },
                    { 5, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000005"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(451), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(452), "", "/ Unknown 3D Sculptor", "" },
                    { 6, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000006"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(454), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(455), "", "/ Unknown A.I. User", "" },
                    { 7, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000007"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(463), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(464), "", "/ Unknown Musician", "" },
                    { 8, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000008"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(466), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(467), "", "/ Unknown Photographer", "" },
                    { 9, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000009"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(469), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(470), "", "/ Unknown Sculptor", "" },
                    { 10, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000010"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(472), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(472), "", "/ Unknown Videast", "" },
                    { 11, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000011"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(475), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(475), "", "/ Unknown Writer", "" },
                    { 12, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000012"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(478), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(478), "", "Flying PAD", "" },
                    { 13, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000013"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(481), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(481), "", "Soën9048", "" },
                    { 14, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000014"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(483), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(484), "", "CohesivePanda", "" },
                    { 15, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000015"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(488), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(488), "", "Nobuo Uematsu", "" },
                    { 16, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000016"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(491), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(491), "", "Eichiro Oda", "" },
                    { 17, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000017"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(493), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(494), "", "Masashi Kishimoto", "" },
                    { 18, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000018"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(496), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(496), "", "Dali", "" },
                    { 19, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000019"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(498), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(499), "", "Yoko Shimomura", "" },
                    { 20, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000020"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(501), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(501), "", "Michael Jackson", "" },
                    { 21, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000021"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(503), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(504), "", "CG5", "" },
                    { 22, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000022"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(506), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(506), "", "TryHardNinja", "" },
                    { 23, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000023"), new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(511), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(511), "", "Jacob Collier", "" }
                });

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee1"), new DateTime(2025, 5, 6, 17, 45, 51, 319, DateTimeKind.Utc).AddTicks(6478), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 319, DateTimeKind.Utc).AddTicks(6481), "", "Flying PAD" },
                    { 2, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee2"), new DateTime(2025, 5, 6, 17, 45, 51, 319, DateTimeKind.Utc).AddTicks(6498), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 319, DateTimeKind.Utc).AddTicks(6498), "", "Street Fighter" },
                    { 3, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee3"), new DateTime(2025, 5, 6, 17, 45, 51, 319, DateTimeKind.Utc).AddTicks(6502), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 319, DateTimeKind.Utc).AddTicks(6503), "", "# Unrelated Franchise" }
                });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3250), new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3259), new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3263), new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3267), new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3270), new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3280), new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3286), new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6882), new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6891), new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6895), new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6898), new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6901), new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6910), new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6910) });

            migrationBuilder.InsertData(
                table: "LinkCategories",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa32"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1586), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1588), "", "Audio" },
                    { 2, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa33"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1594), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1595), "", "Audio | Mix & Master" },
                    { 3, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa34"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1598), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1598), "", "Audio | Sound Design" },
                    { 4, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa35"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1602), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1602), "", "Books" },
                    { 5, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa36"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1605), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1605), "", "Books | Harmony" },
                    { 6, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa37"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1608), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1608), "", "Software" },
                    { 7, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa38"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1624), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1624), "", "Software | D.A.W." },
                    { 8, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa39"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1633), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1633), "", "Software | V.S.T." },
                    { 9, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa40"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1636), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1636), "", "Software | Music Notation" },
                    { 10, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa41"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1639), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1639), "", "Tools" },
                    { 11, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa42"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1642), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1642), "", "Tools | Global" },
                    { 12, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa43"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1645), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1645), "", "YouTube" },
                    { 13, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa44"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1648), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1648), "", "YouTube | Artists" },
                    { 14, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa45"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1651), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1651), "", "YouTube | Audio" },
                    { 15, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa46"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1653), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1653), "", "YouTube | Piano & Keys" }
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8785), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8786), "", "KVR", "https://www.kvraudio.com/" },
                    { 2, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa2"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8807), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8807), "", "MuseScore", "https://musescore.com/" },
                    { 3, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8811), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8811), "", "Native Instruments", "https://www.native-instruments.com" },
                    { 4, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa4"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8814), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8814), "", "Steinberg", "https://www.steinberg.net/" },
                    { 5, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa5"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8817), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8817), "", "Clés pour l'harmonie", "http://www.jo-anger-weller.com/102/cles-pour-lharmonie/" },
                    { 6, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa6"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8820), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8821), "", "Google | Metronome", "https://www.google.com/search?q=metronome" },
                    { 7, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa7"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8824), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8824), "", "Google | Stopwatch", "https://www.google.com/search?q=stopwatch" },
                    { 8, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa8"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8827), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8828), "", "Google | Timer", "https://www.google.com/search?q=timer" },
                    { 9, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa9"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8833), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8833), "", "Mangold Project", "https://www.youtube.com/@MangoldProject" },
                    { 10, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8837), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8838), "", "# YouTube", "https://www.youtube.com" },
                    { 11, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8840), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8841), "", "Piano Jazz Concept", "https://www.youtube.com/@Pianojazzconcept" },
                    { 12, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa12"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8843), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8843), "", "Rick Beato", "https://www.youtube.com/@RickBeato" },
                    { 13, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa13"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8846), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8846), "", "Pianote", "https://www.youtube.com/@PianoteOfficial" },
                    { 14, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa14"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8849), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8849), "", "TryHardNinja", "https://www.youtube.com/@TryHardNinja" },
                    { 15, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa15"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8852), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8852), "", "Kyle Allen Music", "https://www.youtube.com/@KyleAllenMusic" },
                    { 16, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa16"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8855), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8855), "", "Ableton", "https://www.youtube.com/@Ableton" },
                    { 17, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa17"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8860), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8860), "", "La Machine à Mixer", "https://www.youtube.com/@lamachineamixer" },
                    { 18, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa18"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8863), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8863), "", "Audiofanzine", "https://www.youtube.com/@audiofanzine" },
                    { 19, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa19"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8865), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8866), "", "Cubase", "https://www.youtube.com/@Cubase" },
                    { 20, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa20"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8868), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8868), "", "Ten Second Songs", "https://www.youtube.com/@TenSecondSongs" },
                    { 21, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa21"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8871), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8871), "", "The Piano Guys", "https://www.youtube.com/@thepianoguys" },
                    { 22, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa22"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8874), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8874), "", "CG5", "https://www.youtube.com/@CG5" },
                    { 23, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa23"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8877), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8877), "", "Native Instruments", "https://www.youtube.com/@NativeInstruments" },
                    { 24, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa24"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8879), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8880), "", "Ken Tamplin Vocal Academy", "https://www.youtube.com/@kentamplin" },
                    { 25, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa25"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8884), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8884), "", "Pentatonix", "https://www.youtube.com/@PTXofficial" },
                    { 26, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa26"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8887), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8887), "", "Recording Revolution", "https://www.youtube.com/@recordingrevolution" },
                    { 27, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa27"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8890), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8891), "", "Jacob Collier", "https://www.youtube.com/@jacobcollier" },
                    { 28, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa28"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8894), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8894), "", "Orchestration Online", "https://www.youtube.com/@OrchestrationOnline" },
                    { 29, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa29"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8897), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8897), "", "Nuendo", "https://www.youtube.com/@Nuendo" },
                    { 30, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa30"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8900), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8900), "", "reFX", "https://www.youtube.com/@reFXaudio" },
                    { 31, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa31"), new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8903), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8903), "", "Steinberg", "https://www.youtube.com/@steinberg" }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee4"), new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3381), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3382), "", "# Unrelated" },
                    { 2, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee5"), new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3394), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3394), "", "# Unknown" },
                    { 3, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee6"), new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3398), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3398), "", "# Super Franchise" },
                    { 4, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee7"), new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3401), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3401), "", "TV" },
                    { 5, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee8"), new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3404), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3405), "", "Radio" },
                    { 6, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee9"), new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3407), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3408), "", "YouTube" },
                    { 7, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeea"), new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3410), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3411), "", "Capcom" },
                    { 8, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeeb"), new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3413), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3413), "", "Square-Enix" },
                    { 9, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeec"), new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3416), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3416), "", "Flying PAD" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "FirstName", "Gender", "LastName", "Modified", "ModifiedBy", "Pseudonym" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee1"), new DateTime(2025, 5, 6, 17, 45, 51, 327, DateTimeKind.Utc).AddTicks(1872), "", "", "", "", "", new DateTime(2025, 5, 6, 17, 45, 51, 327, DateTimeKind.Utc).AddTicks(1873), "", "# Unknown Model" },
                    { 2, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee2"), new DateTime(2025, 5, 6, 17, 45, 51, 327, DateTimeKind.Utc).AddTicks(1881), "", "", "", "", "", new DateTime(2025, 5, 6, 17, 45, 51, 327, DateTimeKind.Utc).AddTicks(1881), "", "# Unrelated Model" },
                    { 3, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee3"), new DateTime(2025, 5, 6, 17, 45, 51, 327, DateTimeKind.Utc).AddTicks(1884), "", "", "Tony", "M", "Van Langenhove", new DateTime(2025, 5, 6, 17, 45, 51, 327, DateTimeKind.Utc).AddTicks(1884), "", "Flying PAD" }
                });

            migrationBuilder.InsertData(
                table: "Moods",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Extension", "Height", "Modified", "ModifiedBy", "Name", "Score", "Size", "Type", "Width" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-0000-0000-0000-000000000001"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5218), "", "In Chords Chart", "jpg", 510, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5219), "", "Major Key Notes", 0, 61206, 1, 359 },
                    { 2, new Guid("aaaaaaaa-0000-0000-0000-000000000002"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5229), "", "7 Notes, 7 Positions", "jpg", 940, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5229), "", "Major Diatonic Scales", 0, 136462, 1, 700 },
                    { 3, new Guid("aaaaaaaa-0000-0000-0000-000000000003"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5233), "", "Fundamental Positions", "jpg", 1361, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5234), "", "Piano Chords", 0, 562138, 1, 868 },
                    { 4, new Guid("aaaaaaaa-0000-0000-0000-000000000004"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5238), "", "5 Notes, 5 Positions", "jpg", 524, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5238), "", "Pentatonic Scales", 0, 74358, 1, 250 },
                    { 5, new Guid("aaaaaaaa-0000-0000-0000-000000000005"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5259), "", "Color Measure", "png", 844, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5259), "", "Intervals", 0, 56324, 1, 556 },
                    { 6, new Guid("aaaaaaaa-0000-0000-0000-000000000006"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5263), "", "Absolute Basics", "png", 255, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5263), "", "Time Measure", 0, 8992, 1, 400 },
                    { 7, new Guid("aaaaaaaa-0000-0000-0000-000000000007"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5266), "", "Natural Order", "webp", 226, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5266), "", "Harmonics", 0, 30964, 1, 600 },
                    { 8, new Guid("aaaaaaaa-0000-0000-0000-000000000008"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5269), "", "Communication is important", "png", 705, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5270), "", "Guitar Vocabulary", 0, 99994, 1, 512 },
                    { 9, new Guid("aaaaaaaa-0000-0000-0000-000000000009"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5273), "", "Diatonic Chords in C Major", "jpg", 1317, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5273), "", "Piano Chords (Diatonic C Major)", 0, 204898, 1, 1199 },
                    { 10, new Guid("aaaaaaaa-0000-0000-0000-00000000000a"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5276), "", "Mmm... You can tell, right ?", "jpg", 900, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5276), "", "Piano Scales", 0, 91482, 1, 695 },
                    { 11, new Guid("aaaaaaaa-0000-0000-0000-00000000000b"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5279), "", "Overview", "gif", 709, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5279), "", "Tessitures", 0, 62391, 1, 1026 },
                    { 12, new Guid("aaaaaaaa-0000-0000-0000-00000000000c"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5283), "", "Circle of Life", "png", 950, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5283), "", "Chord Wheel", 0, 663017, 1, 950 },
                    { 13, new Guid("aaaaaaaa-0000-0000-0000-00000000000d"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5289), "", "...", "jpeg", 480, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5289), "", "The Mix is Almost Perfect", 0, 45254, 1, 640 },
                    { 14, new Guid("aaaaaaaa-0000-0000-0000-00000000000e"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5292), "", "Basic Chords / Different Keys", "jpg", 690, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5292), "", "Guitar Progressions", 0, 167969, 1, 552 },
                    { 15, new Guid("aaaaaaaa-0000-0000-0000-00000000000f"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5295), "", "Les 3, c'est NON !", "jpeg", 960, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5295), "", "Vous le voulez comment votre projet ?", 0, 205144, 1, 720 },
                    { 16, new Guid("aaaaaaaa-0000-0000-0000-000000000010"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5298), "", "1, 2, 3, 4, 5", "jpg", 233, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5299), "", "Fingers Numerotation", 0, 24030, 1, 350 },
                    { 17, new Guid("aaaaaaaa-0000-0000-0000-000000000011"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5302), "", "My actual Keyboard", "jpg", 368, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5302), "", "Roland FP-30", 0, 87596, 1, 1680 },
                    { 18, new Guid("aaaaaaaa-0000-0000-0000-000000000012"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5305), "", "How to build a chord", "jpg", 1109, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5306), "", "Chord Formula's", 0, 221030, 1, 1080 },
                    { 19, new Guid("aaaaaaaa-0000-0000-0000-000000000013"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5309), "", "Valeurs de Temps", "webp", 530, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5309), "", "Time Values", 0, 21922, 1, 640 },
                    { 20, new Guid("aaaaaaaa-0000-0000-0000-000000000014"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5312), "", "Fundamental Positions", "jpg", 909, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5312), "", "Guitar Chords (B)", 0, 57447, 1, 640 },
                    { 21, new Guid("aaaaaaaa-0000-0000-0000-000000000015"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5318), "", "Primary Modes", "jpg", 1552, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5318), "", "Modes starting in C", 0, 111187, 1, 1199 },
                    { 22, new Guid("aaaaaaaa-0000-0000-0000-000000000016"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5321), "", "Good luck finding the good one ...", "jpg", 1913, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5322), "", "Guitar Chords", 0, 633229, 1, 1200 },
                    { 23, new Guid("aaaaaaaa-0000-0000-0000-000000000017"), new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5325), "", "Une approche parmi tant d'autres", "png", 971, new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5325), "", "Intervalles", 0, 69313, 1, 692 }
                });

            migrationBuilder.InsertData(
                table: "Moods",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Duration", "Extension", "Video_Height", "Modified", "ModifiedBy", "Name", "Score", "Video_Size", "Type", "Video_Width" },
                values: new object[] { 55, new Guid("cccccccc-cccc-cccc-cccc-cccccccccc55"), new DateTime(2025, 5, 6, 17, 45, 51, 356, DateTimeKind.Utc).AddTicks(6830), "", "Bendy & The Ink Machine", 64, "mp4", 360, new DateTime(2025, 5, 6, 17, 45, 51, 356, DateTimeKind.Utc).AddTicks(6831), "", "BATIM - Build our Machine", 0, 5091239, 2, 640 });

            migrationBuilder.InsertData(
                table: "Moods",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Extension", "Modified", "ModifiedBy", "Name", "Score", "Type", "Url" },
                values: new object[] { 85, new Guid("cccccccc-cccc-cccc-cccc-cccccccccc85"), new DateTime(2025, 5, 6, 17, 45, 51, 356, DateTimeKind.Utc).AddTicks(9005), "", "...", "", new DateTime(2025, 5, 6, 17, 45, 51, 356, DateTimeKind.Utc).AddTicks(9006), "", "Mario Bros 3 Cover", 0, 4, "WWUxrTdjqg0" });

            migrationBuilder.InsertData(
                table: "Styles",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000001"), new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8872), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8875), "", "2D" },
                    { 2, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000002"), new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8888), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8889), "", "2D Animation" },
                    { 3, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000003"), new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8893), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8893), "", "3D" },
                    { 4, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000004"), new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8910), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8911), "", "3D Animation" },
                    { 5, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000005"), new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8914), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8915), "", "Architecture" },
                    { 6, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000006"), new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8937), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8938), "", "Writer" },
                    { 7, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000007"), new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8941), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8942), "", "Music" },
                    { 8, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000008"), new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8945), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8945), "", "Photo" },
                    { 9, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000009"), new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8948), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8949), "", "Video" },
                    { 10, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000010"), new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8952), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8952), "", "Video Games" }
                });

            migrationBuilder.InsertData(
                table: "TagCategories",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee1"), new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6188), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6189), "", "#" },
                    { 2, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee2"), new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6200), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6200), "", "# File" },
                    { 3, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee3"), new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6204), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6204), "", "# File ext. | Doc." },
                    { 4, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee4"), new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6216), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6216), "", "# File ext. | Image" },
                    { 5, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee5"), new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6220), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6220), "", "# File ext. | Video" },
                    { 6, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee6"), new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6224), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6225), "", "# File Format" },
                    { 7, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee7"), new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6229), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6229), "", "# File Render" },
                    { 8, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee8"), new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6233), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6233), "", "Music Genre" },
                    { 9, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee9"), new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6237), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6237), "", "Music Theory" },
                    { 10, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee10"), new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6240), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6240), "", "Keys" },
                    { 11, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee11"), new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6244), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6244), "", "Brass" },
                    { 12, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee12"), new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6251), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6251), "", "Strings" },
                    { 13, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee13"), new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6254), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6254), "", "Percussions" },
                    { 14, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee14"), new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6258), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6258), "", "Woodwinds" },
                    { 15, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee15"), new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6262), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6262), "", "Audio" },
                    { 16, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee16"), new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6265), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6266), "", "Fun" },
                    { 17, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee17"), new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6269), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6269), "", "Guitar" }
                });

            migrationBuilder.InsertData(
                table: "TaskCategories",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee18"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8008), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8009), "", "PAD Mobile" },
                    { 2, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee19"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8015), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8015), "", "PAD Cave" },
                    { 3, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee20"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8019), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8019), "", "PAD Kids" },
                    { 4, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee21"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8022), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8022), "", "Shopping" },
                    { 5, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee22"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8025), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8026), "", "Work" }
                });

            migrationBuilder.InsertData(
                table: "RArtistStyle",
                columns: new[] { "ArtistId", "StyleId" },
                values: new object[,]
                {
                    { 12, 7 },
                    { 12, 9 },
                    { 13, 9 },
                    { 14, 9 },
                    { 15, 9 },
                    { 16, 6 },
                    { 17, 6 },
                    { 18, 1 },
                    { 19, 2 },
                    { 20, 7 },
                    { 21, 7 },
                    { 22, 7 },
                    { 23, 7 }
                });

            migrationBuilder.InsertData(
                table: "RFranchiseMedia",
                columns: new[] { "FranchiseId", "MediaId" },
                values: new object[,]
                {
                    { 1, 9 },
                    { 2, 7 },
                    { 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "RFranchiseModel",
                columns: new[] { "FranchiseId", "ModelId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "RLinkCategory",
                columns: new[] { "LinkCategoryId", "LinkId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 8, 1 },
                    { 6, 2 },
                    { 9, 2 },
                    { 6, 3 },
                    { 8, 3 },
                    { 6, 4 },
                    { 4, 5 },
                    { 5, 5 },
                    { 10, 6 },
                    { 10, 7 },
                    { 10, 8 },
                    { 12, 9 },
                    { 15, 9 },
                    { 12, 10 },
                    { 12, 11 },
                    { 15, 11 },
                    { 12, 12 },
                    { 12, 13 },
                    { 12, 14 },
                    { 13, 14 },
                    { 12, 15 },
                    { 12, 16 },
                    { 12, 17 },
                    { 12, 18 },
                    { 12, 19 },
                    { 12, 20 },
                    { 12, 21 },
                    { 12, 22 },
                    { 12, 23 },
                    { 12, 24 },
                    { 12, 25 },
                    { 1, 26 },
                    { 2, 26 },
                    { 12, 26 },
                    { 14, 26 },
                    { 12, 27 },
                    { 13, 27 },
                    { 12, 28 },
                    { 12, 29 },
                    { 12, 30 },
                    { 12, 31 }
                });

            migrationBuilder.InsertData(
                table: "RMoodArtist",
                columns: new[] { "ArtistId", "MoodId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 12, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 1, 20 },
                    { 1, 21 },
                    { 1, 22 },
                    { 1, 23 },
                    { 1, 55 },
                    { 1, 85 }
                });

            migrationBuilder.InsertData(
                table: "RMoodModel",
                columns: new[] { "ModelId", "MoodId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 3, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 1, 20 },
                    { 1, 21 },
                    { 1, 22 },
                    { 1, 23 },
                    { 1, 55 },
                    { 1, 85 }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name", "TagCategoryId" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee1"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3176), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3177), "", "# All Files", 1 },
                    { 2, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee2"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3184), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3185), "", "Audio", 2 },
                    { 3, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee3"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3195), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3195), "", "Document", 2 },
                    { 4, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee4"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3198), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3199), "", "Image", 2 },
                    { 5, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee5"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3201), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3202), "", "Video", 2 },
                    { 6, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee6"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3204), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3205), "", "*.txt", 3 },
                    { 7, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee7"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3208), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3208), "", "*.bmp", 4 },
                    { 8, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee8"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3211), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3211), "", "*.gif", 4 },
                    { 9, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee9"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3214), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3214), "", "*.jpeg", 4 },
                    { 10, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee10"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3216), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3217), "", "*.jpg", 4 },
                    { 11, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee11"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3222), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3223), "", "*.png", 4 },
                    { 12, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee12"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3225), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3226), "", "*.webp", 4 },
                    { 13, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee13"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3228), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3229), "", "*.mp4", 5 },
                    { 14, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee14"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3231), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3231), "", "*.webm", 5 },
                    { 15, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee15"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3235), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3235), "", "Landscape", 6 },
                    { 16, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee16"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3238), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3238), "", "Landscape (16:9)", 6 },
                    { 17, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee17"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3241), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3241), "", "Portrait", 6 },
                    { 18, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee18"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3244), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3244), "", "Portrait (16:9)", 6 },
                    { 19, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee19"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3249), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3250), "", "Square", 6 },
                    { 20, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee20"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3253), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3253), "", "2D", 7 },
                    { 21, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee21"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3256), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3257), "", "2D | Anim", 7 },
                    { 22, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee22"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3260), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3260), "", "3D", 7 },
                    { 23, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee23"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3263), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3263), "", "3D | Anim", 7 },
                    { 24, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee24"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3267), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3267), "", "Photo", 7 },
                    { 25, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee25"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3270), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3271), "", "Photo | Anim", 7 },
                    { 26, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee26"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3274), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3274), "", "E.D.M.", 8 },
                    { 27, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee27"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3280), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3280), "", "Jazz", 8 },
                    { 28, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee28"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3283), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3283), "", "Metal", 8 },
                    { 29, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee29"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3285), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3286), "", "Orchestral", 8 },
                    { 30, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee30"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3288), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3289), "", "Pop Music", 8 },
                    { 31, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee31"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3291), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3292), "", "Rap", 8 },
                    { 32, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee32"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3294), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3294), "", "Rock", 8 },
                    { 33, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee33"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3297), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3297), "", "Traditional", 8 },
                    { 34, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee34"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3301), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3301), "", "# Music Theory", 9 },
                    { 35, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee35"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3306), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3306), "", "# Harmony", 9 },
                    { 36, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee36"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3309), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3309), "", "Chords", 9 },
                    { 37, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee37"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3312), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3312), "", "Harmonics", 9 },
                    { 38, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee38"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3315), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3315), "", "Intervals", 9 },
                    { 39, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee39"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3317), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3318), "", "Rythm", 9 },
                    { 40, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee40"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3320), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3321), "", "Scales", 9 },
                    { 41, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee41"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3323), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3323), "", "Modes", 9 },
                    { 42, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee42"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3326), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3326), "", "# Keys", 10 },
                    { 43, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee43"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3331), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3332), "", "Piano", 10 },
                    { 44, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee44"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3334), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3334), "", "# Brass", 11 },
                    { 45, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee45"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3337), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3337), "", "Trombone", 11 },
                    { 46, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee46"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3340), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3340), "", "# Strings", 12 },
                    { 47, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee47"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3342), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3343), "", "Violin", 12 },
                    { 48, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee48"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3345), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3346), "", "# Percussions", 13 },
                    { 49, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee49"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3348), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3348), "", "Drums", 13 },
                    { 50, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee50"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3351), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3351), "", "# Woodwinds", 14 },
                    { 51, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee51"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3356), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3356), "", "Clarinet", 14 },
                    { 52, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee52"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3359), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3359), "", "# Audio", 15 },
                    { 53, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee53"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3362), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3362), "", "Mixing", 15 },
                    { 54, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee54"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3365), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3366), "", "Mastering", 15 },
                    { 55, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee55"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3369), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3369), "", "Recording", 15 },
                    { 56, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee56"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3371), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3372), "", "Production", 15 },
                    { 57, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee57"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3374), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3374), "", "Sound Design", 15 },
                    { 58, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee58"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3377), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3377), "", "Memes", 16 },
                    { 59, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee59"), new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3382), "", "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3382), "", "# Guitar", 17 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "DateEnd", "DateStart", "Description", "Modified", "ModifiedBy", "Name", "TaskCategoryId" },
                values: new object[] { 1, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee23"), new DateTime(2025, 5, 6, 17, 45, 51, 354, DateTimeKind.Utc).AddTicks(2449), "", new DateTime(2025, 5, 6, 17, 45, 51, 354, DateTimeKind.Utc).AddTicks(2439), new DateTime(2025, 5, 6, 17, 45, 51, 354, DateTimeKind.Utc).AddTicks(2438), "", new DateTime(2025, 5, 6, 17, 45, 51, 354, DateTimeKind.Utc).AddTicks(2450), "", "Check Mails", 5 });

            migrationBuilder.InsertData(
                table: "RMoodTag",
                columns: new[] { "MoodId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 4 },
                    { 1, 10 },
                    { 1, 17 },
                    { 1, 34 },
                    { 2, 1 },
                    { 2, 4 },
                    { 2, 10 },
                    { 2, 17 },
                    { 2, 34 },
                    { 2, 59 },
                    { 3, 1 },
                    { 3, 4 },
                    { 3, 10 },
                    { 3, 17 },
                    { 3, 34 },
                    { 3, 43 },
                    { 4, 1 },
                    { 4, 4 },
                    { 4, 10 },
                    { 4, 17 },
                    { 4, 34 },
                    { 4, 59 },
                    { 5, 1 },
                    { 5, 4 },
                    { 5, 11 },
                    { 5, 17 },
                    { 5, 34 },
                    { 6, 1 },
                    { 6, 4 },
                    { 6, 11 },
                    { 6, 15 },
                    { 6, 34 },
                    { 7, 1 },
                    { 7, 4 },
                    { 7, 12 },
                    { 7, 15 },
                    { 7, 34 },
                    { 8, 1 },
                    { 8, 4 },
                    { 8, 11 },
                    { 8, 17 },
                    { 8, 34 },
                    { 8, 59 },
                    { 9, 1 },
                    { 9, 4 },
                    { 9, 10 },
                    { 9, 17 },
                    { 9, 34 },
                    { 9, 43 },
                    { 10, 1 },
                    { 10, 4 },
                    { 10, 10 },
                    { 10, 17 },
                    { 10, 34 },
                    { 10, 43 },
                    { 11, 1 },
                    { 11, 4 },
                    { 11, 8 },
                    { 11, 15 },
                    { 11, 34 },
                    { 12, 1 },
                    { 12, 4 },
                    { 12, 11 },
                    { 12, 19 },
                    { 12, 34 },
                    { 13, 1 },
                    { 13, 4 },
                    { 13, 9 },
                    { 13, 15 },
                    { 13, 58 },
                    { 14, 1 },
                    { 14, 4 },
                    { 14, 10 },
                    { 14, 17 },
                    { 14, 59 },
                    { 15, 1 },
                    { 15, 4 },
                    { 15, 9 },
                    { 15, 17 },
                    { 16, 1 },
                    { 16, 4 },
                    { 16, 10 },
                    { 16, 15 },
                    { 16, 43 },
                    { 17, 1 },
                    { 17, 4 },
                    { 17, 10 },
                    { 17, 15 },
                    { 17, 43 },
                    { 18, 1 },
                    { 18, 4 },
                    { 18, 10 },
                    { 18, 17 },
                    { 19, 1 },
                    { 19, 4 },
                    { 19, 12 },
                    { 19, 15 },
                    { 20, 1 },
                    { 20, 4 },
                    { 20, 10 },
                    { 20, 17 },
                    { 20, 59 },
                    { 21, 1 },
                    { 21, 4 },
                    { 21, 10 },
                    { 21, 15 },
                    { 22, 1 },
                    { 22, 4 },
                    { 22, 10 },
                    { 22, 17 },
                    { 22, 59 },
                    { 23, 1 },
                    { 23, 4 },
                    { 23, 11 },
                    { 23, 17 },
                    { 55, 1 },
                    { 55, 15 },
                    { 55, 16 },
                    { 55, 43 },
                    { 85, 1 },
                    { 85, 15 },
                    { 85, 16 },
                    { 85, 43 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 16, 6 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 21, 7 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 22, 7 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 23, 7 });

            migrationBuilder.DeleteData(
                table: "RFranchiseMedia",
                keyColumns: new[] { "FranchiseId", "MediaId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "RFranchiseMedia",
                keyColumns: new[] { "FranchiseId", "MediaId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "RFranchiseMedia",
                keyColumns: new[] { "FranchiseId", "MediaId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "RFranchiseModel",
                keyColumns: new[] { "FranchiseId", "ModelId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "RFranchiseModel",
                keyColumns: new[] { "FranchiseId", "ModelId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 15, 11 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 13 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 14 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 13, 14 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 15 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 16 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 17 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 18 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 19 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 20 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 21 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 22 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 23 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 24 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 25 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 1, 26 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 2, 26 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 26 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 14, 26 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 27 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 13, 27 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 28 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 29 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 30 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 31 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 55 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 85 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 55 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 85 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 1, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 2, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 2, 59 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 3, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 3, 43 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 4, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 4, 59 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 5, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 5, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 6, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 6, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 7, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 7, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 8, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 8, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 8, 59 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 9, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 9, 43 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 10, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 10, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 10, 43 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 11, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 11, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 12, 19 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 12, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 13, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 13, 58 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 14, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 14, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 14, 59 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 15, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 16, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 16, 43 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 17, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 17, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 17, 43 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 18, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 18, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 19, 12 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 19, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 20, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 20, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 20, 59 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 21, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 21, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 22, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 22, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 22, 59 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 23, 11 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 23, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 55, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 55, 16 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 55, 43 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 85, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 85, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 85, 16 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 85, 43 });

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "05/06/2025 07:00:23",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/06/2025 19:45:51");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6222), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6251), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6255), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6258), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6279), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6279) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6283), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6286), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6290), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6292), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6295), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6297), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6301), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6306), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6308), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6408), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6411), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6243), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6247), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6413), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6416), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6418), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6420), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6425), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6428), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6430), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6433), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6436), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6439), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6442), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6445), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6445) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6450), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6453), new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7176), new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7194), new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7198), new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7201), new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7204), new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7206), new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7226), new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7228), new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1108), new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1117), new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1120), new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1123), new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1126), new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1128), new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1128) });
        }
    }
}

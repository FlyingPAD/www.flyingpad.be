using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Achievements_Refactoring : Migration
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
                defaultValue: "05/10/2025 11:37:07",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/10/2025 05:01:48");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "AchievementDefinitions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "OfficialMember", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8067), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "NoviceBass", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8114), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "IntermediateBass", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8117), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "AdvancedBass", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8120), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "ExpertBass", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8123), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "MasterBass", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8126), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "NoviceAlto", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8129), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "IntermediateAlto", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8131), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "AdvancedAlto", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8136), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "ExpertAlto", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8139), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "MasterAlto", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8141), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "NoviceTreble", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8143), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "IntermediateTreble", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8146), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "AdvancedTreble", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8148), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "ExpertTreble", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8151), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "MasterTreble", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8154), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "EmailVerified", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8090), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "ProfileCompleted", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8111), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "Level2Achieved", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8213), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "Level3Achieved", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8218), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "Level4Achieved", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8221), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "Level5Achieved", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8224), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "Level6Achieved", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8226), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "Level7Achieved", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8228), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "WoodLeague", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8231), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "StoneLeague", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8233), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "BronzeLeague", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8238), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "SilverLeague", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8241), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "CrystalLeague", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8243), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "EliteLeague", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8245), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "ChampionLeague", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8249), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Code", "Created", "Modified" },
                values: new object[] { "LegendLeague", new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8253), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4217), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4236), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4256), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4260), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4263), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4266), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4268), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4271), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7337), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7345), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7355), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7358), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7360), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7418), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9255), new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9274), new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9278), new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9281), new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9302), new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9305), new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5866), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5874), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5878), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5882), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5885), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5889), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5899), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5902), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5905), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5908), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5910), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5913), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5917), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5919), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5924), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5927), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5929), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5932), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5934), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5934) });

            migrationBuilder.CreateIndex(
                name: "IX_AchievementDefinitions_Code",
                table: "AchievementDefinitions",
                column: "Code",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AchievementDefinitions_Code",
                table: "AchievementDefinitions");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "AchievementDefinitions");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "05/10/2025 05:01:48",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/10/2025 11:37:07");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5158), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5183), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5186), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5206), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5210), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5212), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5215), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5218), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5220), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5222), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5226), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5232), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5234), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5236), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5238), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5241), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5174), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5179), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5243), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5245), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5248), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5254), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5257), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5260), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5262), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5278), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5281), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5284), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5286), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5291), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5293), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5296), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(767), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(794), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(801), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(806), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(811), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(816), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(841), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(846), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6644), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6660), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6665), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6672), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6676), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6681), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3434), new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3452), new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3456), new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3459), new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3462), new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3465), new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(244), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(275), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(278), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(281), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(285), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(288), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(290), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(292), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(295), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(300), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(302), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(305), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(308), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(310), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(313), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(315), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(318), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(324), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(327), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(327) });
        }
    }
}

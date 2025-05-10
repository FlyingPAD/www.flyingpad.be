using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Seeding_Init_Fix_5 : Migration
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
                defaultValue: "05/09/2025 22:07:43",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/09/2025 21:41:48");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9768), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b1e2c3d4-f5a6-7b8c-9d0e-1f2a3b4c5d6e"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9811), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c2d3e4f5-a6b7-8c9d-0e1f-2a3b4c5d6e7f"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9814), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d3e4f5a6-b7c8-9d0e-1f2a-3b4c5d6e7f80"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9818), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e4f5a6b7-c8d9-0e1f-2a3b-4c5d6e7f8091"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9820), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f5a6b7c8-d9e0-1f2a-3b4c-5d6e7f8091a2"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9823), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a6b7c8d9-e0f1-2a3b-4c5d-6e7f8091a2b3"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9826), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b7c8d9e0-f1a2-3b4c-5d6e-7f8091a2b3c4"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9831), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c8d9e0f1-a2b3-4c5d-6e7f-8091a2b3c4d5"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9834), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d9e0f1a2-b3c4-5d6e-7f80-91a2b3c4d5e6"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9836), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e0f1a2b3-c4d5-6e7f-8091-a2b3c4d5e6f7"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9838), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f1a2b3c4-d5e6-7f80-91a2-b3c4d5e6f7a8"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9840), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a2b3c4d5-e6f7-8091-a2b3-c4d5e6f7a8b9"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9842), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b3c4d5e6-f7a8-091a-2b3c-4d5e6f7a8b9c"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9845), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c4d5e6f7-a8b9-0a1b-3c4d-5e6f7a8b9c0d"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9847), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d5e6f7a8-b9c0-1a2b-3c4d-5e6f7a8b9c0d"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9852), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9c2f1e4a-3d7b-4f8c-9a07-1b2c3d4e5f60"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9805), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ac5f6d7b-8c9d-4e0f-1a2b-3c4d5e6f7a8b"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9808), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e6f7a8b9-c0d1-2a3b-4c5d-6e7f8091a2b3"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9854), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f7a8b9c0-d1e2-3a4b-5c6d-7e8f9012a3b4"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9857), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a8b9c0d1-e2f3-4a5b-6c7d-8e9f0123b4c5"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9859), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b9c0d1e2-f3a4-5b6c-7d8e-9f0123b4c5d6"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9861), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c0d1e2f3-a4b5-6c7d-8e9f-0123b4c5d6e7"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9864), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d1e2f3a4-b5c6-7d8e-9f01-234b5c6d7e8f"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9916), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e2f3a4b5-c6d7-8e9f-0123-4b5c6d7e8f90"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9919), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f3a4b5c6-d7e8-9f01-2345-c6d7e8f901a2"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9925), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a4b5c6d7-e8f9-0123-4567-d7e8f901a2b3"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9928), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b5c6d7e8-f901-2345-6789-e8f901a2b3c4"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9931), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c6d7e8f9-0123-4567-89a0-f901a2b3c4d5"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9934), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d7e8f901-2345-6789-a0b1-0123c4d5e6f7"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9936), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e8f901a2-3456-789a-0b1c-1234d5e6f7a8"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9938), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f901a2b3-4567-89a0-b1c2-2345e6f7a8b9"), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9940), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 215, DateTimeKind.Utc).AddTicks(7171), new DateTime(2025, 5, 9, 20, 7, 43, 215, DateTimeKind.Utc).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a12f4d56-3b78-4c9e-9a1d-2e3f4b5c6d7e"), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(361), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b23e5c67-4c89-5daf-0b2e-3f4a5c6d7e8f"), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(381), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c34f6d78-5da0-6ebf-1c3f-4a5b6c7d8e9f"), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(386), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d45a7e89-6eb1-7fc0-2d4f-5b6c7d8e9f0a"), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(389), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e56b8f9a-7fc2-8ad1-3e5f-6c7d8e9f0a1b"), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(392), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f67c9fab-8ad3-9be2-4f6f-7d8e9f0a1b2c"), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(395), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a78d0abc-9be4-acf3-5f7f-8e9f0a1b2c3d"), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(397), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b89e1bcd-acf5-bd04-6f8f-9f0a1b2c3d4e"), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(417), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3f1e2d4c-5b6a-7d8c-9e0f-1a2b3c4d5e6f"), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3870), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d"), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3877), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("12345678-9abc-def0-1234-56789abcdef0"), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3881), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0fedcba9-8765-4321-0fed-cba987654321"), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3883), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("abcdef01-2345-6789-abcd-ef0123456789"), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3885), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("09876543-21fe-dcba-9876-54321fedcba0"), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3887), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3f1b2d5a-7e89-4c11-a2f3-1d4b6c7e8f90"), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4539), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b4c3d2e1-5f6a-4b7c-8d9e-0a1b2c3d4e5f"), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4570), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0dda8c71-8f2a-4c99-94b1-9adf3e2c5a7b"), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4573), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a1b2c3d4-e5f6-7890-ab12-cd34ef56ab79"), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4576), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("11223344-5566-7788-99aa-bbccddeeff11"), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4579), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("22334455-6677-8899-aabb-ccddeeff2233"), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4582), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3f1b2d5a-7e89-4c11-a2f3-1d4b6c7e8f90"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(762), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b4c3d2e1-5f6a-4b7c-8d9e-0a1b2c3d4e5f"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(769), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7e6d5c4b-3a2f-1e0d-9c8b-7a6f5e4d3c2b"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(771), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1a2b3c4d-5e6f-7081-92a3-b4c5d6e7f8a9"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(781), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0f9e8d7c-6b5a-4c3d-2e1f-0a9b8c7d6e5f"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(784), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("123e4567-e89b-12d3-a456-426614174000"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(787), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9abcdef0-1234-5678-9abc-def012345678"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(789), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fedcba98-7654-3210-fedc-ba9876543210"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(791), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0a1b2c3d-4e5f-6071-8273-94a5b6c7d8e9"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(793), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("11223344-5566-7788-99aa-bbccddeeff00"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(795), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("00ffeedd-ccbb-aaff-8877-665544332211"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(797), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("abcdef01-2345-6789-abcd-ef0123456789"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(802), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("56789abc-def0-1234-5678-9abcdef01234"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(805), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("43210fed-cba9-8765-4321-0fedcba98765"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(807), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a1b2c3d4-e5f6-7890-ab12-cd34ef56ab78"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(809), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("87654321-0fed-cba9-8765-43210fedcba9"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(811), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("deadbeef-0000-1111-2222-333344445555"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(813), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("faceb00c-1234-5678-9abc-def123456789"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(816), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cafebabe-0001-0002-0003-000400050006"), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(831), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(831) });
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
                defaultValue: "05/09/2025 21:41:48",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/09/2025 22:07:43");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6430), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000002"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6460), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000003"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6463), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000004"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6466), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000005"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6469), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000006"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6472), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000007"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6477), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000008"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6480), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000009"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6482), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000010"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6486), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000011"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6488), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000012"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6490), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000013"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6492), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000014"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6495), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000015"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6499), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000016"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6501), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000017"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6454), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000018"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6457), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000019"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6504), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000020"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6507), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000021"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6509), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000022"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6511), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000023"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6514), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000024"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6516), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000025"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6521), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000026"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6524), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000027"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6526), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000028"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6529), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000029"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6531), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000030"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6533), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000031"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6536), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000032"), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6538), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 865, DateTimeKind.Utc).AddTicks(4911), new DateTime(2025, 5, 9, 19, 41, 48, 865, DateTimeKind.Utc).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000101"), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8274), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000102"), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8290), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000103"), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8293), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000104"), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8297), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000105"), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8300), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000106"), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8302), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000107"), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8305), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000108"), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8315), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1913), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1920), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1924), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1926), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("10000000-0000-0000-0000-000000000005"), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1928), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("10000000-0000-0000-0000-000000000006"), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1931), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee1"), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8156), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee2"), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8179), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee3"), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8186), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee4"), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8193), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee5"), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8199), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee6"), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8220), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee1"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(161), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee3"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(196), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee2"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(203), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee4"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(207), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee5"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(213), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee6"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(218), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee7"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(224), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee8"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(240), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee9"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(246), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee10"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(252), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee11"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(258), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee12"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(263), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee13"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(268), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee14"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(272), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee15"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(276), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee16"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(285), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee17"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(290), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee18"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(294), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee19"), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(298), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(298) });
        }
    }
}

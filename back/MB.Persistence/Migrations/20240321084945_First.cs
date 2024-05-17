using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MB.Persistence.Migrations;

/// <inheritdoc />
public partial class First : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Artists",
            columns: table => new
            {
                EntityId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                Pseudonym = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Artists", x => x.EntityId);
            });

        migrationBuilder.CreateTable(
            name: "Board",
            columns: table => new
            {
                EntityId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Board", x => x.EntityId);
            });

        migrationBuilder.CreateTable(
            name: "Franchises",
            columns: table => new
            {
                EntityId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Franchises", x => x.EntityId);
            });

        migrationBuilder.CreateTable(
            name: "LinkCategories",
            columns: table => new
            {
                EntityId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_LinkCategories", x => x.EntityId);
            });

        migrationBuilder.CreateTable(
            name: "Links",
            columns: table => new
            {
                EntityId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Links", x => x.EntityId);
            });

        migrationBuilder.CreateTable(
            name: "Medias",
            columns: table => new
            {
                EntityId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Medias", x => x.EntityId);
            });

        migrationBuilder.CreateTable(
            name: "Models",
            columns: table => new
            {
                EntityId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                Pseudonym = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Models", x => x.EntityId);
            });

        migrationBuilder.CreateTable(
            name: "Moods",
            columns: table => new
            {
                EntityId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Type = table.Column<int>(type: "int", nullable: false),
                Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Score = table.Column<int>(type: "int", nullable: false),
                Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                Document_Size = table.Column<int>(type: "int", nullable: true),
                Size = table.Column<int>(type: "int", nullable: true),
                Width = table.Column<int>(type: "int", nullable: true),
                Height = table.Column<int>(type: "int", nullable: true),
                Video_Size = table.Column<int>(type: "int", nullable: true),
                Video_Width = table.Column<int>(type: "int", nullable: true),
                Video_Height = table.Column<int>(type: "int", nullable: true),
                Duration = table.Column<int>(type: "int", nullable: true),
                Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Moods", x => x.EntityId);
            });

        migrationBuilder.CreateTable(
            name: "Styles",
            columns: table => new
            {
                EntityId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Styles", x => x.EntityId);
            });

        migrationBuilder.CreateTable(
            name: "TagCategories",
            columns: table => new
            {
                EntityId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_TagCategories", x => x.EntityId);
            });

        migrationBuilder.CreateTable(
            name: "TaskCategories",
            columns: table => new
            {
                EntityId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_TaskCategories", x => x.EntityId);
            });

        migrationBuilder.CreateTable(
            name: "Users",
            columns: table => new
            {
                EntityId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                Role = table.Column<int>(type: "int", nullable: false),
                BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Users", x => x.EntityId);
            });

        migrationBuilder.CreateTable(
            name: "RLinkArtist",
            columns: table => new
            {
                LinkId = table.Column<int>(type: "int", nullable: false),
                ArtistId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_RLinkArtist", x => new { x.LinkId, x.ArtistId });
                table.ForeignKey(
                    name: "FK_RLinkArtist_Artists_ArtistId",
                    column: x => x.ArtistId,
                    principalTable: "Artists",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_RLinkArtist_Links_LinkId",
                    column: x => x.LinkId,
                    principalTable: "Links",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "RLinkCategory",
            columns: table => new
            {
                LinkId = table.Column<int>(type: "int", nullable: false),
                LinkCategoryId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_RLinkCategory", x => new { x.LinkId, x.LinkCategoryId });
                table.ForeignKey(
                    name: "FK_RLinkCategory_LinkCategories_LinkCategoryId",
                    column: x => x.LinkCategoryId,
                    principalTable: "LinkCategories",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_RLinkCategory_Links_LinkId",
                    column: x => x.LinkId,
                    principalTable: "Links",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "RFranchiseMedia",
            columns: table => new
            {
                FranchiseId = table.Column<int>(type: "int", nullable: false),
                MediaId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_RFranchiseMedia", x => new { x.FranchiseId, x.MediaId });
                table.ForeignKey(
                    name: "FK_RFranchiseMedia_Franchises_FranchiseId",
                    column: x => x.FranchiseId,
                    principalTable: "Franchises",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_RFranchiseMedia_Medias_MediaId",
                    column: x => x.MediaId,
                    principalTable: "Medias",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "RFranchiseModel",
            columns: table => new
            {
                FranchiseId = table.Column<int>(type: "int", nullable: false),
                ModelId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_RFranchiseModel", x => new { x.FranchiseId, x.ModelId });
                table.ForeignKey(
                    name: "FK_RFranchiseModel_Franchises_FranchiseId",
                    column: x => x.FranchiseId,
                    principalTable: "Franchises",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_RFranchiseModel_Models_ModelId",
                    column: x => x.ModelId,
                    principalTable: "Models",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "RLinkModel",
            columns: table => new
            {
                LinkId = table.Column<int>(type: "int", nullable: false),
                ModelId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_RLinkModel", x => new { x.LinkId, x.ModelId });
                table.ForeignKey(
                    name: "FK_RLinkModel_Links_LinkId",
                    column: x => x.LinkId,
                    principalTable: "Links",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_RLinkModel_Models_ModelId",
                    column: x => x.ModelId,
                    principalTable: "Models",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "RMoodArtist",
            columns: table => new
            {
                MoodId = table.Column<int>(type: "int", nullable: false),
                ArtistId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_RMoodArtist", x => new { x.MoodId, x.ArtistId });
                table.ForeignKey(
                    name: "FK_RMoodArtist_Artists_ArtistId",
                    column: x => x.ArtistId,
                    principalTable: "Artists",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_RMoodArtist_Moods_MoodId",
                    column: x => x.MoodId,
                    principalTable: "Moods",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "RMoodFranchise",
            columns: table => new
            {
                MoodId = table.Column<int>(type: "int", nullable: false),
                FranchiseId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_RMoodFranchise", x => new { x.MoodId, x.FranchiseId });
                table.ForeignKey(
                    name: "FK_RMoodFranchise_Franchises_FranchiseId",
                    column: x => x.FranchiseId,
                    principalTable: "Franchises",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_RMoodFranchise_Moods_MoodId",
                    column: x => x.MoodId,
                    principalTable: "Moods",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "RMoodModel",
            columns: table => new
            {
                MoodId = table.Column<int>(type: "int", nullable: false),
                ModelId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_RMoodModel", x => new { x.MoodId, x.ModelId });
                table.ForeignKey(
                    name: "FK_RMoodModel_Models_ModelId",
                    column: x => x.ModelId,
                    principalTable: "Models",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_RMoodModel_Moods_MoodId",
                    column: x => x.MoodId,
                    principalTable: "Moods",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "RArtistStyle",
            columns: table => new
            {
                ArtistId = table.Column<int>(type: "int", nullable: false),
                StyleId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_RArtistStyle", x => new { x.ArtistId, x.StyleId });
                table.ForeignKey(
                    name: "FK_RArtistStyle_Artists_ArtistId",
                    column: x => x.ArtistId,
                    principalTable: "Artists",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_RArtistStyle_Styles_StyleId",
                    column: x => x.StyleId,
                    principalTable: "Styles",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Tags",
            columns: table => new
            {
                EntityId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                TagCategoryId = table.Column<int>(type: "int", nullable: false),
                BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Tags", x => x.EntityId);
                table.ForeignKey(
                    name: "FK_Tags_TagCategories_TagCategoryId",
                    column: x => x.TagCategoryId,
                    principalTable: "TagCategories",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Restrict);
            });

        migrationBuilder.CreateTable(
            name: "Tasks",
            columns: table => new
            {
                EntityId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "03/21/2024 09:49:44"),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                TaskCategoryId = table.Column<int>(type: "int", nullable: false),
                BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Tasks", x => x.EntityId);
                table.ForeignKey(
                    name: "FK_Tasks_TaskCategories_TaskCategoryId",
                    column: x => x.TaskCategoryId,
                    principalTable: "TaskCategories",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "RMoodTag",
            columns: table => new
            {
                MoodId = table.Column<int>(type: "int", nullable: false),
                TagId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_RMoodTag", x => new { x.MoodId, x.TagId });
                table.ForeignKey(
                    name: "FK_RMoodTag_Moods_MoodId",
                    column: x => x.MoodId,
                    principalTable: "Moods",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_RMoodTag_Tags_TagId",
                    column: x => x.TagId,
                    principalTable: "Tags",
                    principalColumn: "EntityId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.InsertData(
            table: "Artists",
            columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name", "Pseudonym" },
            values: new object[,]
            {
                { 1, new Guid("e383b699-f6a2-4e4f-a2de-21173fb97c98"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1518), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1520), "", "# Unknown Artist", "" },
                { 2, new Guid("e15756e1-e8d9-4272-af8b-ac5ed206daef"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1550), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1551), "", "/ Unknown 2D Animator", "" },
                { 3, new Guid("59be0e99-d273-460c-ad45-6d753c932aa3"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1553), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1554), "", "/ Unknown 2D Illustrator", "" },
                { 4, new Guid("3b33b5d9-4bf8-4cb0-a5e2-828d4b71155f"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1556), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1557), "", "/ Unknown 3D Animator", "" },
                { 5, new Guid("25d6ffd6-7a71-4664-a7e1-0726f86618d2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1559), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1559), "", "/ Unknown 3D Sculptor", "" },
                { 6, new Guid("6a28c59c-f426-44a8-bd40-6dd5813c1d8a"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1562), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1562), "", "/ Unknown A.I. User", "" },
                { 7, new Guid("909976da-8d93-457d-8791-730229bf1351"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1564), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1565), "", "/ Unknown Musician", "" },
                { 8, new Guid("90ac487b-a002-48c4-9452-c5b50443b408"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1585), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1586), "", "/ Unknown Photographer", "" },
                { 9, new Guid("7b5c41f1-7f5a-4883-9121-23c404fde1a6"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1587), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1588), "", "/ Unknown Sculptor", "" },
                { 10, new Guid("5d7382c5-8c8d-4989-b09e-2c3695ba833c"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1591), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1592), "", "/ Unknown Videast", "" },
                { 11, new Guid("ff7006db-5469-44d4-bd59-e83cff684ae3"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1594), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1594), "", "/ Unknown Writer", "" },
                { 12, new Guid("afa21b70-c2cb-4f9c-8c73-38971b65fce7"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1596), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1596), "", "Flying PAD", "" },
                { 13, new Guid("72986298-7e5c-4134-b98b-fca7d5e3bc7a"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1598), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1598), "", "Soën9048", "" },
                { 14, new Guid("34dcbd6a-3e2b-4759-ba89-1df8f3840d79"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1600), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1600), "", "CohesivePanda", "" },
                { 15, new Guid("09b58f76-ec8f-4c17-adaf-e0eeb28a69df"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1602), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1603), "", "Fanny tyler", "" },
                { 16, new Guid("53e17f9c-ad1c-4db0-b556-2866cfb7e7a2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1608), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1608), "", "Eichiro Oda", "" },
                { 17, new Guid("3b74a17f-d93b-4ecd-a1c7-fa4e85432c14"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1610), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1610), "", "Masashi Kishimoto", "" },
                { 18, new Guid("9b3ebf2d-a65f-499a-8a77-e285f2a5fce1"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1613), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1613), "", "Dali", "" },
                { 19, new Guid("109e353d-cdef-497a-aead-c140b423ab8c"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1615), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1615), "", "Van Gogh", "" },
                { 20, new Guid("948fbd7c-bf85-403f-b104-c48b2edcb823"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1617), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1617), "", "Michael Jackson", "" },
                { 21, new Guid("7058678e-eda2-4eb3-8a92-0d8c5cd4721f"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1619), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1619), "", "CG5", "" },
                { 22, new Guid("5a5b4bae-c18d-4715-a8d9-c3cd277176b4"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1621), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1621), "", "TryHardNinja", "" },
                { 23, new Guid("bc00bfa7-d7b6-4898-a806-1b0982852e2c"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1624), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1624), "", "Jacob Collier", "" }
            });

        migrationBuilder.InsertData(
            table: "Franchises",
            columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
            values: new object[,]
            {
                { 1, new Guid("b4ab296b-6f97-4f86-8987-beafdc5157f9"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2059), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2059), "", "Flying PAD" },
                { 2, new Guid("9a8a7cc3-5137-4aa4-88b1-e04d97b42939"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2065), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2065), "", "Best of You" }
            });

        migrationBuilder.InsertData(
            table: "LinkCategories",
            columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
            values: new object[,]
            {
                { 1, new Guid("a06dc8d4-516f-49b1-a8b0-9d9a6fcd4461"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2482), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2482), "", "Audio" },
                { 2, new Guid("98c44e3b-5939-46e0-8b20-bcdaa68a29a7"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2493), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2493), "", "Audio | Mix & Master" },
                { 3, new Guid("ea22795a-6c92-4a93-8a1d-543a96005ba4"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2495), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2495), "", "Audio | Sound Design" },
                { 4, new Guid("69102e0d-39ff-4875-a8a2-0238ee13c72d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2498), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2499), "", "Books" },
                { 5, new Guid("3a2335ff-3b73-4f34-b2fa-8159707040cb"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2500), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2501), "", "Books | Harmony" },
                { 6, new Guid("d6c32070-abd1-42c8-ac28-3b9ecb37eda4"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2503), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2503), "", "Software" },
                { 7, new Guid("a532acf4-7c06-451d-8d89-59822a41c9c1"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2505), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2505), "", "Software | D.A.W." },
                { 8, new Guid("5906c907-f25d-4020-829e-9e3046c57180"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2507), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2507), "", "Software | V.S.T." },
                { 9, new Guid("af8354d5-7055-455f-b03c-a0eccda00628"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2509), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2509), "", "Software | Music Notation" },
                { 10, new Guid("07f47d10-bae9-4fe9-b859-0545ddb02758"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2514), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2514), "", "Tools" },
                { 11, new Guid("e8ab6e2e-a8f1-489a-995f-fef34ad10c38"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2516), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2516), "", "Tools | Global" },
                { 12, new Guid("072a9638-3082-43f8-9f4b-c4a1e7bac7fd"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2518), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2518), "", "YouTube" },
                { 13, new Guid("451ba733-a232-4cad-a304-92d9f72a38a3"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2520), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2520), "", "YouTube | Artists" },
                { 14, new Guid("2fa54db6-3ee0-41c7-befe-bc3c5c098fe8"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2522), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2522), "", "YouTube | Audio" },
                { 15, new Guid("0c00240d-a6bd-4a45-ab35-ecad4c57b788"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2524), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2524), "", "YouTube | Piano & Keys" }
            });

        migrationBuilder.InsertData(
            table: "Links",
            columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name", "Url" },
            values: new object[,]
            {
                { 1, new Guid("62e89cd3-4f42-4285-be7e-ef7c6cd2aa73"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2249), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2250), "", "KVR", "https://www.kvraudio.com/" },
                { 2, new Guid("b8e8f968-caef-4ffb-b80c-90412c38eb10"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2255), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2255), "", "MuseScore", "https://musescore.com/" },
                { 3, new Guid("80d73874-c11b-4fe5-9455-4b0085133c1c"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2257), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2257), "", "Native Instruments", "https://www.native-instruments.com" },
                { 4, new Guid("262dd72d-54e7-4ea9-8f3a-c71fd31432b9"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2259), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2260), "", "Steinberg", "https://www.steinberg.net/" },
                { 5, new Guid("01bd2d25-19cb-47b7-a033-df0665167e9a"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2262), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2262), "", "Clés pour l'harmonie", "http://www.jo-anger-weller.com/102/cles-pour-lharmonie/" },
                { 6, new Guid("bc22ed0c-b62e-4e16-a55c-5e6b23d3335a"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2266), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2266), "", "Google | Metronome", "https://www.google.com/search?q=metronome" },
                { 7, new Guid("a8af1f90-737b-43c5-98e3-d4ccfc4a2e12"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2268), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2268), "", "Google | Stopwatch", "https://www.google.com/search?q=stopwatch" },
                { 8, new Guid("1d0a24dc-2606-4131-aafa-60f6c2f340ce"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2270), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2270), "", "Google | Timer", "https://www.google.com/search?q=timer" },
                { 9, new Guid("b45c4d22-cab0-43c0-ae3c-9827d5bbd918"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2275), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2276), "", "Mangold Project", "https://www.youtube.com/@MangoldProject" },
                { 10, new Guid("e9364ae0-3a48-481a-9d63-d7bfefb28cc2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2278), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2279), "", "# YouTube", "https://www.youtube.com" },
                { 11, new Guid("f0b27774-fe29-4929-adfa-1cc0046c38f7"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2280), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2281), "", "Piano Jazz Concept", "https://www.youtube.com/@Pianojazzconcept" },
                { 12, new Guid("053c3f89-bcb6-4446-8e4d-888455308875"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2282), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2283), "", "Rick Beato", "https://www.youtube.com/@RickBeato" },
                { 13, new Guid("738ebe69-19e5-432a-ab0a-abb72f944928"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2284), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2285), "", "Pianote", "https://www.youtube.com/@PianoteOfficial" },
                { 14, new Guid("6664647c-cbc6-449e-83a7-9fd32ebeee7e"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2288), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2288), "", "TryHardNinja", "https://www.youtube.com/@TryHardNinja" },
                { 15, new Guid("e384fc01-799c-460e-b582-a164f816c3c1"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2290), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2290), "", "Kyle Allen Music", "https://www.youtube.com/@KyleAllenMusic" },
                { 16, new Guid("8cbc2eca-eb86-440d-8d66-4338490515c1"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2292), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2292), "", "Ableton", "https://www.youtube.com/@Ableton" },
                { 17, new Guid("e0eef0e7-10df-400e-8dc6-f91441b69de5"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2296), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2297), "", "La Machine à Mixer", "https://www.youtube.com/@lamachineamixer" },
                { 18, new Guid("45876011-2d59-4c03-af49-1a74b97c43e4"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2299), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2300), "", "Audiofanzine", "https://www.youtube.com/@audiofanzine" },
                { 19, new Guid("c09ebcf3-045f-40a1-8d9d-6ae15148b6e5"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2302), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2302), "", "Cubase", "https://www.youtube.com/@Cubase" },
                { 20, new Guid("156f495a-0a7a-4045-beff-58db72b6adfe"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2304), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2304), "", "Ten Second Songs", "https://www.youtube.com/@TenSecondSongs" },
                { 21, new Guid("d3cf8758-02e4-4d02-b49b-d379a87f29d7"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2306), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2306), "", "The Piano Guys", "https://www.youtube.com/@thepianoguys" },
                { 22, new Guid("9c15ea56-4583-4ff1-be8a-f9ff4d5a1b1f"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2308), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2308), "", "CG5", "https://www.youtube.com/@CG5" },
                { 23, new Guid("c6ac596a-5520-4b88-aa9f-6fac91daceea"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2310), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2310), "", "Native Instruments", "https://www.youtube.com/@NativeInstruments" },
                { 24, new Guid("52056a47-93c1-46c9-81f1-2f2f9f97464e"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2312), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2312), "", "Ken Tamplin Vocal Academy", "https://www.youtube.com/@kentamplin" },
                { 25, new Guid("d9f25f7f-4352-4176-b285-e65d6edfb7ca"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2317), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2317), "", "Pentatonix", "https://www.youtube.com/@PTXofficial" },
                { 26, new Guid("adc4f02a-9ad9-4750-a9f9-7d0a5b0b51e9"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2388), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2389), "", "Recording Revolution", "https://www.youtube.com/@recordingrevolution" },
                { 27, new Guid("e7eb87b6-f6ff-4c3c-9465-897704689aca"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2392), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2392), "", "Jacob Collier", "https://www.youtube.com/@jacobcollier" },
                { 28, new Guid("02a81def-8d7a-4ebb-9092-ded5a71ba187"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2394), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2394), "", "Orchestration Online", "https://www.youtube.com/@OrchestrationOnline" },
                { 29, new Guid("907a82de-7b05-4330-80b6-e7d8daf81faa"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2396), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2396), "", "Nuendo", "https://www.youtube.com/@Nuendo" },
                { 30, new Guid("fab8355b-0eeb-4926-90f8-f7082d083e66"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2398), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2398), "", "reFX", "https://www.youtube.com/@reFXaudio" },
                { 31, new Guid("190061c0-03a5-4ebe-b839-5440c7d675ae"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2400), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2400), "", "Steinberg", "https://www.youtube.com/@steinberg" }
            });

        migrationBuilder.InsertData(
            table: "Medias",
            columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
            values: new object[,]
            {
                { 1, new Guid("785ba00a-06c0-456d-9d96-057e8c97a971"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2112), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2112), "", "# Super Franchise" },
                { 2, new Guid("24091556-02c1-490d-82c6-639e1d8955c9"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2117), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2117), "", "TV" },
                { 3, new Guid("1156f3f7-1368-4b21-bbdb-12ef7cf6ea75"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2119), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2119), "", "Radio" },
                { 4, new Guid("096c2b88-d893-4964-afaf-2c1ff7e670fe"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2121), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2121), "", "YouTube" }
            });

        migrationBuilder.InsertData(
            table: "Models",
            columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "FirstName", "Gender", "LastName", "Modified", "ModifiedBy", "Pseudonym" },
            values: new object[,]
            {
                { 1, new Guid("b839c5d2-c67b-4312-9dc9-a7d4c264b39b"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2688), "", "", "", "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2688), "", "# Unknown Model" },
                { 2, new Guid("042f3d54-bb9a-4534-9905-30c13684ebc9"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2742), "", "", "", "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2742), "", "/ Unrelated Model" },
                { 3, new Guid("789e4232-72d1-45df-9a84-d901f520e114"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2749), "", "", "Tony", "", "Van Langenhove", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2750), "", "Flying PAD" }
            });

        migrationBuilder.InsertData(
            table: "Moods",
            columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Discriminator", "Extension", "Height", "Modified", "ModifiedBy", "Name", "Score", "Size", "Type", "Width" },
            values: new object[,]
            {
                { 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2801), "", "In Chords Chart", "Image", "jpg", 510, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2802), "", " Major Key Notes", 0, 61206, 1, 359 },
                { 2, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2817), "", "7 Notes, 7 Positions", "Image", "jpg", 940, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2817), "", "Major Diatonic Scales", 0, 136462, 1, 700 },
                { 3, new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2821), "", "Fundamental Positions", "Image", "jpg", 1361, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2821), "", "Piano Chords", 0, 562138, 1, 868 },
                { 4, new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2825), "", "5 Notes, 5 Positions", "Image", "jpg", 524, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2825), "", "Pentatonic Scales", 0, 74358, 1, 250 },
                { 5, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2828), "", "Color Measure", "Image", "png", 844, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2829), "", "Intervals", 0, 56324, 1, 556 },
                { 6, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2833), "", "Absolute Basics", "Image", "png", 255, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2834), "", "Time Measure", 0, 8992, 1, 400 },
                { 7, new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc1"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2836), "", "Natural Order", "Image", "webp", 226, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2836), "", "Harmonics", 0, 30964, 1, 600 },
                { 8, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd1"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2839), "", "Communication is important", "Image", "png", 705, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2839), "", "Guitar Vocabulary", 0, 99994, 1, 512 },
                { 9, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2841), "", "Diatonic Chords in C Major", "Image", "jpg", 1317, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2841), "", "Piano Chords", 0, 204898, 1, 1199 },
                { 10, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2844), "", "Mmm... You can tell, right ?", "Image", "jpg", 900, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2844), "", "Piano Scales", 0, 91482, 1, 695 },
                { 11, new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2847), "", "Overview", "Image", "gif", 709, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2847), "", "Tessitures", 0, 62391, 1, 1026 },
                { 12, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2849), "", "Circle of Life", "Image", "png", 950, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2849), "", "Chord Wheel", 0, 663017, 1, 950 },
                { 13, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2852), "", " ... ", "Image", "jpeg", 480, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2852), "", "The Mix is Almost Perfect", 0, 45254, 1, 640 },
                { 14, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb3"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2854), "", "Basic Chords / Different Keys", "Image", "jpg", 690, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2854), "", "Guitar Progressions", 0, 167969, 1, 552 },
                { 15, new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc3"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2857), "", "Les 3, c'est NON !", "Image", "jpeg", 960, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2857), "", "Vous le voulez comment votre projet ?", 0, 205144, 1, 720 },
                { 16, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd3"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2860), "", "1, 2, 3, 4, 5", "Image", "jpg", 233, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2860), "", "Fingers Numerotation", 0, 24030, 1, 350 },
                { 17, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa4"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2863), "", "My actual Keyboard", "Image", "jpg", 368, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2863), "", "Roland FP-30", 0, 87596, 1, 1680 },
                { 18, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb4"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2866), "", "How to build a chord", "Image", "jpg", 1109, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2866), "", "Chord Formula's", 0, 221030, 1, 1080 },
                { 19, new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc4"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2868), "", "Valeurs de Temps", "Image", "webp", 530, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2868), "", "Time Values", 0, 21922, 1, 640 },
                { 20, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd4"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2871), "", "Fundamental Positions", "Image", "jpg", 909, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2871), "", "Guitar Chords ( B )", 0, 57447, 1, 640 },
                { 21, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa5"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2874), "", "Primary Modes", "Image", "jpg", 1552, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2874), "", "Modes starting in C", 0, 111187, 1, 1199 },
                { 22, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb5"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2876), "", "Good luck finding the good one ...", "Image", "jpg", 1913, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2876), "", "Guitar Chords", 0, 633229, 1, 1200 },
                { 23, new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc5"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2879), "", "Une approche parmis tant d'autres", "Image", "png", 971, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2880), "", "Intervalles", 0, 69313, 1, 692 }
            });

        migrationBuilder.InsertData(
            table: "Moods",
            columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Discriminator", "Duration", "Extension", "Video_Height", "Modified", "ModifiedBy", "Name", "Score", "Video_Size", "Type", "Video_Width" },
            values: new object[] { 55, new Guid("cccccccc-cccc-cccc-cccc-cccccccccc55"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2943), "", " Bendy & The Ink Machine ", "Video", 64, "mp4", 360, new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2944), "", "BATIM - Build our Machine", 0, 5091239, 2, 640 });

        migrationBuilder.InsertData(
            table: "Moods",
            columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Discriminator", "Extension", "Modified", "ModifiedBy", "Name", "Score", "Type", "Url" },
            values: new object[] { 85, new Guid("cccccccc-cccc-cccc-cccc-cccccccccc85"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2989), "", "...", "VideoYouTube", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2989), "", "Mario Bros 3 Cover", 0, 4, "WWUxrTdjqg0" });

        migrationBuilder.InsertData(
            table: "Styles",
            columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
            values: new object[,]
            {
                { 1, new Guid("902508ae-fa3b-4900-a8ce-1a009b0255c3"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1797), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1798), "", "2D" },
                { 2, new Guid("37016e94-16c9-4e63-968c-f597218e05bf"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1804), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1804), "", "2D Animation" },
                { 3, new Guid("599d18d1-5c06-4b91-bede-35a6af5ab582"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1806), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1806), "", "3D" },
                { 4, new Guid("c775aa29-7869-408d-b57a-a6eacaef9f53"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1808), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1808), "", "3D Animation" },
                { 5, new Guid("6e5b584a-d17e-4759-b05a-5483db735d4d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1810), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1810), "", "Architecture" },
                { 6, new Guid("b5807a05-5be3-4c99-a61b-4b56864ca82a"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1813), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1813), "", "Writer" },
                { 7, new Guid("e7ee2504-2d50-4f80-9b70-d9327a5c3786"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1815), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1815), "", "Music" },
                { 8, new Guid("68919557-b8d9-474c-b961-aa4a210205be"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1910), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1910), "", "Photo" },
                { 9, new Guid("660749cb-7731-463d-8b56-12b5ebcfbb35"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1918), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1918), "", "Video" },
                { 10, new Guid("da91b1c8-83f1-4b83-b8b1-08bfb10cf4a2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1922), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1922), "", "Video Games" }
            });

        migrationBuilder.InsertData(
            table: "TagCategories",
            columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
            values: new object[,]
            {
                { 1, new Guid("18219fe5-0212-4c57-8eb2-2cd4727e5456"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3957), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3958), "", "#" },
                { 2, new Guid("ec0f0e78-8a67-490a-aac4-a2584f2a45d2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3963), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3963), "", "# File" },
                { 3, new Guid("c44c172f-77ee-462d-af1c-776f19ce04e4"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3965), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3966), "", "# File ext. | Doc." },
                { 4, new Guid("ad6a3f33-87dc-422d-b8c1-79c68452d4e6"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3968), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3968), "", "# File ext. | Image" },
                { 5, new Guid("caef1766-457f-4a23-aecc-4a691460c880"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3974), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3974), "", "# File ext. | Video" },
                { 6, new Guid("677b5cfd-7f17-4d07-ac51-096261a9cb5b"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3977), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3977), "", "# File Format" },
                { 7, new Guid("8cc62e0f-c222-4a31-88b6-eb1833a58319"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3981), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3981), "", "# File Render" },
                { 8, new Guid("9d9e72c7-e0b1-4617-90c0-e6f549c1de45"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3983), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3983), "", "Music Genre" },
                { 9, new Guid("5a05fa12-da51-479e-b311-815f1a069512"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3985), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3985), "", "Music Theory" },
                { 10, new Guid("e3fb825b-808e-471f-990f-b4de81c9f94b"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3988), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3989), "", "Keys" },
                { 11, new Guid("26ec2dff-dd5d-4727-b9e5-4d3adc788cce"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3990), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3991), "", "Brass" },
                { 12, new Guid("3bf85639-cae9-4036-82fb-278c0b3b6fb8"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3993), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3993), "", "Strings" },
                { 13, new Guid("64583ebc-1226-4eb1-b459-96a77eea0202"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3997), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3997), "", "Percussions" },
                { 14, new Guid("f6c46ca9-c4d7-494e-aff2-6420e4701deb"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3999), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3999), "", "Woodwinds" },
                { 15, new Guid("163a0bca-ee4c-4a97-9af9-d7b19c0a77ab"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4001), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4002), "", "Audio" },
                { 16, new Guid("c10d31c1-6f6b-410e-a6e0-f028fbf32d80"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4003), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4004), "", "Fun" },
                { 17, new Guid("6c95fd9c-6b89-401c-ab42-52921c05c72c"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4006), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4006), "", "Guitar" }
            });

        migrationBuilder.InsertData(
            table: "TaskCategories",
            columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Modified", "ModifiedBy", "Name" },
            values: new object[,]
            {
                { 1, new Guid("1333ac94-4237-4b5d-82a7-def1b60a14e2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4121), "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4122), "", "PAD Mobile" },
                { 2, new Guid("5644ca4b-7e59-4755-b95e-52dbe60c13f7"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4126), "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4127), "", "PAD Cave" },
                { 3, new Guid("48ea6d94-8fef-46f1-917d-425d0f410798"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4129), "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4129), "", "PAD Kids" },
                { 4, new Guid("a9ffd174-4323-43a3-ad83-fee5ea428de8"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4135), "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4135), "", "Shopping" },
                { 5, new Guid("371a782e-c47b-410f-bba9-f76160a061ed"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4137), "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4137), "", "Work" }
            });

        migrationBuilder.InsertData(
            table: "Users",
            columns: new[] { "EntityId", "Birthdate", "BusinessId", "Created", "CreatedBy", "Email", "FirstName", "LastName", "Modified", "ModifiedBy", "PasswordHash", "PasswordSalt", "Role" },
            values: new object[,]
            {
                { 1, new DateTime(1982, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcebf0b4-be2a-484e-a879-1213820245a3"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4659), "", "tonyvan@live.fr", "Tony", "Van Langenhove", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4660), "", new byte[] { 94, 153, 33, 243, 195, 214, 53, 158, 171, 132, 147, 173, 53, 137, 227, 160, 169, 235, 28, 125, 46, 203, 19, 215, 165, 171, 84, 160, 246, 227, 85, 65, 20, 231, 35, 35, 71, 215, 144, 85, 241, 8, 77, 242, 131, 58, 202, 164, 211, 95, 254, 203, 43, 134, 212, 48, 230, 167, 74, 224, 252, 251, 128, 189 }, new byte[] { 59, 182, 133, 55, 8, 76, 62, 202, 140, 12, 177, 194, 178, 79, 218, 239, 12, 4, 98, 170, 40, 190, 181, 73, 117, 3, 176, 86, 245, 39, 218, 29, 12, 209, 116, 247, 46, 157, 139, 65, 173, 215, 251, 155, 14, 3, 21, 5, 254, 107, 223, 242, 177, 156, 186, 175, 90, 81, 212, 171, 166, 183, 215, 20, 227, 60, 107, 196, 83, 244, 158, 106, 98, 195, 130, 229, 175, 24, 127, 40, 161, 191, 17, 73, 34, 191, 84, 186, 112, 228, 70, 104, 33, 113, 70, 123, 89, 82, 47, 124, 17, 137, 143, 92, 187, 6, 18, 178, 53, 21, 64, 204, 123, 5, 179, 164, 156, 2, 30, 16, 4, 82, 186, 18, 106, 89, 248, 164 }, 2 },
                { 2, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eab0637f-429b-4196-b0c1-10e42844f096"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4755), "", "floppy@gmail.com", "Floppy", "Disk", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4755), "", new byte[] { 177, 136, 167, 37, 175, 26, 54, 221, 67, 197, 90, 149, 142, 6, 46, 235, 169, 31, 69, 31, 4, 101, 167, 158, 215, 142, 84, 77, 190, 19, 11, 75, 178, 231, 194, 218, 225, 79, 97, 6, 0, 67, 49, 143, 164, 22, 70, 185, 189, 246, 220, 0, 25, 26, 117, 120, 111, 8, 96, 251, 40, 28, 182, 126 }, new byte[] { 0, 208, 46, 123, 11, 208, 186, 43, 50, 54, 142, 178, 87, 131, 167, 53, 225, 245, 200, 178, 199, 94, 225, 148, 0, 171, 114, 169, 115, 126, 87, 160, 1, 185, 209, 165, 210, 22, 174, 241, 179, 99, 94, 187, 249, 190, 215, 12, 50, 35, 116, 122, 209, 162, 55, 74, 177, 179, 186, 109, 215, 196, 240, 25, 126, 49, 44, 178, 62, 50, 192, 78, 75, 177, 237, 187, 243, 70, 209, 1, 82, 241, 35, 52, 111, 131, 155, 86, 246, 130, 84, 10, 57, 80, 156, 86, 206, 16, 65, 108, 191, 237, 29, 124, 91, 152, 194, 203, 36, 231, 243, 17, 188, 15, 10, 228, 126, 99, 132, 167, 13, 60, 177, 2, 210, 62, 139, 136 }, 1 },
                { 3, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8008722d-26c2-4989-804a-5dbfc6ea291b"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4828), "", "vincent.megag@gmail.com", "Vincent", "Megag", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4828), "", new byte[] { 164, 119, 194, 82, 60, 84, 246, 141, 23, 42, 64, 150, 73, 107, 182, 56, 21, 229, 191, 100, 228, 248, 21, 231, 228, 19, 37, 142, 205, 69, 18, 26, 193, 100, 241, 142, 62, 192, 65, 252, 247, 184, 200, 52, 184, 217, 71, 31, 201, 248, 72, 15, 103, 139, 217, 181, 62, 163, 5, 48, 144, 218, 171, 51 }, new byte[] { 216, 139, 86, 187, 52, 56, 96, 0, 42, 145, 149, 255, 81, 158, 92, 151, 252, 147, 101, 220, 97, 191, 91, 200, 252, 239, 193, 100, 25, 242, 213, 105, 16, 48, 109, 185, 107, 116, 191, 55, 148, 86, 58, 26, 42, 49, 77, 132, 175, 132, 158, 195, 21, 27, 22, 15, 57, 165, 20, 99, 41, 84, 143, 161, 64, 119, 2, 44, 185, 126, 174, 95, 15, 36, 212, 77, 80, 229, 121, 37, 52, 88, 15, 104, 61, 131, 185, 80, 65, 233, 180, 110, 15, 186, 186, 129, 58, 124, 77, 253, 215, 168, 99, 128, 255, 239, 81, 254, 135, 19, 37, 41, 11, 152, 212, 225, 215, 218, 11, 114, 187, 51, 137, 149, 225, 117, 188, 118 }, 2 }
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
                { 1, 1 },
                { 2, 1 }
            });

        migrationBuilder.InsertData(
            table: "RFranchiseModel",
            columns: new[] { "FranchiseId", "ModelId" },
            values: new object[] { 1, 3 });

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
                { 1, 23 }
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
                { 1, 23 }
            });

        migrationBuilder.InsertData(
            table: "Tags",
            columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name", "TagCategoryId" },
            values: new object[,]
            {
                { 1, new Guid("89e2199e-5d7c-44b8-9c71-34bd80c8f3b7"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3508), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3509), "", "# All Files", 1 },
                { 2, new Guid("cbccf4ec-b373-4423-9fa1-8e6a77598362"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3521), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3522), "", "Audio", 2 },
                { 3, new Guid("2d3d06de-91a2-485f-baa3-619fb15c45da"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3525), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3525), "", "Document", 2 },
                { 4, new Guid("2013dc0d-9c0e-4f92-a387-631134ce2742"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3528), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3528), "", "Image", 2 },
                { 5, new Guid("84f37866-5100-40f3-a282-5de89e480bab"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3531), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3531), "", "Video", 2 },
                { 6, new Guid("4acb3aca-6ad0-4a8d-9a4c-1b5e4d39089c"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3535), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3536), "", "*.txt", 3 },
                { 7, new Guid("ffa38f24-7f95-46d0-9037-944ec7b754d7"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3538), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3539), "", "*.bmp", 4 },
                { 8, new Guid("ad9945ed-04c1-4111-a888-fa61845e7096"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3548), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3549), "", "*.gif", 4 },
                { 9, new Guid("20441e3f-fef2-418a-89b5-54fe68a8178d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3552), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3552), "", "*.jpeg", 4 },
                { 10, new Guid("c95e97b5-4afc-401b-9aab-1a54cec5a305"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3556), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3556), "", "*.jpg", 4 },
                { 11, new Guid("d1f44c1e-742d-4f54-bb0a-1ab846659fa2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3559), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3560), "", "*.png", 4 },
                { 12, new Guid("d230abaf-7de3-4acc-ae60-5740708914d0"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3562), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3563), "", "*.webp", 4 },
                { 13, new Guid("56eb5194-5c7d-4f57-a099-75e5f15baa2d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3565), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3566), "", "*.mp4", 5 },
                { 14, new Guid("b9b383f9-f9c7-41a7-8dfc-238a4745cb6c"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3569), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3605), "", "*.webm", 5 },
                { 15, new Guid("9a2b4cdd-f6d7-4466-a2de-f6c4475dec9b"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3610), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3611), "", "Landscape", 6 },
                { 16, new Guid("c5303420-43ca-4c14-919e-90eabc1a87e8"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3618), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3618), "", "Landscape ( 16:9 )", 6 },
                { 17, new Guid("71b62a96-e215-462c-a2fc-2d0650f06929"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3621), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3621), "", "Portrait", 6 },
                { 18, new Guid("e08e9b64-dacc-44f4-bf63-0aa0cef79495"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3626), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3627), "", "Portrait ( 16:9 )", 6 },
                { 19, new Guid("2ea6cfc9-119d-480a-8559-41467265dcec"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3630), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3630), "", "Square", 6 },
                { 20, new Guid("b66bb294-70b3-415e-863a-8d14126afada"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3633), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3634), "", "2D", 7 },
                { 21, new Guid("1947acc9-d2ad-4c7c-a95e-7bc8fed634e7"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3636), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3637), "", "2D | Anim", 7 },
                { 22, new Guid("1f0f1756-fe39-4f33-8538-8ddbcf1fcb66"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3639), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3640), "", "3D", 7 },
                { 23, new Guid("97e85a4f-e96b-48b4-9b7a-4eeb83004169"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3644), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3644), "", "3D | Anim", 7 },
                { 24, new Guid("abdfe398-c130-4034-8b19-1ff362071d61"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3651), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3652), "", "Photo", 7 },
                { 25, new Guid("535793d5-7d7a-4502-9e02-78cd01561317"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3654), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3655), "", "Photo | Anim", 7 },
                { 26, new Guid("7b7cd8e6-37a9-40f4-9271-83badea811fa"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3658), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3658), "", "E.D.M.", 8 },
                { 27, new Guid("8a9c97e4-78d6-40f8-93f0-74d2580c2b20"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3661), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3662), "", "Jazz", 8 },
                { 28, new Guid("2833a4fb-24cf-4971-8016-65fa98995d85"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3665), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3665), "", "Metal", 8 },
                { 29, new Guid("956b797f-96de-4ec8-8723-170256777f7d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3670), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3670), "", "Orchestral", 8 },
                { 30, new Guid("be3e03a1-fd34-475a-9c26-bf633c766a6f"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3673), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3673), "", "Pop Music", 8 },
                { 31, new Guid("88840673-ed11-4141-97df-c84c77619b0e"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3676), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3676), "", "Rap", 8 },
                { 32, new Guid("97aae5b6-bf43-4777-adf1-cf6e7694ed71"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3682), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3682), "", "Rock", 8 },
                { 33, new Guid("9619da11-dfc6-4f0d-b078-84990316eacb"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3745), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3746), "", "Traditional", 8 },
                { 34, new Guid("927495f3-5296-43e2-8953-9786812013da"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3755), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3755), "", "# Music Theory", 9 },
                { 35, new Guid("bbdd2f2f-7a33-42c6-ba02-d31acaaf895d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3757), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3757), "", "# Harmony", 9 },
                { 36, new Guid("7cf57d36-7567-4b52-810c-35ff3950eed0"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3759), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3760), "", "Chords", 9 },
                { 37, new Guid("d9ebca09-8a6c-4a72-a8fa-38b6d7db972d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3761), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3762), "", "Harmonics", 9 },
                { 38, new Guid("bdd50c2f-b55e-4887-b523-6d12dff01825"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3764), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3764), "", "Intervals", 9 },
                { 39, new Guid("cacba3e7-65ed-4e03-89f6-6724a799a404"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3766), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3766), "", "Rythm", 9 },
                { 40, new Guid("5268424a-b128-474c-b8b8-83190263178d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3771), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3771), "", "Scales", 9 },
                { 41, new Guid("50362678-9b52-4614-9783-0525c94805d8"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3773), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3773), "", "Modes", 9 },
                { 42, new Guid("e23ebd85-7ba1-4862-82aa-1345873bcda6"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3775), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3776), "", "# Keys", 10 },
                { 43, new Guid("3454498f-e8ff-4337-b4a5-c40dd3e5a9ce"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3777), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3778), "", "Piano", 10 },
                { 44, new Guid("955eb582-b588-4411-afb0-b38651fcdb2d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3780), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3780), "", "# Brass", 11 },
                { 45, new Guid("78dfc817-ac3e-475b-9423-8f955ab15f3e"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3782), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3782), "", "Trombone", 11 },
                { 46, new Guid("c365bf76-d8d4-42bf-93c2-b4ed0b62fd66"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3784), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3784), "", "# Strings", 12 },
                { 47, new Guid("8a7b8c6b-1c68-4f4a-9184-a055110204da"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3786), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3786), "", "Violin", 12 },
                { 48, new Guid("d4180353-e558-40a4-8dd2-5a36845ee2bb"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3790), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3791), "", "# Percussions", 13 },
                { 49, new Guid("da0b062f-0a7b-4bf6-9257-605c442ca692"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3792), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3793), "", "Drums", 13 },
                { 50, new Guid("d2f412a7-ce08-4299-9f67-ccd2c6743af9"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3795), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3795), "", "# Woodwinds", 14 },
                { 51, new Guid("b7234de8-a67c-4f30-9ad2-c5587cd00aa0"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3797), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3797), "", "Clarinet", 14 },
                { 52, new Guid("797e8d6a-82c0-4da5-b64a-4d1a9d646bbc"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3799), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3799), "", "# Audio", 15 },
                { 53, new Guid("5e3c4233-3bdc-481d-b9ba-d6d0455cc8ae"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3800), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3801), "", "Mixing", 15 },
                { 54, new Guid("82d585fd-f585-4a5d-a9b6-e804283b9110"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3803), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3803), "", "Mastering", 15 },
                { 55, new Guid("8055df22-21d7-4a25-acf2-c1b20b7ec12a"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3805), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3805), "", "Recording", 15 },
                { 56, new Guid("c6888b52-b91c-4571-a3b1-68a2adab5e17"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3809), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3809), "", "Production", 15 },
                { 57, new Guid("a612ff00-53cb-4291-8336-f8005281f4b3"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3811), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3811), "", "Sound Design", 15 },
                { 58, new Guid("50deb2cc-b0ac-4acb-835c-27ab3630c61b"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3813), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3813), "", "Memes", 16 },
                { 59, new Guid("c9e56404-7405-48cb-ba7c-586d2d538e07"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3815), "", "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3816), "", "# Guitar", 17 }
            });

        migrationBuilder.InsertData(
            table: "Tasks",
            columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "DateEnd", "DateStart", "Description", "Modified", "ModifiedBy", "Name", "TaskCategoryId" },
            values: new object[] { 1, new Guid("727de44f-7a85-4e01-bb40-3cc000d1a926"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4193), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4193), "", "Check Mails", 5 });

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
                { 23, 17 }
            });

        migrationBuilder.CreateIndex(
            name: "IX_RArtistStyle_StyleId",
            table: "RArtistStyle",
            column: "StyleId");

        migrationBuilder.CreateIndex(
            name: "IX_RFranchiseMedia_MediaId",
            table: "RFranchiseMedia",
            column: "MediaId");

        migrationBuilder.CreateIndex(
            name: "IX_RFranchiseModel_ModelId",
            table: "RFranchiseModel",
            column: "ModelId");

        migrationBuilder.CreateIndex(
            name: "IX_RLinkArtist_ArtistId",
            table: "RLinkArtist",
            column: "ArtistId");

        migrationBuilder.CreateIndex(
            name: "IX_RLinkCategory_LinkCategoryId",
            table: "RLinkCategory",
            column: "LinkCategoryId");

        migrationBuilder.CreateIndex(
            name: "IX_RLinkModel_ModelId",
            table: "RLinkModel",
            column: "ModelId");

        migrationBuilder.CreateIndex(
            name: "IX_RMoodArtist_ArtistId",
            table: "RMoodArtist",
            column: "ArtistId");

        migrationBuilder.CreateIndex(
            name: "IX_RMoodFranchise_FranchiseId",
            table: "RMoodFranchise",
            column: "FranchiseId");

        migrationBuilder.CreateIndex(
            name: "IX_RMoodModel_ModelId",
            table: "RMoodModel",
            column: "ModelId");

        migrationBuilder.CreateIndex(
            name: "IX_RMoodTag_TagId",
            table: "RMoodTag",
            column: "TagId");

        migrationBuilder.CreateIndex(
            name: "IX_Tags_TagCategoryId",
            table: "Tags",
            column: "TagCategoryId");

        migrationBuilder.CreateIndex(
            name: "IX_Tasks_TaskCategoryId",
            table: "Tasks",
            column: "TaskCategoryId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Board");

        migrationBuilder.DropTable(
            name: "RArtistStyle");

        migrationBuilder.DropTable(
            name: "RFranchiseMedia");

        migrationBuilder.DropTable(
            name: "RFranchiseModel");

        migrationBuilder.DropTable(
            name: "RLinkArtist");

        migrationBuilder.DropTable(
            name: "RLinkCategory");

        migrationBuilder.DropTable(
            name: "RLinkModel");

        migrationBuilder.DropTable(
            name: "RMoodArtist");

        migrationBuilder.DropTable(
            name: "RMoodFranchise");

        migrationBuilder.DropTable(
            name: "RMoodModel");

        migrationBuilder.DropTable(
            name: "RMoodTag");

        migrationBuilder.DropTable(
            name: "Tasks");

        migrationBuilder.DropTable(
            name: "Users");

        migrationBuilder.DropTable(
            name: "Styles");

        migrationBuilder.DropTable(
            name: "Medias");

        migrationBuilder.DropTable(
            name: "LinkCategories");

        migrationBuilder.DropTable(
            name: "Links");

        migrationBuilder.DropTable(
            name: "Artists");

        migrationBuilder.DropTable(
            name: "Franchises");

        migrationBuilder.DropTable(
            name: "Models");

        migrationBuilder.DropTable(
            name: "Moods");

        migrationBuilder.DropTable(
            name: "Tags");

        migrationBuilder.DropTable(
            name: "TaskCategories");

        migrationBuilder.DropTable(
            name: "TagCategories");
    }
}

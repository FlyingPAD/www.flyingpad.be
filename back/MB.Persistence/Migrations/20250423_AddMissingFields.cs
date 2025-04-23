using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MB.Persistence.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20250424230000_AddThumbnailAndEmbedUrlToMoods")]
    public partial class AddThumbnailAndEmbedUrlToMoods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThumbnailUrl",
                table: "Moods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmbedUrl",
                table: "Moods",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmbedUrl",
                table: "Moods");

            migrationBuilder.DropColumn(
                name: "ThumbnailUrl",
                table: "Moods");
        }
    }
}
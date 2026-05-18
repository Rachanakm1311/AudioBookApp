using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AudioBookApp.Migrations
{
    /// <inheritdoc />
    public partial class AddAudioFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AudioFilePath",
                table: "AudioBooks",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AudioFilePath",
                table: "AudioBooks");
        }
    }
}

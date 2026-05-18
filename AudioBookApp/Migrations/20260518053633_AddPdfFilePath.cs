using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AudioBookApp.Migrations
{
    /// <inheritdoc />
    public partial class AddPdfFilePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AudioFilePath",
                table: "AudioBooks",
                newName: "PdfFilePath");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PdfFilePath",
                table: "AudioBooks",
                newName: "AudioFilePath");
        }
    }
}

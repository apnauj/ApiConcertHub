using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiConcertHub.Migrations
{
    /// <inheritdoc />
    public partial class NombreArtistaIntoEventsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArtistName",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtistName",
                table: "Events");
        }
    }
}

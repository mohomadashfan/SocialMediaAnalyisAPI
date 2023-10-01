using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialMediaAnalyis.API.Migrations
{
    /// <inheritdoc />
    public partial class secondupdate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "SocialMediaUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "SocialMediaUsers");
        }
    }
}

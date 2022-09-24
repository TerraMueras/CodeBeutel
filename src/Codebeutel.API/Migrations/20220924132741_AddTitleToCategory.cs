using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codebeutel.API.Migrations
{
    public partial class AddTitleToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "DogFriendlyPlace",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "DogFriendlyPlace");
        }
    }
}

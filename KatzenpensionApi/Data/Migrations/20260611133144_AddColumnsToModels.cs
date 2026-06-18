using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KatzenpensionApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnsToModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Rooms",
                newName: "ImageUrlReact");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "RegularGuests",
                newName: "ImageUrlReact");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrlAngular",
                table: "Rooms",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrlAngular",
                table: "RegularGuests",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrlAngular",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "ImageUrlAngular",
                table: "RegularGuests");

            migrationBuilder.RenameColumn(
                name: "ImageUrlReact",
                table: "Rooms",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "ImageUrlReact",
                table: "RegularGuests",
                newName: "ImageUrl");
        }
    }
}

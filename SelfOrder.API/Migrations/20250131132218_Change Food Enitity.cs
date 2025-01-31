using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SelfOrder.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangeFoodEnitity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenuId",
                table: "Foods",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubMenuId",
                table: "Foods",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "SubMenuId",
                table: "Foods");
        }
    }
}

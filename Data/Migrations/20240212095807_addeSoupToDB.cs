using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniEat.Data.Migrations
{
    /// <inheritdoc />
    public partial class addeSoupToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Soup",
                table: "DishesDatabase",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Soup",
                table: "DishesDatabase");
        }
    }
}

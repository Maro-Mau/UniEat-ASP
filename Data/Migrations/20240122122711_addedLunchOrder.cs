using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniEat.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedLunchOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LunchPostss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LunchID = table.Column<DateTime>(type: "datetime2", nullable: false),
                    M1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    M2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    M3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MI1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MI2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MI3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DO1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DO2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DO3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    F1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    F2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beef = table.Column<bool>(type: "bit", nullable: false),
                    Pork = table.Column<bool>(type: "bit", nullable: false),
                    Veggie = table.Column<bool>(type: "bit", nullable: false),
                    Chicken = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LunchPostss", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LunchPostss");
        }
    }
}

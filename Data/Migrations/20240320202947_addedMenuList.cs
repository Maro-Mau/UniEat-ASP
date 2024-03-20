using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniEat.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedMenuList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonA = table.Column<int>(type: "int", nullable: false),
                    MonB = table.Column<int>(type: "int", nullable: false),
                    Soupe = table.Column<int>(type: "int", nullable: false),
                    TueA = table.Column<int>(type: "int", nullable: false),
                    TueB = table.Column<int>(type: "int", nullable: false),
                    TueC = table.Column<int>(type: "int", nullable: false),
                    WedA = table.Column<int>(type: "int", nullable: false),
                    WedB = table.Column<int>(type: "int", nullable: false),
                    WedC = table.Column<int>(type: "int", nullable: false),
                    ThuA = table.Column<int>(type: "int", nullable: false),
                    ThuB = table.Column<int>(type: "int", nullable: false),
                    ThuC = table.Column<int>(type: "int", nullable: false),
                    FriA = table.Column<int>(type: "int", nullable: false),
                    FriB = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuList", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuList");
        }
    }
}

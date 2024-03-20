using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniEat.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedMenuListDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateBegin",
                table: "MenuList",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateEnd",
                table: "MenuList",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateBegin",
                table: "MenuList");

            migrationBuilder.DropColumn(
                name: "DateEnd",
                table: "MenuList");
        }
    }
}

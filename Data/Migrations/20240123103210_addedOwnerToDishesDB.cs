﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniEat.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedOwnerToDishesDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "DishesDatabase",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner",
                table: "DishesDatabase");
        }
    }
}

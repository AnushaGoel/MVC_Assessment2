﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assessment2_MVC.Migrations
{
    /// <inheritdoc />
    public partial class build5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "TrainingUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "TrainingUsers");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assessment2_MVC.Migrations
{
    /// <inheritdoc />
    public partial class build3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "TrainingUsers",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "ManagerName",
                table: "TrainingUsers",
                newName: "ManagerId");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TrainingUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TrainingUsers");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "TrainingUsers",
                newName: "RoleName");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "TrainingUsers",
                newName: "ManagerName");
        }
    }
}

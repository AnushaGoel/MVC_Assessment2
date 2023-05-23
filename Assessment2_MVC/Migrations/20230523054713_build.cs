using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assessment2_MVC.Migrations
{
    /// <inheritdoc />
    public partial class build : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "role",
                table: "TrainingUsers",
                newName: "RoleName");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "TrainingUsers",
                newName: "ManagerName");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "TrainingUsers",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "ManagerName",
                table: "TrainingUsers",
                newName: "ManagerId");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEnrollment.Migrations
{
    /// <inheritdoc />
    public partial class InitializeDefaultTables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Courses",
                newName: "CourseId");

            migrationBuilder.AddColumn<string>(
                name: "AssignmentName",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignmentName",
                table: "Assignments");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Courses",
                newName: "CourseID");
        }
    }
}

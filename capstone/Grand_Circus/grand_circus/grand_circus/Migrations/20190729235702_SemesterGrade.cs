using Microsoft.EntityFrameworkCore.Migrations;

namespace grand_circus.Migrations
{
    public partial class SemesterGrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "UserCourses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Semester",
                table: "UserCourses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "UserCourses");

            migrationBuilder.DropColumn(
                name: "Semester",
                table: "UserCourses");
        }
    }
}

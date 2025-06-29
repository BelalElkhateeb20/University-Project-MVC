using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSectionsTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_DepartmentID",
                table: "students");

            migrationBuilder.EnsureSchema(
                name: "Stud_sec");

            migrationBuilder.EnsureSchema(
                name: "Sub_sec");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student_Section",
                schema: "Stud_sec",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Section", x => new { x.StudentId, x.SectionId });
                    table.ForeignKey(
                        name: "FK_Student_Section_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Section_students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "students",
                        principalColumn: "StudID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subject_Section",
                schema: "Sub_sec",
                columns: table => new
                {
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Room = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject_Section", x => new { x.SectionId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Subject_Section_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subject_Section_subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalSchema: "Sub",
                        principalTable: "subjects",
                        principalColumn: "SubID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_Section_SectionId",
                schema: "Stud_sec",
                table: "Student_Section",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_Section_SubjectId",
                schema: "Sub_sec",
                table: "Subject_Section",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_DepartmentID",
                table: "students",
                column: "DepartmentID",
                principalTable: "departments",
                principalColumn: "DID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_DepartmentID",
                table: "students");

            migrationBuilder.DropTable(
                name: "Student_Section",
                schema: "Stud_sec");

            migrationBuilder.DropTable(
                name: "Subject_Section",
                schema: "Sub_sec");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_DepartmentID",
                table: "students",
                column: "DepartmentID",
                principalTable: "departments",
                principalColumn: "DID");
        }
    }
}

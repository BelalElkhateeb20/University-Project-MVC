using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddexamResultsTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentExamResults_students_StudentId",
                table: "StudentExamResults");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentExamResults_subjects_SubjectId",
                table: "StudentExamResults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentExamResults",
                table: "StudentExamResults");

            migrationBuilder.RenameTable(
                name: "StudentExamResults",
                newName: "examResults");

            migrationBuilder.RenameIndex(
                name: "IX_StudentExamResults_SubjectId",
                table: "examResults",
                newName: "IX_examResults_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentExamResults_StudentId",
                table: "examResults",
                newName: "IX_examResults_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_examResults",
                table: "examResults",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_examResults_students_StudentId",
                table: "examResults",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "StudID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_examResults_subjects_SubjectId",
                table: "examResults",
                column: "SubjectId",
                principalSchema: "Sub",
                principalTable: "subjects",
                principalColumn: "SubID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_examResults_students_StudentId",
                table: "examResults");

            migrationBuilder.DropForeignKey(
                name: "FK_examResults_subjects_SubjectId",
                table: "examResults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_examResults",
                table: "examResults");

            migrationBuilder.RenameTable(
                name: "examResults",
                newName: "StudentExamResults");

            migrationBuilder.RenameIndex(
                name: "IX_examResults_SubjectId",
                table: "StudentExamResults",
                newName: "IX_StudentExamResults_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_examResults_StudentId",
                table: "StudentExamResults",
                newName: "IX_StudentExamResults_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentExamResults",
                table: "StudentExamResults",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentExamResults_students_StudentId",
                table: "StudentExamResults",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "StudID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentExamResults_subjects_SubjectId",
                table: "StudentExamResults",
                column: "SubjectId",
                principalSchema: "Sub",
                principalTable: "subjects",
                principalColumn: "SubID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

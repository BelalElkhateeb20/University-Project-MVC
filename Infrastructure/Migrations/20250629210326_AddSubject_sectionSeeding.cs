using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSubject_sectionSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AcademicYear",
                table: "Section",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Section",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Term",
                table: "Section",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Section",
                columns: new[] { "Id", "AcademicYear", "Name", "Term" },
                values: new object[,]
                {
                    { 1, "2024/2025", "Group 1", "First" },
                    { 2, "2024/2025", "Group 2", "First" },
                    { 3, "2024/2025", "Group 3", "First" }
                });

            migrationBuilder.InsertData(
                schema: "Sub_sec",
                table: "Subject_Section",
                columns: new[] { "SectionId", "SubjectId", "Day", "EndTime", "Instructor", "Room", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, 0, new TimeSpan(0, 10, 30, 0, 0), "Eng. Ahmed Izzat", "Lap107", new TimeSpan(0, 8, 30, 0, 0) },
                    { 2, 2, 1, new TimeSpan(0, 12, 30, 0, 0), "Eng. Sara Tarek", "Section405", new TimeSpan(0, 10, 30, 0, 0) },
                    { 2, 3, 2, new TimeSpan(0, 10, 30, 0, 0), "Eng. Khaled Ali", "111", new TimeSpan(0, 8, 30, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Sub_sec",
                table: "Subject_Section",
                keyColumns: new[] { "SectionId", "SubjectId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                schema: "Sub_sec",
                table: "Subject_Section",
                keyColumns: new[] { "SectionId", "SubjectId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                schema: "Sub_sec",
                table: "Subject_Section",
                keyColumns: new[] { "SectionId", "SubjectId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "AcademicYear",
                table: "Section");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Section");

            migrationBuilder.DropColumn(
                name: "Term",
                table: "Section");
        }
    }
}

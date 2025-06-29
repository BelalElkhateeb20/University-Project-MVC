using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "StudID", "Address", "Code", "DepartmentID", "Email", "Image", "Level", "NameAR", "NameEN", "Phone", "UserId" },
                values: new object[,]
                {
                    { 1, "New York", "CH1", 1, "john.smith@example.com", "John.png", "الاولى", "جون سميث", "John Smith", "1234567890", 1 },
                    { 2, "Cairo", "CH2", 1, "ali.ahmed@example.com", "ali.png", "الاولى", "علي أحمد", "Ali Ahmed", "9876543210", 2 },
                    { 3, "Alexandria", "CH3", 1, "sara.kamal@example.com", "sara.png", "الاولى", "سارة كمال", "Sara Kamal", "01112345678", 3 },
                    { 4, "Giza", "CH4", 1, "fatma.adel@example.com", "fatma.png", "الاولى", "فاطمة عادل", "Fatma Adel", "01234567890", 4 },
                    { 5, "Tanta", "CH5", 1, "mohamed.tarek@example.com", "mohamed.png", "الاولى", "محمد طارق", "Mohamed Tarek", "01098765432", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudID",
                keyValue: 5);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUserSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Code", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RoleType", "SecurityStamp", "Supervisor", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "123 Main St", "Code1", "CON_STAMP_USER1", "Egypt", "john.smith@example.com", false, "John Smith", false, null, "JOHN.SMITH@EXAMPLE.COM", "JOHN.SMITH", "b4Xi+yJjC7uAwW2h7JqHgEPvQNkyukUcCKQJVJV7Hcw=", null, false, "Student", "SEC_STAMP_USER1", false, false, "john.smith" },
                    { 2, 0, "456 Oak Ave", "Code2", "CON_STAMP_USER2", "Egypt", "ali.ahmed@example.com", false, "Ali Ahmed", false, null, "ALI.AHMED@EXAMPLE.COM", "ALI.AHMED", "j/L0kmTWDDI+z8EtdWsfqSJK24rZzsNXh7XcClqdNJY=", null, false, "Student", "SEC_STAMP_USER2", false, false, "ali.ahmed" },
                    { 3, 0, "789 Pine Ln", "Code3", "CON_STAMP_USER3", "Egypt", "sara.kamal@example.com", false, "Sara Kamal", false, null, "SARA.KAMAL@EXAMPLE.COM", "SARA.KAMAL", "mzHt/LwX97iHnoLsyO9nUosJ1I7F/54buWUqL0V646M=", null, false, "Student", "SEC_STAMP_USER3", false, false, "sara.kamal" },
                    { 4, 0, "101 Elm St", "Code4", "CON_STAMP_USER4", "Egypt", "fatma.adel@example.com", false, "Fatma Adel", false, null, "FATMA.ADEL@EXAMPLE.COM", "FATMA.ADEL", "Mw/DDLpeE+CgfHyyjy5O1lEsx5+UIx0NOw02ZqK2HjY=", null, false, "Student", "SEC_STAMP_USER4", false, false, "fatma.adel" },
                    { 5, 0, "202 Birch Ct", "Code5", "CON_STAMP_USER5", "Egypt", "mohamed.tarek@example.com", false, "Mohamed Tarek", false, null, "MOHAMED.TAREK@EXAMPLE.COM", "MOHAMED.TAREK", "fFvW7rprIKAbYotMRpBQuTG1ix/fX4pnRUjycbWed64=", null, false, "Student", "SEC_STAMP_USER5", false, false, "mohamed.tarek" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

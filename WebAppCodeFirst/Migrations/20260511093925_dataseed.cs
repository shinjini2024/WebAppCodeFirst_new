using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class dataseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tblColour",
                columns: new[] { "Cid", "Cname" },
                values: new object[,]
                {
                    { 1, "Red" },
                    { 2, "Blue" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblColour",
                keyColumn: "Cid",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblColour",
                keyColumn: "Cid",
                keyValue: 2);
        }
    }
}

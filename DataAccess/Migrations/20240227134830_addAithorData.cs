using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addAithorData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Author_id", "BirthDate", "FirstName", "LastName", "Location" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 27, 15, 48, 30, 449, DateTimeKind.Local).AddTicks(4588), "First_Name_1", "Last_Name_1", "Lviv" },
                    { 2, new DateTime(2024, 2, 27, 15, 48, 30, 449, DateTimeKind.Local).AddTicks(4647), "First_Name_2", "Last_Name_2", "Kyiv" }
                });
        }

    }
}

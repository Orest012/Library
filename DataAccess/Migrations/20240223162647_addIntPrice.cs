using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addIntPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IdBook",
                keyValue: 1,
                column: "Price",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IdBook",
                keyValue: 2,
                column: "Price",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IdBook",
                keyValue: 3,
                column: "Price",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IdBook",
                keyValue: 4,
                column: "Price",
                value: 8);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IdBook",
                keyValue: 1,
                column: "Price",
                value: 10.99m);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IdBook",
                keyValue: 2,
                column: "Price",
                value: 8.99m);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IdBook",
                keyValue: 3,
                column: "Price",
                value: 10.99m);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IdBook",
                keyValue: 4,
                column: "Price",
                value: 8.99m);
        }
    }
}

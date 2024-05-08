using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addСhangeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_bookAuthorVMs_BookAuthorVMIdBook",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_bookAuthorVMs_Books_BookIdBook",
                table: "bookAuthorVMs");

            migrationBuilder.DropIndex(
                name: "IX_bookAuthorVMs_BookIdBook",
                table: "bookAuthorVMs");

            migrationBuilder.DropIndex(
                name: "IX_Authors_BookAuthorVMIdBook",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "BookIdBook",
                table: "bookAuthorVMs");

            migrationBuilder.DropColumn(
                name: "BookAuthorVMIdBook",
                table: "Authors");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookIdBook",
                table: "bookAuthorVMs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookAuthorVMIdBook",
                table: "Authors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_bookAuthorVMs_BookIdBook",
                table: "bookAuthorVMs",
                column: "BookIdBook");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_BookAuthorVMIdBook",
                table: "Authors",
                column: "BookAuthorVMIdBook");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_bookAuthorVMs_BookAuthorVMIdBook",
                table: "Authors",
                column: "BookAuthorVMIdBook",
                principalTable: "bookAuthorVMs",
                principalColumn: "IdBook");

            migrationBuilder.AddForeignKey(
                name: "FK_bookAuthorVMs_Books_BookIdBook",
                table: "bookAuthorVMs",
                column: "BookIdBook",
                principalTable: "Books",
                principalColumn: "IdBook",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

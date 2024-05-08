using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addBookAuthorVM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookAuthorVMIdBook",
                table: "Authors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "bookAuthorVMs",
                columns: table => new
                {
                    IdBook = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookIdBook = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookAuthorVMs", x => x.IdBook);
                    table.ForeignKey(
                        name: "FK_bookAuthorVMs_Books_BookIdBook",
                        column: x => x.BookIdBook,
                        principalTable: "Books",
                        principalColumn: "IdBook",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authors_BookAuthorVMIdBook",
                table: "Authors",
                column: "BookAuthorVMIdBook");

            migrationBuilder.CreateIndex(
                name: "IX_bookAuthorVMs_BookIdBook",
                table: "bookAuthorVMs",
                column: "BookIdBook");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_bookAuthorVMs_BookAuthorVMIdBook",
                table: "Authors",
                column: "BookAuthorVMIdBook",
                principalTable: "bookAuthorVMs",
                principalColumn: "IdBook");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_bookAuthorVMs_BookAuthorVMIdBook",
                table: "Authors");

            migrationBuilder.DropTable(
                name: "bookAuthorVMs");

            migrationBuilder.DropIndex(
                name: "IX_Authors_BookAuthorVMIdBook",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "BookAuthorVMIdBook",
                table: "Authors");
        }
    }
}

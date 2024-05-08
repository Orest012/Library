using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addNewBookAuthorMap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Authors_Author_Id",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Books_Book_Id",
                table: "AuthorBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthorBook",
                table: "AuthorBook");

            migrationBuilder.RenameTable(
                name: "AuthorBook",
                newName: "BookAuthorMaps");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorBook_Book_Id",
                table: "BookAuthorMaps",
                newName: "IX_BookAuthorMaps_Book_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthorMaps",
                table: "BookAuthorMaps",
                columns: new[] { "Author_Id", "Book_Id" });

            migrationBuilder.CreateTable(
                name: "AuthorBookAuthorMap",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    BookAuthorMapAuthor_Id = table.Column<int>(type: "int", nullable: false),
                    BookAuthorMapBook_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBookAuthorMap", x => new { x.AuthorId, x.BookAuthorMapAuthor_Id, x.BookAuthorMapBook_Id });
                    table.ForeignKey(
                        name: "FK_AuthorBookAuthorMap_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBookAuthorMap_BookAuthorMaps_BookAuthorMapAuthor_Id_BookAuthorMapBook_Id",
                        columns: x => new { x.BookAuthorMapAuthor_Id, x.BookAuthorMapBook_Id },
                        principalTable: "BookAuthorMaps",
                        principalColumns: new[] { "Author_Id", "Book_Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBookAuthorMap_BookAuthorMapAuthor_Id_BookAuthorMapBook_Id",
                table: "AuthorBookAuthorMap",
                columns: new[] { "BookAuthorMapAuthor_Id", "BookAuthorMapBook_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthorMaps_Books_Book_Id",
                table: "BookAuthorMaps",
                column: "Book_Id",
                principalTable: "Books",
                principalColumn: "IdBook",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthorMaps_Books_Book_Id",
                table: "BookAuthorMaps");

            migrationBuilder.DropTable(
                name: "AuthorBookAuthorMap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthorMaps",
                table: "BookAuthorMaps");

            migrationBuilder.RenameTable(
                name: "BookAuthorMaps",
                newName: "AuthorBook");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthorMaps_Book_Id",
                table: "AuthorBook",
                newName: "IX_AuthorBook_Book_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthorBook",
                table: "AuthorBook",
                columns: new[] { "Author_Id", "Book_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Authors_Author_Id",
                table: "AuthorBook",
                column: "Author_Id",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Books_Book_Id",
                table: "AuthorBook",
                column: "Book_Id",
                principalTable: "Books",
                principalColumn: "IdBook",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

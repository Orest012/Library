using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddBookAuthorMap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Authors_AuthorsAuthorId",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Books_BooksIdBook",
                table: "AuthorBook");

            migrationBuilder.DropTable(
                name: "authorBooks");

            migrationBuilder.RenameColumn(
                name: "BooksIdBook",
                table: "AuthorBook",
                newName: "Book_Id");

            migrationBuilder.RenameColumn(
                name: "AuthorsAuthorId",
                table: "AuthorBook",
                newName: "Author_Id");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorBook_BooksIdBook",
                table: "AuthorBook",
                newName: "IX_AuthorBook_Book_Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Authors_Author_Id",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Books_Book_Id",
                table: "AuthorBook");

            migrationBuilder.RenameColumn(
                name: "Book_Id",
                table: "AuthorBook",
                newName: "BooksIdBook");

            migrationBuilder.RenameColumn(
                name: "Author_Id",
                table: "AuthorBook",
                newName: "AuthorsAuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorBook_Book_Id",
                table: "AuthorBook",
                newName: "IX_AuthorBook_BooksIdBook");

            migrationBuilder.CreateTable(
                name: "authorBooks",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authorBooks", x => x.AuthorId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Authors_AuthorsAuthorId",
                table: "AuthorBook",
                column: "AuthorsAuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Books_BooksIdBook",
                table: "AuthorBook",
                column: "BooksIdBook",
                principalTable: "Books",
                principalColumn: "IdBook",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

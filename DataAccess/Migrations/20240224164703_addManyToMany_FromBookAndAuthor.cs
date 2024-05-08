using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addManyToMany_FromBookAndAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fluent_AuthorFluent_Book",
                columns: table => new
                {
                    AuthorsAuthor_id = table.Column<int>(type: "int", nullable: false),
                    BooksIdBook = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_AuthorFluent_Book", x => new { x.AuthorsAuthor_id, x.BooksIdBook });
                    table.ForeignKey(
                        name: "FK_Fluent_AuthorFluent_Book_fluent_Authors_AuthorsAuthor_id",
                        column: x => x.AuthorsAuthor_id,
                        principalTable: "fluent_Authors",
                        principalColumn: "Author_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fluent_AuthorFluent_Book_fluent_Books_BooksIdBook",
                        column: x => x.BooksIdBook,
                        principalTable: "fluent_Books",
                        principalColumn: "IdBook",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_AuthorFluent_Book_BooksIdBook",
                table: "Fluent_AuthorFluent_Book",
                column: "BooksIdBook");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fluent_AuthorFluent_Book");
        }
    }
}

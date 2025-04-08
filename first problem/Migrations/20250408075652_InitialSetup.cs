using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace first_problem.Migrations
{
    /// <inheritdoc />
    public partial class InitialSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_Authod_ID",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Authod_ID",
                table: "Books",
                newName: "Author_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Books_Authod_ID",
                table: "Books",
                newName: "IX_Books_Author_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_Author_ID",
                table: "Books",
                column: "Author_ID",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_Author_ID",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Author_ID",
                table: "Books",
                newName: "Authod_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Books_Author_ID",
                table: "Books",
                newName: "IX_Books_Authod_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_Authod_ID",
                table: "Books",
                column: "Authod_ID",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

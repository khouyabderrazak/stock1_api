using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_Data_Api.Migrations
{
    /// <inheritdoc />
    public partial class addArticleGroupTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleGroup_ArticleGroupId",
                table: "Articles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArticleGroup",
                table: "ArticleGroup");

            migrationBuilder.RenameTable(
                name: "ArticleGroup",
                newName: "ArticleGroups");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArticleGroups",
                table: "ArticleGroups",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleGroups_ArticleGroupId",
                table: "Articles",
                column: "ArticleGroupId",
                principalTable: "ArticleGroups",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleGroups_ArticleGroupId",
                table: "Articles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArticleGroups",
                table: "ArticleGroups");

            migrationBuilder.RenameTable(
                name: "ArticleGroups",
                newName: "ArticleGroup");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArticleGroup",
                table: "ArticleGroup",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleGroup_ArticleGroupId",
                table: "Articles",
                column: "ArticleGroupId",
                principalTable: "ArticleGroup",
                principalColumn: "ID");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_Data_Api.Migrations
{
    /// <inheritdoc />
    public partial class updateTablesssf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticlesInf_TabArticles_TabArticlesId",
                table: "ArticlesInf");

            migrationBuilder.RenameColumn(
                name: "TabArticlesId",
                table: "ArticlesInf",
                newName: "tabArticlesId");

            migrationBuilder.RenameIndex(
                name: "IX_ArticlesInf_TabArticlesId",
                table: "ArticlesInf",
                newName: "IX_ArticlesInf_tabArticlesId");

            migrationBuilder.AlterColumn<int>(
                name: "taxId",
                table: "ArticlesInf",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "taux",
                table: "ArticlesInf",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "quantite",
                table: "ArticlesInf",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "note",
                table: "ArticlesInf",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "montant",
                table: "ArticlesInf",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "articleId",
                table: "ArticlesInf",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticlesInf_TabArticles_tabArticlesId",
                table: "ArticlesInf",
                column: "tabArticlesId",
                principalTable: "TabArticles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticlesInf_TabArticles_tabArticlesId",
                table: "ArticlesInf");

            migrationBuilder.RenameColumn(
                name: "tabArticlesId",
                table: "ArticlesInf",
                newName: "TabArticlesId");

            migrationBuilder.RenameIndex(
                name: "IX_ArticlesInf_tabArticlesId",
                table: "ArticlesInf",
                newName: "IX_ArticlesInf_TabArticlesId");

            migrationBuilder.AlterColumn<int>(
                name: "taxId",
                table: "ArticlesInf",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "taux",
                table: "ArticlesInf",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "quantite",
                table: "ArticlesInf",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "note",
                table: "ArticlesInf",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "montant",
                table: "ArticlesInf",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "articleId",
                table: "ArticlesInf",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticlesInf_TabArticles_TabArticlesId",
                table: "ArticlesInf",
                column: "TabArticlesId",
                principalTable: "TabArticles",
                principalColumn: "Id");
        }
    }
}

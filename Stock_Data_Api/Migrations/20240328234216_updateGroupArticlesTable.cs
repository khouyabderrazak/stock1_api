using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_Data_Api.Migrations
{
    /// <inheritdoc />
    public partial class updateGroupArticlesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "ArticleGroups",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "ArticleGroups");
        }
    }
}

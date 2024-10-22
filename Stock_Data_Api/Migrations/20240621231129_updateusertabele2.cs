using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_Data_Api.Migrations
{
    /// <inheritdoc />
    public partial class updateusertabele2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "tocken",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tocken",
                table: "Users");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_Data_Api.Migrations
{
    /// <inheritdoc />
    public partial class hhhhh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IOTtable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IOTtable", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IOTtable");
        }
    }
}

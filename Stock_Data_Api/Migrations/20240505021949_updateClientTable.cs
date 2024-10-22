using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_Data_Api.Migrations
{
    /// <inheritdoc />
    public partial class updateClientTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChequeOfModeSells_Currencies_CurrencyId",
                table: "ChequeOfModeSells");

            migrationBuilder.DropForeignKey(
                name: "FK_Cheques_Currencies_CurrencyId",
                table: "Cheques");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Currencies_CurrencyId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Taxes_TaxId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentOfModeImports_Currencies_CurrencyId",
                table: "PaymentOfModeImports");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentOfModeSells_Currencies_CurrencyId",
                table: "PaymentOfModeSells");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Currencies_CurrencyId",
                table: "Suppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Taxes_TaxId",
                table: "Suppliers");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_CurrencyId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_PaymentOfModeSells_CurrencyId",
                table: "PaymentOfModeSells");

            migrationBuilder.DropIndex(
                name: "IX_PaymentOfModeImports_CurrencyId",
                table: "PaymentOfModeImports");

            migrationBuilder.DropIndex(
                name: "IX_Clients_CurrencyId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Cheques_CurrencyId",
                table: "Cheques");

            migrationBuilder.DropIndex(
                name: "IX_ChequeOfModeSells_CurrencyId",
                table: "ChequeOfModeSells");

            migrationBuilder.RenameColumn(
                name: "TaxId",
                table: "Suppliers",
                newName: "taxId");

            migrationBuilder.RenameIndex(
                name: "IX_Suppliers_TaxId",
                table: "Suppliers",
                newName: "IX_Suppliers_taxId");

            migrationBuilder.RenameColumn(
                name: "TaxId",
                table: "Clients",
                newName: "taxId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_TaxId",
                table: "Clients",
                newName: "IX_Clients_taxId");

            migrationBuilder.AlterColumn<string>(
                name: "Designation",
                table: "PersonToContacts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Department",
                table: "PersonToContacts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Taxes_taxId",
                table: "Clients",
                column: "taxId",
                principalTable: "Taxes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Taxes_taxId",
                table: "Suppliers",
                column: "taxId",
                principalTable: "Taxes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Taxes_taxId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Taxes_taxId",
                table: "Suppliers");

            migrationBuilder.RenameColumn(
                name: "taxId",
                table: "Suppliers",
                newName: "TaxId");

            migrationBuilder.RenameIndex(
                name: "IX_Suppliers_taxId",
                table: "Suppliers",
                newName: "IX_Suppliers_TaxId");

            migrationBuilder.RenameColumn(
                name: "taxId",
                table: "Clients",
                newName: "TaxId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_taxId",
                table: "Clients",
                newName: "IX_Clients_TaxId");

            migrationBuilder.AlterColumn<string>(
                name: "Designation",
                table: "PersonToContacts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Department",
                table: "PersonToContacts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_CurrencyId",
                table: "Suppliers",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOfModeSells_CurrencyId",
                table: "PaymentOfModeSells",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOfModeImports_CurrencyId",
                table: "PaymentOfModeImports",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CurrencyId",
                table: "Clients",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Cheques_CurrencyId",
                table: "Cheques",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ChequeOfModeSells_CurrencyId",
                table: "ChequeOfModeSells",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChequeOfModeSells_Currencies_CurrencyId",
                table: "ChequeOfModeSells",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cheques_Currencies_CurrencyId",
                table: "Cheques",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Currencies_CurrencyId",
                table: "Clients",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Taxes_TaxId",
                table: "Clients",
                column: "TaxId",
                principalTable: "Taxes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentOfModeImports_Currencies_CurrencyId",
                table: "PaymentOfModeImports",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentOfModeSells_Currencies_CurrencyId",
                table: "PaymentOfModeSells",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Currencies_CurrencyId",
                table: "Suppliers",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Taxes_TaxId",
                table: "Suppliers",
                column: "TaxId",
                principalTable: "Taxes",
                principalColumn: "Id");
        }
    }
}

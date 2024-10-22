using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_Data_Api.Migrations
{
    /// <inheritdoc />
    public partial class updateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceCreditImports_Address_BillingAddressId",
                table: "InvoiceCreditImports");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceCreditImports_Address_DeliveryAddressId",
                table: "InvoiceCreditImports");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceCreditImports_PersonToContacts_PersonToContactId",
                table: "InvoiceCreditImports");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceCreditSells_Address_BillingAddressId",
                table: "InvoiceCreditSells");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceCreditSells_Address_DeliveryAddressId",
                table: "InvoiceCreditSells");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceCreditSells_PersonToContacts_PersonToContactId",
                table: "InvoiceCreditSells");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceImports_Address_BillingAddressId",
                table: "InvoiceImports");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceImports_Address_DeliveryAddressId",
                table: "InvoiceImports");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceImports_PersonToContacts_PersonToContactId",
                table: "InvoiceImports");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceSells_Address_BillingAddressId",
                table: "InvoiceSells");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceSells_Address_DeliveryAddressId",
                table: "InvoiceSells");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceSells_InvoiceSellGroups_InvoiceSellGroupId",
                table: "InvoiceSells");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceSells_PaymentSells_PaymentId",
                table: "InvoiceSells");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceSells_PersonToContacts_PersonToContactId",
                table: "InvoiceSells");

            migrationBuilder.DropForeignKey(
                name: "FK_TabArticles_Taxes_ShippingCostsTaxId",
                table: "TabArticles");

            migrationBuilder.DropForeignKey(
                name: "FK_TabArticlesItems_TabArticles_TabArticlesId",
                table: "TabArticlesItems");

            migrationBuilder.DropIndex(
                name: "IX_TabArticlesItems_TabArticlesId",
                table: "TabArticlesItems");

            migrationBuilder.DropIndex(
                name: "IX_TabArticles_ShippingCostsTaxId",
                table: "TabArticles");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceSells_BillingAddressId",
                table: "InvoiceSells");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceSells_DeliveryAddressId",
                table: "InvoiceSells");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceSells_InvoiceSellGroupId",
                table: "InvoiceSells");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceSells_PaymentId",
                table: "InvoiceSells");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceSells_PersonToContactId",
                table: "InvoiceSells");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceImports_BillingAddressId",
                table: "InvoiceImports");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceImports_DeliveryAddressId",
                table: "InvoiceImports");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceImports_PersonToContactId",
                table: "InvoiceImports");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceCreditSells_BillingAddressId",
                table: "InvoiceCreditSells");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceCreditSells_DeliveryAddressId",
                table: "InvoiceCreditSells");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceCreditSells_PersonToContactId",
                table: "InvoiceCreditSells");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceCreditImports_BillingAddressId",
                table: "InvoiceCreditImports");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceCreditImports_DeliveryAddressId",
                table: "InvoiceCreditImports");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceCreditImports_PersonToContactId",
                table: "InvoiceCreditImports");

            migrationBuilder.DropColumn(
                name: "TabArticlesId",
                table: "TabArticlesItems");

            migrationBuilder.DropColumn(
                name: "DiscountState",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "DiscountTotal",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "DoApplyDiscount",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "IsArticleVisible",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "IsDiscountVisible",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "IsItemTotalVisible",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "IsQuantityVisible",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "IsTaxVisible",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "IsTotalDiscountVisible",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "IsUnitPriceVisible",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "PersonalizedRowAmount",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "PersonalizedRowName",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "ShippingCosts",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "ShippingCostsTaxId",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "ShowShippingCosts",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "Subtotal",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "BillingAddressId",
                table: "InvoiceSells");

            migrationBuilder.DropColumn(
                name: "DeliveryAddressId",
                table: "InvoiceSells");

            migrationBuilder.DropColumn(
                name: "Info",
                table: "InvoiceSells");

            migrationBuilder.DropColumn(
                name: "InvoiceSellGroupId",
                table: "InvoiceSells");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "InvoiceSells");

            migrationBuilder.DropColumn(
                name: "PersonToContactId",
                table: "InvoiceSells");

            migrationBuilder.DropColumn(
                name: "BillingAddressId",
                table: "InvoiceImports");

            migrationBuilder.DropColumn(
                name: "DeliveryAddressId",
                table: "InvoiceImports");

            migrationBuilder.DropColumn(
                name: "Info",
                table: "InvoiceImports");

            migrationBuilder.DropColumn(
                name: "PersonToContactId",
                table: "InvoiceImports");

            migrationBuilder.DropColumn(
                name: "BillingAddressId",
                table: "InvoiceCreditSells");

            migrationBuilder.DropColumn(
                name: "DeliveryAddressId",
                table: "InvoiceCreditSells");

            migrationBuilder.DropColumn(
                name: "Info",
                table: "InvoiceCreditSells");

            migrationBuilder.DropColumn(
                name: "PersonToContactId",
                table: "InvoiceCreditSells");

            migrationBuilder.DropColumn(
                name: "BillingAddressId",
                table: "InvoiceCreditImports");

            migrationBuilder.DropColumn(
                name: "DeliveryAddressId",
                table: "InvoiceCreditImports");

            migrationBuilder.DropColumn(
                name: "Info",
                table: "InvoiceCreditImports");

            migrationBuilder.DropColumn(
                name: "PersonToContactId",
                table: "InvoiceCreditImports");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "TabArticles",
                newName: "total");

            migrationBuilder.AlterColumn<decimal>(
                name: "total",
                table: "TabArticles",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<decimal>(
                name: "fraisdexpedition",
                table: "TabArticles",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "sousTotal",
                table: "TabArticles",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "taxTotal",
                table: "TabArticles",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "InvoiceSells",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NOrder",
                table: "InvoiceSells",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InvoiceDate",
                table: "InvoiceSells",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "GeneralConditions",
                table: "InvoiceSells",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "InvoiceImports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NOrder",
                table: "InvoiceImports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InvoiceDate",
                table: "InvoiceImports",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "InvoiceCreditSells",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NOrder",
                table: "InvoiceCreditSells",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InvoiceDate",
                table: "InvoiceCreditSells",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "InvoiceCreditImports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NOrder",
                table: "InvoiceCreditImports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InvoiceDate",
                table: "InvoiceCreditImports",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "ArticlesInf",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    articleId = table.Column<int>(type: "int", nullable: false),
                    quantite = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    taux = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    taxId = table.Column<int>(type: "int", nullable: false),
                    montant = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TabArticlesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlesInf", x => x.id);
                    table.ForeignKey(
                        name: "FK_ArticlesInf_TabArticles_TabArticlesId",
                        column: x => x.TabArticlesId,
                        principalTable: "TabArticles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesInf_TabArticlesId",
                table: "ArticlesInf",
                column: "TabArticlesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticlesInf");

            migrationBuilder.DropColumn(
                name: "fraisdexpedition",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "sousTotal",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "taxTotal",
                table: "TabArticles");

            migrationBuilder.DropColumn(
                name: "GeneralConditions",
                table: "InvoiceSells");

            migrationBuilder.RenameColumn(
                name: "total",
                table: "TabArticles",
                newName: "Total");

            migrationBuilder.AddColumn<int>(
                name: "TabArticlesId",
                table: "TabArticlesItems",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "TabArticles",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiscountState",
                table: "TabArticles",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "DiscountTotal",
                table: "TabArticles",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DoApplyDiscount",
                table: "TabArticles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsArticleVisible",
                table: "TabArticles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDiscountVisible",
                table: "TabArticles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsItemTotalVisible",
                table: "TabArticles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsQuantityVisible",
                table: "TabArticles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTaxVisible",
                table: "TabArticles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTotalDiscountVisible",
                table: "TabArticles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsUnitPriceVisible",
                table: "TabArticles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "PersonalizedRowAmount",
                table: "TabArticles",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "PersonalizedRowName",
                table: "TabArticles",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "ShippingCosts",
                table: "TabArticles",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ShippingCostsTaxId",
                table: "TabArticles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ShowShippingCosts",
                table: "TabArticles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Subtotal",
                table: "TabArticles",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "InvoiceSells",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOrder",
                table: "InvoiceSells",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InvoiceDate",
                table: "InvoiceSells",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BillingAddressId",
                table: "InvoiceSells",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryAddressId",
                table: "InvoiceSells",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "InvoiceSells",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceSellGroupId",
                table: "InvoiceSells",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "InvoiceSells",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonToContactId",
                table: "InvoiceSells",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "InvoiceImports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOrder",
                table: "InvoiceImports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InvoiceDate",
                table: "InvoiceImports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BillingAddressId",
                table: "InvoiceImports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryAddressId",
                table: "InvoiceImports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "InvoiceImports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PersonToContactId",
                table: "InvoiceImports",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "InvoiceCreditSells",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOrder",
                table: "InvoiceCreditSells",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InvoiceDate",
                table: "InvoiceCreditSells",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BillingAddressId",
                table: "InvoiceCreditSells",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryAddressId",
                table: "InvoiceCreditSells",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "InvoiceCreditSells",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PersonToContactId",
                table: "InvoiceCreditSells",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "InvoiceCreditImports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOrder",
                table: "InvoiceCreditImports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InvoiceDate",
                table: "InvoiceCreditImports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BillingAddressId",
                table: "InvoiceCreditImports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryAddressId",
                table: "InvoiceCreditImports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "InvoiceCreditImports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PersonToContactId",
                table: "InvoiceCreditImports",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TabArticlesItems_TabArticlesId",
                table: "TabArticlesItems",
                column: "TabArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_TabArticles_ShippingCostsTaxId",
                table: "TabArticles",
                column: "ShippingCostsTaxId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_BillingAddressId",
                table: "InvoiceSells",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_DeliveryAddressId",
                table: "InvoiceSells",
                column: "DeliveryAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_InvoiceSellGroupId",
                table: "InvoiceSells",
                column: "InvoiceSellGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_PaymentId",
                table: "InvoiceSells",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_PersonToContactId",
                table: "InvoiceSells",
                column: "PersonToContactId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceImports_BillingAddressId",
                table: "InvoiceImports",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceImports_DeliveryAddressId",
                table: "InvoiceImports",
                column: "DeliveryAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceImports_PersonToContactId",
                table: "InvoiceImports",
                column: "PersonToContactId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditSells_BillingAddressId",
                table: "InvoiceCreditSells",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditSells_DeliveryAddressId",
                table: "InvoiceCreditSells",
                column: "DeliveryAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditSells_PersonToContactId",
                table: "InvoiceCreditSells",
                column: "PersonToContactId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditImports_BillingAddressId",
                table: "InvoiceCreditImports",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditImports_DeliveryAddressId",
                table: "InvoiceCreditImports",
                column: "DeliveryAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditImports_PersonToContactId",
                table: "InvoiceCreditImports",
                column: "PersonToContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceCreditImports_Address_BillingAddressId",
                table: "InvoiceCreditImports",
                column: "BillingAddressId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceCreditImports_Address_DeliveryAddressId",
                table: "InvoiceCreditImports",
                column: "DeliveryAddressId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceCreditImports_PersonToContacts_PersonToContactId",
                table: "InvoiceCreditImports",
                column: "PersonToContactId",
                principalTable: "PersonToContacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceCreditSells_Address_BillingAddressId",
                table: "InvoiceCreditSells",
                column: "BillingAddressId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceCreditSells_Address_DeliveryAddressId",
                table: "InvoiceCreditSells",
                column: "DeliveryAddressId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceCreditSells_PersonToContacts_PersonToContactId",
                table: "InvoiceCreditSells",
                column: "PersonToContactId",
                principalTable: "PersonToContacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceImports_Address_BillingAddressId",
                table: "InvoiceImports",
                column: "BillingAddressId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceImports_Address_DeliveryAddressId",
                table: "InvoiceImports",
                column: "DeliveryAddressId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceImports_PersonToContacts_PersonToContactId",
                table: "InvoiceImports",
                column: "PersonToContactId",
                principalTable: "PersonToContacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceSells_Address_BillingAddressId",
                table: "InvoiceSells",
                column: "BillingAddressId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceSells_Address_DeliveryAddressId",
                table: "InvoiceSells",
                column: "DeliveryAddressId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceSells_InvoiceSellGroups_InvoiceSellGroupId",
                table: "InvoiceSells",
                column: "InvoiceSellGroupId",
                principalTable: "InvoiceSellGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceSells_PaymentSells_PaymentId",
                table: "InvoiceSells",
                column: "PaymentId",
                principalTable: "PaymentSells",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceSells_PersonToContacts_PersonToContactId",
                table: "InvoiceSells",
                column: "PersonToContactId",
                principalTable: "PersonToContacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_TabArticles_Taxes_ShippingCostsTaxId",
                table: "TabArticles",
                column: "ShippingCostsTaxId",
                principalTable: "Taxes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TabArticlesItems_TabArticles_TabArticlesId",
                table: "TabArticlesItems",
                column: "TabArticlesId",
                principalTable: "TabArticles",
                principalColumn: "Id");
        }
    }
}

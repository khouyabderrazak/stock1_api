using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_Data_Api.Migrations
{
    /// <inheritdoc />
    public partial class updateTablesssfs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_ClientId",
                table: "InvoiceSells",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_PaymentConditionId",
                table: "InvoiceSells",
                column: "PaymentConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_SellerId",
                table: "InvoiceSells",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesInf_articleId",
                table: "ArticlesInf",
                column: "articleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesInf_taxId",
                table: "ArticlesInf",
                column: "taxId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticlesInf_Articles_articleId",
                table: "ArticlesInf",
                column: "articleId",
                principalTable: "Articles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticlesInf_Taxes_taxId",
                table: "ArticlesInf",
                column: "taxId",
                principalTable: "Taxes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceSells_Clients_ClientId",
                table: "InvoiceSells",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceSells_PaymentConditions_PaymentConditionId",
                table: "InvoiceSells",
                column: "PaymentConditionId",
                principalTable: "PaymentConditions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceSells_Sellers_SellerId",
                table: "InvoiceSells",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticlesInf_Articles_articleId",
                table: "ArticlesInf");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticlesInf_Taxes_taxId",
                table: "ArticlesInf");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceSells_Clients_ClientId",
                table: "InvoiceSells");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceSells_PaymentConditions_PaymentConditionId",
                table: "InvoiceSells");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceSells_Sellers_SellerId",
                table: "InvoiceSells");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceSells_ClientId",
                table: "InvoiceSells");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceSells_PaymentConditionId",
                table: "InvoiceSells");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceSells_SellerId",
                table: "InvoiceSells");

            migrationBuilder.DropIndex(
                name: "IX_ArticlesInf_articleId",
                table: "ArticlesInf");

            migrationBuilder.DropIndex(
                name: "IX_ArticlesInf_taxId",
                table: "ArticlesInf");
        }
    }
}

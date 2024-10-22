using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_Data_Api.Migrations
{
    /// <inheritdoc />
    public partial class updateTablesss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceSells_AssociatedDocs_AssociatedDocsId",
                table: "InvoiceSells");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceSells_Clients_ClientId",
                table: "InvoiceSells");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceSells_PaymentConditions_PaymentConditionId",
                table: "InvoiceSells");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceSells_Sellers_SellerId",
                table: "InvoiceSells");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceSells_TabArticles_TabArticlesId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceSells_AssociatedDocs_AssociatedDocsId",
                table: "InvoiceSells",
                column: "AssociatedDocsId",
                principalTable: "AssociatedDocs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceSells_TabArticles_TabArticlesId",
                table: "InvoiceSells",
                column: "TabArticlesId",
                principalTable: "TabArticles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceSells_AssociatedDocs_AssociatedDocsId",
                table: "InvoiceSells");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceSells_TabArticles_TabArticlesId",
                table: "InvoiceSells");

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

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceSells_AssociatedDocs_AssociatedDocsId",
                table: "InvoiceSells",
                column: "AssociatedDocsId",
                principalTable: "AssociatedDocs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceSells_Clients_ClientId",
                table: "InvoiceSells",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceSells_PaymentConditions_PaymentConditionId",
                table: "InvoiceSells",
                column: "PaymentConditionId",
                principalTable: "PaymentConditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceSells_Sellers_SellerId",
                table: "InvoiceSells",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceSells_TabArticles_TabArticlesId",
                table: "InvoiceSells",
                column: "TabArticlesId",
                principalTable: "TabArticles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

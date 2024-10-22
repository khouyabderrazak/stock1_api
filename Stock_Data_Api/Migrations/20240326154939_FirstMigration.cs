using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_Data_Api.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    State = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleGroup",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleGroup", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ArticleStockInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountIdSuivi = table.Column<int>(type: "int", nullable: false),
                    StockOuverture = table.Column<long>(type: "bigint", nullable: true),
                    TauxOuverture = table.Column<long>(type: "bigint", nullable: true),
                    Seuil = table.Column<long>(type: "bigint", nullable: true),
                    Stockdisponible = table.Column<long>(type: "bigint", nullable: true),
                    StockEngagee = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleStockInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssociatedDocs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociatedDocs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientOrderGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientOrderGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryModes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryModes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Width = table.Column<float>(type: "real", nullable: false),
                    Length = table.Column<float>(type: "real", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceImportCreditGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceImportCreditGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceImportGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceImportGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceSellCreditGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceSellCreditGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarkName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderToSupplierGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderToSupplierGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentModes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentModes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonToContacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumberPro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumberPortable = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Department = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonToContacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Taxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ratio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssociatedDocsFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssociatedDocsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociatedDocsFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssociatedDocsFiles_AssociatedDocs_AssociatedDocsId",
                        column: x => x.AssociatedDocsId,
                        principalTable: "AssociatedDocs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cheques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChequeNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    AccountHolderName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PayeeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Memo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cheques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cheques_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cheques_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleSellingInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PricePerUnit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleSellingInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleSellingInfos_Taxes_TaxId",
                        column: x => x.TaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhonePro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PhonePortable = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingAddressId = table.Column<int>(type: "int", nullable: true),
                    DeliveryAddressId = table.Column<int>(type: "int", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    TaxId = table.Column<int>(type: "int", nullable: true),
                    PaymentConditionId = table.Column<int>(type: "int", nullable: true),
                    AssociatedDocsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Address_BillingAddressId",
                        column: x => x.BillingAddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clients_Address_DeliveryAddressId",
                        column: x => x.DeliveryAddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clients_AssociatedDocs_AssociatedDocsId",
                        column: x => x.AssociatedDocsId,
                        principalTable: "AssociatedDocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clients_PaymentConditions_PaymentConditionId",
                        column: x => x.PaymentConditionId,
                        principalTable: "PaymentConditions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clients_Taxes_TaxId",
                        column: x => x.TaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhonePro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PhonePortable = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingAddressId = table.Column<int>(type: "int", nullable: true),
                    DeliveryAddressId = table.Column<int>(type: "int", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    TaxId = table.Column<int>(type: "int", nullable: true),
                    PaymentConditionId = table.Column<int>(type: "int", nullable: true),
                    AssociatedDocsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suppliers_Address_BillingAddressId",
                        column: x => x.BillingAddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Suppliers_Address_DeliveryAddressId",
                        column: x => x.DeliveryAddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Suppliers_AssociatedDocs_AssociatedDocsId",
                        column: x => x.AssociatedDocsId,
                        principalTable: "AssociatedDocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Suppliers_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Suppliers_PaymentConditions_PaymentConditionId",
                        column: x => x.PaymentConditionId,
                        principalTable: "PaymentConditions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Suppliers_Taxes_TaxId",
                        column: x => x.TaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TabArticles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PersonalizedRowName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PersonalizedRowAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShippingCosts = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShippingCostsTaxId = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountTotal = table.Column<double>(type: "float", nullable: true),
                    DiscountState = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsArticleVisible = table.Column<bool>(type: "bit", nullable: false),
                    IsQuantityVisible = table.Column<bool>(type: "bit", nullable: false),
                    IsTaxVisible = table.Column<bool>(type: "bit", nullable: false),
                    IsUnitPriceVisible = table.Column<bool>(type: "bit", nullable: false),
                    IsDiscountVisible = table.Column<bool>(type: "bit", nullable: false),
                    IsTotalDiscountVisible = table.Column<bool>(type: "bit", nullable: false),
                    IsItemTotalVisible = table.Column<bool>(type: "bit", nullable: false),
                    DoApplyDiscount = table.Column<bool>(type: "bit", nullable: false),
                    ShowShippingCosts = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabArticles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabArticles_Taxes_ShippingCostsTaxId",
                        column: x => x.ShippingCostsTaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentSells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    N_Payment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    N_Reference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AssociatedDocsId = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentSells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentSells_AssociatedDocs_AssociatedDocsId",
                        column: x => x.AssociatedDocsId,
                        principalTable: "AssociatedDocs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentSells_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PersonContactsClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonToContactId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonContactsClients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonContactsClients_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PersonContactsClients_PersonToContacts_PersonToContactId",
                        column: x => x.PersonToContactId,
                        principalTable: "PersonToContacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArticleImportInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierId = table.Column<int>(type: "int", nullable: true),
                    PricePerUnit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleImportInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleImportInfos_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ArticleImportInfos_Taxes_TaxId",
                        column: x => x.TaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentImports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    N_Payment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    N_Reference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AssociatedDocsId = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentImports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentImports_AssociatedDocs_AssociatedDocsId",
                        column: x => x.AssociatedDocsId,
                        principalTable: "AssociatedDocs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentImports_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PersonContactsSuppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonToContactId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonContactsSuppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonContactsSuppliers_PersonToContacts_PersonToContactId",
                        column: x => x.PersonToContactId,
                        principalTable: "PersonToContacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonContactsSuppliers_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InvoiceCreditImports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    InvoiceImportGroupId = table.Column<int>(type: "int", nullable: true),
                    NInvoice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOrder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentConditionId = table.Column<int>(type: "int", nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SellerId = table.Column<int>(type: "int", nullable: true),
                    PersonToContactId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TabArticlesId = table.Column<int>(type: "int", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssociatedDocsId = table.Column<int>(type: "int", nullable: true),
                    BillingAddressId = table.Column<int>(type: "int", nullable: true),
                    DeliveryAddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceCreditImports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceCreditImports_Address_BillingAddressId",
                        column: x => x.BillingAddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceCreditImports_Address_DeliveryAddressId",
                        column: x => x.DeliveryAddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceCreditImports_AssociatedDocs_AssociatedDocsId",
                        column: x => x.AssociatedDocsId,
                        principalTable: "AssociatedDocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceCreditImports_InvoiceImportCreditGroups_InvoiceImportGroupId",
                        column: x => x.InvoiceImportGroupId,
                        principalTable: "InvoiceImportCreditGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceCreditImports_PaymentConditions_PaymentConditionId",
                        column: x => x.PaymentConditionId,
                        principalTable: "PaymentConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceCreditImports_PersonToContacts_PersonToContactId",
                        column: x => x.PersonToContactId,
                        principalTable: "PersonToContacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceCreditImports_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceCreditImports_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceCreditImports_TabArticles_TabArticlesId",
                        column: x => x.TabArticlesId,
                        principalTable: "TabArticles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChequeOfModeSells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentSellId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentModeId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChequeOfModeSells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChequeOfModeSells_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChequeOfModeSells_PaymentModes_PaymentModeId",
                        column: x => x.PaymentModeId,
                        principalTable: "PaymentModes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChequeOfModeSells_PaymentSells_PaymentSellId",
                        column: x => x.PaymentSellId,
                        principalTable: "PaymentSells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentOfModeSells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentSellId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentModeId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentOfModeSells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentOfModeSells_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentOfModeSells_PaymentModes_PaymentModeId",
                        column: x => x.PaymentModeId,
                        principalTable: "PaymentModes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentOfModeSells_PaymentSells_PaymentSellId",
                        column: x => x.PaymentSellId,
                        principalTable: "PaymentSells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticleGroupId = table.Column<int>(type: "int", nullable: true),
                    MarkId = table.Column<int>(type: "int", nullable: true),
                    Sku = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitId = table.Column<int>(type: "int", nullable: true),
                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
                    Upc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsReturnable = table.Column<bool>(type: "bit", nullable: true),
                    Ean = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DimensionId = table.Column<int>(type: "int", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: true),
                    SellInfoId = table.Column<int>(type: "int", nullable: true),
                    ImportInfoId = table.Column<int>(type: "int", nullable: true),
                    Mpn = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Isbn = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TypeArticle = table.Column<int>(type: "int", nullable: true),
                    FollowStock = table.Column<bool>(type: "bit", nullable: true),
                    ArticleStockInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_ArticleGroup_ArticleGroupId",
                        column: x => x.ArticleGroupId,
                        principalTable: "ArticleGroup",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Articles_ArticleImportInfos_ImportInfoId",
                        column: x => x.ImportInfoId,
                        principalTable: "ArticleImportInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Articles_ArticleSellingInfos_SellInfoId",
                        column: x => x.SellInfoId,
                        principalTable: "ArticleSellingInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Articles_ArticleStockInfos_ArticleStockInfoId",
                        column: x => x.ArticleStockInfoId,
                        principalTable: "ArticleStockInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Dimensions_DimensionId",
                        column: x => x.DimensionId,
                        principalTable: "Dimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Articles_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Articles_Marks_MarkId",
                        column: x => x.MarkId,
                        principalTable: "Marks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Articles_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceImports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    InvoiceImportGroupId = table.Column<int>(type: "int", nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    NInvoice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOrder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentConditionId = table.Column<int>(type: "int", nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SellerId = table.Column<int>(type: "int", nullable: true),
                    PersonToContactId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TabArticlesId = table.Column<int>(type: "int", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssociatedDocsId = table.Column<int>(type: "int", nullable: true),
                    BillingAddressId = table.Column<int>(type: "int", nullable: true),
                    DeliveryAddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceImports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceImports_Address_BillingAddressId",
                        column: x => x.BillingAddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceImports_Address_DeliveryAddressId",
                        column: x => x.DeliveryAddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceImports_AssociatedDocs_AssociatedDocsId",
                        column: x => x.AssociatedDocsId,
                        principalTable: "AssociatedDocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceImports_InvoiceImportGroups_InvoiceImportGroupId",
                        column: x => x.InvoiceImportGroupId,
                        principalTable: "InvoiceImportGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceImports_PaymentConditions_PaymentConditionId",
                        column: x => x.PaymentConditionId,
                        principalTable: "PaymentConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceImports_PaymentImports_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "PaymentImports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceImports_PersonToContacts_PersonToContactId",
                        column: x => x.PersonToContactId,
                        principalTable: "PersonToContacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceImports_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceImports_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceImports_TabArticles_TabArticlesId",
                        column: x => x.TabArticlesId,
                        principalTable: "TabArticles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentOfModeImports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentImportId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentModeId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentOfModeImports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentOfModeImports_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentOfModeImports_PaymentImports_PaymentImportId",
                        column: x => x.PaymentImportId,
                        principalTable: "PaymentImports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentOfModeImports_PaymentModes_PaymentModeId",
                        column: x => x.PaymentModeId,
                        principalTable: "PaymentModes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TabArticlesItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountType = table.Column<int>(type: "int", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: true),
                    TaxId = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    TabArticlesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabArticlesItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabArticlesItems_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TabArticlesItems_TabArticles_TabArticlesId",
                        column: x => x.TabArticlesId,
                        principalTable: "TabArticles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TabArticlesItems_Taxes_TaxId",
                        column: x => x.TaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceSellGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelatedInvoiceImportId = table.Column<int>(type: "int", nullable: true),
                    MaxAmount = table.Column<double>(type: "float", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceSellGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceSellGroups_InvoiceImports_RelatedInvoiceImportId",
                        column: x => x.RelatedInvoiceImportId,
                        principalTable: "InvoiceImports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "CustumerOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    NReference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOrder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstimatedExpeditionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    PaymentConditionId = table.Column<int>(type: "int", nullable: true),
                    SellerId = table.Column<int>(type: "int", nullable: true),
                    PersonToContactId = table.Column<int>(type: "int", nullable: true),
                    TabArticlesId = table.Column<int>(type: "int", nullable: false),
                    AssociatedDocsId = table.Column<int>(type: "int", nullable: false),
                    DeliveryAddressId = table.Column<int>(type: "int", nullable: true),
                    DeliveryModeId = table.Column<int>(type: "int", nullable: true),
                    OrderToSupplierGroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustumerOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustumerOrders_Address_DeliveryAddressId",
                        column: x => x.DeliveryAddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_CustumerOrders_AssociatedDocs_AssociatedDocsId",
                        column: x => x.AssociatedDocsId,
                        principalTable: "AssociatedDocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustumerOrders_ClientOrderGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "ClientOrderGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_CustumerOrders_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustumerOrders_DeliveryModes_DeliveryModeId",
                        column: x => x.DeliveryModeId,
                        principalTable: "DeliveryModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_CustumerOrders_InvoiceSellGroups_OrderToSupplierGroupId",
                        column: x => x.OrderToSupplierGroupId,
                        principalTable: "InvoiceSellGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_CustumerOrders_PaymentConditions_PaymentConditionId",
                        column: x => x.PaymentConditionId,
                        principalTable: "PaymentConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_CustumerOrders_PaymentSells_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "PaymentSells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_CustumerOrders_PersonToContacts_PersonToContactId",
                        column: x => x.PersonToContactId,
                        principalTable: "PersonToContacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_CustumerOrders_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_CustumerOrders_TabArticles_TabArticlesId",
                        column: x => x.TabArticlesId,
                        principalTable: "TabArticles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceCreditSells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    InvoiceSellGroupId = table.Column<int>(type: "int", nullable: true),
                    NInvoice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOrder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentConditionId = table.Column<int>(type: "int", nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SellerId = table.Column<int>(type: "int", nullable: true),
                    PersonToContactId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TabArticlesId = table.Column<int>(type: "int", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssociatedDocsId = table.Column<int>(type: "int", nullable: true),
                    BillingAddressId = table.Column<int>(type: "int", nullable: true),
                    DeliveryAddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceCreditSells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceCreditSells_Address_BillingAddressId",
                        column: x => x.BillingAddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceCreditSells_Address_DeliveryAddressId",
                        column: x => x.DeliveryAddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceCreditSells_AssociatedDocs_AssociatedDocsId",
                        column: x => x.AssociatedDocsId,
                        principalTable: "AssociatedDocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceCreditSells_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceCreditSells_InvoiceSellGroups_InvoiceSellGroupId",
                        column: x => x.InvoiceSellGroupId,
                        principalTable: "InvoiceSellGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceCreditSells_PaymentConditions_PaymentConditionId",
                        column: x => x.PaymentConditionId,
                        principalTable: "PaymentConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceCreditSells_PersonToContacts_PersonToContactId",
                        column: x => x.PersonToContactId,
                        principalTable: "PersonToContacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceCreditSells_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceCreditSells_TabArticles_TabArticlesId",
                        column: x => x.TabArticlesId,
                        principalTable: "TabArticles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceSells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    InvoiceSellGroupId = table.Column<int>(type: "int", nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    NInvoice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOrder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentConditionId = table.Column<int>(type: "int", nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SellerId = table.Column<int>(type: "int", nullable: true),
                    PersonToContactId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TabArticlesId = table.Column<int>(type: "int", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssociatedDocsId = table.Column<int>(type: "int", nullable: true),
                    BillingAddressId = table.Column<int>(type: "int", nullable: true),
                    DeliveryAddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceSells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceSells_Address_BillingAddressId",
                        column: x => x.BillingAddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceSells_Address_DeliveryAddressId",
                        column: x => x.DeliveryAddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceSells_AssociatedDocs_AssociatedDocsId",
                        column: x => x.AssociatedDocsId,
                        principalTable: "AssociatedDocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceSells_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceSells_InvoiceSellGroups_InvoiceSellGroupId",
                        column: x => x.InvoiceSellGroupId,
                        principalTable: "InvoiceSellGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceSells_PaymentConditions_PaymentConditionId",
                        column: x => x.PaymentConditionId,
                        principalTable: "PaymentConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceSells_PaymentSells_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "PaymentSells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceSells_PersonToContacts_PersonToContactId",
                        column: x => x.PersonToContactId,
                        principalTable: "PersonToContacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceSells_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InvoiceSells_TabArticles_TabArticlesId",
                        column: x => x.TabArticlesId,
                        principalTable: "TabArticles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderToSuppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    NReference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOrder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstimatedExpeditionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    PaymentConditionId = table.Column<int>(type: "int", nullable: true),
                    SellerId = table.Column<int>(type: "int", nullable: true),
                    PersonToContactId = table.Column<int>(type: "int", nullable: true),
                    TabArticlesId = table.Column<int>(type: "int", nullable: false),
                    AssociatedDocsId = table.Column<int>(type: "int", nullable: false),
                    DeliveryAddressId = table.Column<int>(type: "int", nullable: true),
                    DeliveryModeId = table.Column<int>(type: "int", nullable: true),
                    OrderToSupplierGroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderToSuppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderToSuppliers_Address_DeliveryAddressId",
                        column: x => x.DeliveryAddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_OrderToSuppliers_AssociatedDocs_AssociatedDocsId",
                        column: x => x.AssociatedDocsId,
                        principalTable: "AssociatedDocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderToSuppliers_DeliveryModes_DeliveryModeId",
                        column: x => x.DeliveryModeId,
                        principalTable: "DeliveryModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_OrderToSuppliers_InvoiceSellGroups_OrderToSupplierGroupId",
                        column: x => x.OrderToSupplierGroupId,
                        principalTable: "InvoiceSellGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_OrderToSuppliers_OrderToSupplierGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "OrderToSupplierGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_OrderToSuppliers_PaymentConditions_PaymentConditionId",
                        column: x => x.PaymentConditionId,
                        principalTable: "PaymentConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_OrderToSuppliers_PaymentImports_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "PaymentImports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_OrderToSuppliers_PersonToContacts_PersonToContactId",
                        column: x => x.PersonToContactId,
                        principalTable: "PersonToContacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_OrderToSuppliers_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_OrderToSuppliers_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderToSuppliers_TabArticles_TabArticlesId",
                        column: x => x.TabArticlesId,
                        principalTable: "TabArticles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleImportInfos_SupplierId",
                table: "ArticleImportInfos",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleImportInfos_TaxId",
                table: "ArticleImportInfos",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleGroupId",
                table: "Articles",
                column: "ArticleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleStockInfoId",
                table: "Articles",
                column: "ArticleStockInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_DimensionId",
                table: "Articles",
                column: "DimensionId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ImportInfoId",
                table: "Articles",
                column: "ImportInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ManufacturerId",
                table: "Articles",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_MarkId",
                table: "Articles",
                column: "MarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_SellInfoId",
                table: "Articles",
                column: "SellInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UnitId",
                table: "Articles",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleSellingInfos_TaxId",
                table: "ArticleSellingInfos",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_AssociatedDocsFiles_AssociatedDocsId",
                table: "AssociatedDocsFiles",
                column: "AssociatedDocsId");

            migrationBuilder.CreateIndex(
                name: "IX_ChequeOfModeSells_CurrencyId",
                table: "ChequeOfModeSells",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ChequeOfModeSells_PaymentModeId",
                table: "ChequeOfModeSells",
                column: "PaymentModeId");

            migrationBuilder.CreateIndex(
                name: "IX_ChequeOfModeSells_PaymentSellId",
                table: "ChequeOfModeSells",
                column: "PaymentSellId");

            migrationBuilder.CreateIndex(
                name: "IX_Cheques_BankId",
                table: "Cheques",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_Cheques_CurrencyId",
                table: "Cheques",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AssociatedDocsId",
                table: "Clients",
                column: "AssociatedDocsId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_BillingAddressId",
                table: "Clients",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CurrencyId",
                table: "Clients",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_DeliveryAddressId",
                table: "Clients",
                column: "DeliveryAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_PaymentConditionId",
                table: "Clients",
                column: "PaymentConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_TaxId",
                table: "Clients",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_CustumerOrders_AssociatedDocsId",
                table: "CustumerOrders",
                column: "AssociatedDocsId");

            migrationBuilder.CreateIndex(
                name: "IX_CustumerOrders_ClientId",
                table: "CustumerOrders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_CustumerOrders_DeliveryAddressId",
                table: "CustumerOrders",
                column: "DeliveryAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_CustumerOrders_DeliveryModeId",
                table: "CustumerOrders",
                column: "DeliveryModeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustumerOrders_GroupId",
                table: "CustumerOrders",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CustumerOrders_OrderToSupplierGroupId",
                table: "CustumerOrders",
                column: "OrderToSupplierGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CustumerOrders_PaymentConditionId",
                table: "CustumerOrders",
                column: "PaymentConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_CustumerOrders_PaymentId",
                table: "CustumerOrders",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_CustumerOrders_PersonToContactId",
                table: "CustumerOrders",
                column: "PersonToContactId");

            migrationBuilder.CreateIndex(
                name: "IX_CustumerOrders_SellerId",
                table: "CustumerOrders",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustumerOrders_TabArticlesId",
                table: "CustumerOrders",
                column: "TabArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditImports_AssociatedDocsId",
                table: "InvoiceCreditImports",
                column: "AssociatedDocsId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditImports_BillingAddressId",
                table: "InvoiceCreditImports",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditImports_DeliveryAddressId",
                table: "InvoiceCreditImports",
                column: "DeliveryAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditImports_InvoiceImportGroupId",
                table: "InvoiceCreditImports",
                column: "InvoiceImportGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditImports_PaymentConditionId",
                table: "InvoiceCreditImports",
                column: "PaymentConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditImports_PersonToContactId",
                table: "InvoiceCreditImports",
                column: "PersonToContactId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditImports_SellerId",
                table: "InvoiceCreditImports",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditImports_SupplierId",
                table: "InvoiceCreditImports",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditImports_TabArticlesId",
                table: "InvoiceCreditImports",
                column: "TabArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditSells_AssociatedDocsId",
                table: "InvoiceCreditSells",
                column: "AssociatedDocsId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditSells_BillingAddressId",
                table: "InvoiceCreditSells",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditSells_ClientId",
                table: "InvoiceCreditSells",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditSells_DeliveryAddressId",
                table: "InvoiceCreditSells",
                column: "DeliveryAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditSells_InvoiceSellGroupId",
                table: "InvoiceCreditSells",
                column: "InvoiceSellGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditSells_PaymentConditionId",
                table: "InvoiceCreditSells",
                column: "PaymentConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditSells_PersonToContactId",
                table: "InvoiceCreditSells",
                column: "PersonToContactId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditSells_SellerId",
                table: "InvoiceCreditSells",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreditSells_TabArticlesId",
                table: "InvoiceCreditSells",
                column: "TabArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceImports_AssociatedDocsId",
                table: "InvoiceImports",
                column: "AssociatedDocsId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceImports_BillingAddressId",
                table: "InvoiceImports",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceImports_DeliveryAddressId",
                table: "InvoiceImports",
                column: "DeliveryAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceImports_InvoiceImportGroupId",
                table: "InvoiceImports",
                column: "InvoiceImportGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceImports_PaymentConditionId",
                table: "InvoiceImports",
                column: "PaymentConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceImports_PaymentId",
                table: "InvoiceImports",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceImports_PersonToContactId",
                table: "InvoiceImports",
                column: "PersonToContactId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceImports_SellerId",
                table: "InvoiceImports",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceImports_SupplierId",
                table: "InvoiceImports",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceImports_TabArticlesId",
                table: "InvoiceImports",
                column: "TabArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSellGroups_RelatedInvoiceImportId",
                table: "InvoiceSellGroups",
                column: "RelatedInvoiceImportId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_AssociatedDocsId",
                table: "InvoiceSells",
                column: "AssociatedDocsId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_BillingAddressId",
                table: "InvoiceSells",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_ClientId",
                table: "InvoiceSells",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_DeliveryAddressId",
                table: "InvoiceSells",
                column: "DeliveryAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_InvoiceSellGroupId",
                table: "InvoiceSells",
                column: "InvoiceSellGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_PaymentConditionId",
                table: "InvoiceSells",
                column: "PaymentConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_PaymentId",
                table: "InvoiceSells",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_PersonToContactId",
                table: "InvoiceSells",
                column: "PersonToContactId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_SellerId",
                table: "InvoiceSells",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSells_TabArticlesId",
                table: "InvoiceSells",
                column: "TabArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderToSuppliers_AssociatedDocsId",
                table: "OrderToSuppliers",
                column: "AssociatedDocsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderToSuppliers_DeliveryAddressId",
                table: "OrderToSuppliers",
                column: "DeliveryAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderToSuppliers_DeliveryModeId",
                table: "OrderToSuppliers",
                column: "DeliveryModeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderToSuppliers_GroupId",
                table: "OrderToSuppliers",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderToSuppliers_OrderToSupplierGroupId",
                table: "OrderToSuppliers",
                column: "OrderToSupplierGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderToSuppliers_PaymentConditionId",
                table: "OrderToSuppliers",
                column: "PaymentConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderToSuppliers_PaymentId",
                table: "OrderToSuppliers",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderToSuppliers_PersonToContactId",
                table: "OrderToSuppliers",
                column: "PersonToContactId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderToSuppliers_SellerId",
                table: "OrderToSuppliers",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderToSuppliers_SupplierId",
                table: "OrderToSuppliers",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderToSuppliers_TabArticlesId",
                table: "OrderToSuppliers",
                column: "TabArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentImports_AssociatedDocsId",
                table: "PaymentImports",
                column: "AssociatedDocsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentImports_SupplierId",
                table: "PaymentImports",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOfModeImports_CurrencyId",
                table: "PaymentOfModeImports",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOfModeImports_PaymentImportId",
                table: "PaymentOfModeImports",
                column: "PaymentImportId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOfModeImports_PaymentModeId",
                table: "PaymentOfModeImports",
                column: "PaymentModeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOfModeSells_CurrencyId",
                table: "PaymentOfModeSells",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOfModeSells_PaymentModeId",
                table: "PaymentOfModeSells",
                column: "PaymentModeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOfModeSells_PaymentSellId",
                table: "PaymentOfModeSells",
                column: "PaymentSellId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSells_AssociatedDocsId",
                table: "PaymentSells",
                column: "AssociatedDocsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSells_ClientId",
                table: "PaymentSells",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonContactsClients_ClientId",
                table: "PersonContactsClients",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonContactsClients_PersonToContactId",
                table: "PersonContactsClients",
                column: "PersonToContactId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonContactsSuppliers_PersonToContactId",
                table: "PersonContactsSuppliers",
                column: "PersonToContactId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonContactsSuppliers_SupplierId",
                table: "PersonContactsSuppliers",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_AssociatedDocsId",
                table: "Suppliers",
                column: "AssociatedDocsId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_BillingAddressId",
                table: "Suppliers",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_CurrencyId",
                table: "Suppliers",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_DeliveryAddressId",
                table: "Suppliers",
                column: "DeliveryAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_PaymentConditionId",
                table: "Suppliers",
                column: "PaymentConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_TaxId",
                table: "Suppliers",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_TabArticles_ShippingCostsTaxId",
                table: "TabArticles",
                column: "ShippingCostsTaxId");

            migrationBuilder.CreateIndex(
                name: "IX_TabArticlesItems_ArticleId",
                table: "TabArticlesItems",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_TabArticlesItems_TabArticlesId",
                table: "TabArticlesItems",
                column: "TabArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_TabArticlesItems_TaxId",
                table: "TabArticlesItems",
                column: "TaxId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssociatedDocsFiles");

            migrationBuilder.DropTable(
                name: "ChequeOfModeSells");

            migrationBuilder.DropTable(
                name: "Cheques");

            migrationBuilder.DropTable(
                name: "CustumerOrders");

            migrationBuilder.DropTable(
                name: "InvoiceCreditImports");

            migrationBuilder.DropTable(
                name: "InvoiceCreditSells");

            migrationBuilder.DropTable(
                name: "InvoiceSellCreditGroups");

            migrationBuilder.DropTable(
                name: "InvoiceSells");

            migrationBuilder.DropTable(
                name: "OrderToSuppliers");

            migrationBuilder.DropTable(
                name: "PaymentOfModeImports");

            migrationBuilder.DropTable(
                name: "PaymentOfModeSells");

            migrationBuilder.DropTable(
                name: "PersonContactsClients");

            migrationBuilder.DropTable(
                name: "PersonContactsSuppliers");

            migrationBuilder.DropTable(
                name: "TabArticlesItems");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "ClientOrderGroups");

            migrationBuilder.DropTable(
                name: "InvoiceImportCreditGroups");

            migrationBuilder.DropTable(
                name: "DeliveryModes");

            migrationBuilder.DropTable(
                name: "InvoiceSellGroups");

            migrationBuilder.DropTable(
                name: "OrderToSupplierGroups");

            migrationBuilder.DropTable(
                name: "PaymentModes");

            migrationBuilder.DropTable(
                name: "PaymentSells");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "InvoiceImports");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "ArticleGroup");

            migrationBuilder.DropTable(
                name: "ArticleImportInfos");

            migrationBuilder.DropTable(
                name: "ArticleSellingInfos");

            migrationBuilder.DropTable(
                name: "ArticleStockInfos");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "InvoiceImportGroups");

            migrationBuilder.DropTable(
                name: "PaymentImports");

            migrationBuilder.DropTable(
                name: "PersonToContacts");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "TabArticles");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "AssociatedDocs");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "PaymentConditions");

            migrationBuilder.DropTable(
                name: "Taxes");
        }
    }
}

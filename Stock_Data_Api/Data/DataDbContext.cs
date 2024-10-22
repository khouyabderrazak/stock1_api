using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models;
using Stock_Data_Api.Models.Frequent_Entiities;
using Stock_Data_Api.Models.Import;
using Stock_Data_Api.Models.Import.Group_Classes;
using Stock_Data_Api.Models.Inventory;
using Stock_Data_Api.Models.Sell;
using Stock_Data_Api.Models.Sell.Group_Classes;

namespace Stock_Data_Api.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<PaymentCondition> PaymentConditions { get; set; }
        public virtual DbSet<Tax> Taxes { get; set; }
        public virtual DbSet<AssociatedDocs> AssociatedDocs { get; set; }
        public virtual DbSet<AssociatedDocsFile> AssociatedDocsFiles { get; set; }
        public virtual DbSet<Dimension> Dimensions { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<PersonToContact> PersonToContacts { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Cheque> Cheques { get; set; }
        public virtual DbSet<PaymentMode> PaymentModes { get; set; }
        public virtual DbSet<PaymentSell> PaymentSells { get; set; }
        public virtual DbSet<PaymentOfModeSell> PaymentOfModeSells { get; set; }
        public virtual DbSet<PaymentImport> PaymentImports { get; set; }
        public virtual DbSet<PaymentOfModeImport> PaymentOfModeImports { get; set; }
        public virtual DbSet<ChequeOfModeSell> ChequeOfModeSells { get; set; }
        public virtual DbSet<PersonContactsClient> PersonContactsClients { get; set; }
        public virtual DbSet<PersonContactsSupplier> PersonContactsSuppliers { get; set; }
        public virtual DbSet<ArticleSellingInfo> ArticleSellingInfos { get; set; }
        public virtual DbSet<ArticleImportInfo> ArticleImportInfos { get; set; }
        public virtual DbSet<DeliveryMode> DeliveryModes { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<TabArticles> TabArticles { get; set; }
        public virtual DbSet<ArticlesInfo> ArticlesInf { get; set; }
        public virtual DbSet<TabArticlesItem> TabArticlesItems { get; set; }
        public virtual DbSet<InvoiceImportGroup> InvoiceImportGroups { get; set; }
        public virtual DbSet<InvoiceImportCreditGroup> InvoiceImportCreditGroups { get; set; }
        public virtual DbSet<OrderToSupplierGroup> OrderToSupplierGroups { get; set; }
        public virtual DbSet<InvoiceImport> InvoiceImports { get; set; }
        public virtual DbSet<InvoiceCreditImport> InvoiceCreditImports { get; set; }
        public virtual DbSet<OrderToSupplier> OrderToSuppliers { get; set; }
        public virtual DbSet<InvoiceSellGroup> InvoiceSellGroups { get; set; }
        public virtual DbSet<InvoiceSellCreditGroup> InvoiceSellCreditGroups { get; set; }
        public virtual DbSet<ClientOrderGroup> ClientOrderGroups { get; set; }
        public virtual DbSet<InvoiceSell> InvoiceSells { get; set; }
        public virtual DbSet<InvoiceCreditSell> InvoiceCreditSells { get; set; }
        
        public virtual DbSet<CustumerOrder> CustumerOrders { get; set; }
        public virtual DbSet<ArticleStockInfo> ArticleStockInfos { get; set; }

        public virtual DbSet<ArticleGroup> ArticleGroups { get; set; }

        public virtual DbSet<DataIOT> IOTtable { get; set; }

        public virtual DbSet<User> Users { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models.Inventory
{
    public class ArticleStockInfo
    {
        [Key]
        public int Id { get; set; }
        public int AccountIdSuivi { get; set; }
        public long? StockOuverture { get; set; }
        public long? TauxOuverture { get; set; }
        public long? Seuil { get; set; }
        public long? Stockdisponible { get; set; }
        public long? StockEngagee { get; set; }
    }
}

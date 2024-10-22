using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Commons;
using Stock_Data_Api.Models.Inventory;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock_Data_Api.Models.Frequent_Entiities
{
    public class TabArticlesItem
    {
        [Key]
        public int Id { get; set; }

        public double Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public DiscountType DiscountType { get; set; }

        public int? ArticleId { get; set; }
        [ForeignKey(nameof(ArticleId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Article? Article { get; set; }

        public int? TaxId { get; set; }
        [ForeignKey(nameof(TaxId))]
        [DeleteBehavior(DeleteBehavior.SetNull)]
        public Tax? Tax { get; set; }
        //[DeleteBehavior(DeleteBehavior.Cascade)]
        //public TabArticles TabArticles { get; set; }

        public double? Total { get; set; }

        public string Comment { get; set; }

        public int? AccountId { get; set; }

    }
}

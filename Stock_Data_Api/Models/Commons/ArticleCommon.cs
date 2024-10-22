using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Inventory;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock_Data_Api.Models.Commons
{
    public class ArticleCommon
    {
        public string? Sku { get; set; }

        public int? UnitId { get; set; }
        [ForeignKey(nameof(UnitId))]
        [DeleteBehavior(DeleteBehavior.SetNull)]
        public Unit? Unit { get; set; }

        public int? ManufacturerId { get; set; }
        [ForeignKey(nameof(ManufacturerId))]
        [DeleteBehavior(DeleteBehavior.SetNull)]
        public Manufacturer? Manufacturer { get; set; }

        [StringLength(100)]
        public string? Upc { get; set; }

        public bool? IsReturnable { get; set; }

        public string? Ean { get; set; }

        public int? DimensionId {get;set;}
        [ForeignKey(nameof(DimensionId))] 
        [DeleteBehavior(DeleteBehavior.SetNull)]
        public Dimension? Dimension { get; set; }

        public string? ImagePath { get; set; }

        public float? Weight { get; set; }

        public int? SellInfoId { get; set; }
        [ForeignKey(nameof(SellInfoId))]
        [DeleteBehavior(DeleteBehavior.SetNull)]
        public ArticleSellingInfo? SellInfo { get; set; }

        public int? ImportInfoId { get; set; }
        [ForeignKey(nameof(ImportInfoId))]
        [DeleteBehavior(DeleteBehavior.SetNull)]
        public ArticleImportInfo? ImportInfo { get; set; }

        [StringLength(255)]
        public string? Mpn { get; set; }

        [StringLength(255)]
        public string? Isbn { get; set; }

        public ArticleType? TypeArticle { get; set; }

        public bool? FollowStock { get; set; }

        public int? ArticleStockInfoId{ get; set; }
        [ForeignKey(nameof(ArticleStockInfoId))]
        [DeleteBehavior(DeleteBehavior.Cascade)]
        public  ArticleStockInfo? ArticleStockInf {get;set;}

    }
}

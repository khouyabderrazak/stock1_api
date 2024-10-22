using Stock_Data_Api.Models.Commons;
using Stock_Data_Api.Models.Inventory;
using Stock_Data_Api.Models.Sell;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock_Data_Api.Models.Frequent_Entiities
{
    public class TabArticles
    {
        [Key]
        public int Id { get; set; }
        public decimal? fraisdexpedition { get; set; }
        public decimal? total { get; set; }
        public decimal? sousTotal{ get; set; }
        public decimal? taxTotal { get; set; }


        public  List<ArticlesInfo>? articlesInfo { get; set; }
    }

}

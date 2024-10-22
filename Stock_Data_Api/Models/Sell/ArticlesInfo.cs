using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Stock_Data_Api.Models.Frequent_Entiities;
using Stock_Data_Api.Models.Inventory;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace Stock_Data_Api.Models.Sell
{
    public class ArticlesInfo
    {
          [Key]
          public int id { get; set; }
          public int? articleId { get; set; }
          [ForeignKey(nameof(articleId))] 
          public Article? Article { get; set; } = null;
          public  decimal?  quantite { get; set; }
          public  decimal?  taux{ get; set; }  

          public int?  taxId{ get; set; }
          [ForeignKey(nameof(taxId))]
          public Tax? Tax { get; set; } = null;
          public decimal?  montant{ get; set; }
          public string? note{ get; set; }

          [InverseProperty(nameof(TabArticles.articlesInfo))]
          public int? tabArticlesId { get; set; }
          
                    
          
    }
}

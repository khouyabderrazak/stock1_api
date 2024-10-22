using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Commons;
using Stock_Data_Api.Models.Import;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock_Data_Api.Models.Inventory
{
    public class ArticleImportInfo : CommonOpArticleInfo
    {
        public int? SupplierId { get;set;}
        [ForeignKey(nameof(SupplierId))] 
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Supplier? PreferredSupplier { get; set; }
    }
}

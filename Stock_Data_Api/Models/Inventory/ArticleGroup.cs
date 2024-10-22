using System.ComponentModel.DataAnnotations.Schema;

namespace Stock_Data_Api.Models.Inventory
{
    public class ArticleGroup
    {
        public int ID { get; set; }
        public string GroupName { get; set; }
        public string? ImagePath { get; set; }
        public string? Description  { get; set; }

        [InverseProperty(nameof(Article.ArticleGroup))]
        public List<Article>? Articles { get; set; }
    }
}

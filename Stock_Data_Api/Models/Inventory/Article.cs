using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Stock_Data_Api.Models.Inventory
{
    public class Article : ArticleCommon
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ArticleName { get; set; }

        [JsonIgnore]
        public int? ArticleGroupId { get; set; }
        [ForeignKey(nameof(ArticleGroupId))]
        [InverseProperty("Articles")]
        [JsonIgnore]
        public ArticleGroup? ArticleGroup { get; set; }

        public int? MarkId { get; set;}
        [ForeignKey(nameof(MarkId))]
        [DeleteBehavior(DeleteBehavior.SetNull)]
        public Mark? Mark { get; set; }
    }
}

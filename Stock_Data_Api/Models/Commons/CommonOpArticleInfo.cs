using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock_Data_Api.Models.Commons
{
    public class CommonOpArticleInfo
    {
        [Key]
        public int Id { get; set; }

        public decimal? PricePerUnit { get; set; }

        public int AccountId { get; set; }

        public string? Description { get; set; }

        public int? TaxId {get;set;}
        [ForeignKey(nameof(TaxId))]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Tax? Tax { get; set; }
    }
}

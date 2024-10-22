using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Stock_Data_Api.Models.Frequent_Entiities
{
    public class ChequeOfMode
    {
        [Key]
        public int Id { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Cheque? Cheque { get; set; } // Navigation property

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public AssociatedDocs? AssociatedDocs { get; set; }
    }

}

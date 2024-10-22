using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock_Data_Api.Models
{
    public class AssociatedDocs
    {
        [Key]
        public int Id { get; set; }

        public List<AssociatedDocsFile> AssociatedDocsFiles { get; set; }
    }
}

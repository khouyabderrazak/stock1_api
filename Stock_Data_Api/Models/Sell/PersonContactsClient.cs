using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Stock_Data_Api.Models.Sell
{
    public class PersonContactsClient
    {
        [Key]
        public int Id { get; set; }

        public int? PersonToContactId {get;set;}
        [ForeignKey(nameof(PersonToContactId))]
        [Required]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public PersonToContact PersonToContact { get; set; }

        public int? ClientId { get; set; }
        [ForeignKey(nameof(ClientId))]
        [InverseProperty("ClientContacts")]
        [JsonIgnore]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Client? Client { get; set; } 
       
    }
}

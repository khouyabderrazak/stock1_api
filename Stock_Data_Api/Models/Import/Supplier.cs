using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Commons;
using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models.Import
{
    public class Supplier : SupplierClient
    {
        public List<PersonContactsSupplier>? SupplierContacts {  get; set; }
    }

}

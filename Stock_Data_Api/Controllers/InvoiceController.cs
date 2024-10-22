using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Data;
using Stock_Data_Api.Models.Sell;
namespace Stock_Data_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly DataDbContext _db;
        public InvoiceController(DataDbContext db)
        {
            _db = db;
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> AddInvoice([FromBody] InvoiceSell invoice)
       { 
             await  this._db.InvoiceSells.AddAsync(invoice);
            _db.SaveChanges();
            return Ok(invoice);
       }

        [HttpGet]

        public async Task<IActionResult> getInvoices()
        {
            var invoices = await this._db.InvoiceSells
                .Include(p=>p.Client)
                .Include(p=>p.TabArticles)
                .ThenInclude(p=>p.articlesInfo)
                .ToListAsync();
            return Ok(invoices);
        }


        [HttpGet("signleInvoice/{id}")]
        public async Task<IActionResult> getInvoice(int id)
        {
            var invoice = await this._db.InvoiceSells
                .Include(p => p.Client)
                .Include(p=>p.Seller)
                .Include(p=>p.PaymentCondition)
                .Include(p => p.TabArticles)
                .ThenInclude(p => p.articlesInfo)
                .ThenInclude(p=>p.Tax)
                .Include(p => p.TabArticles)
                .ThenInclude(p => p.articlesInfo)
                .ThenInclude(p => p.Article)
                
                .FirstOrDefaultAsync(p=>p.Id==id);
            return Ok(invoice);
        }

    }
    
}

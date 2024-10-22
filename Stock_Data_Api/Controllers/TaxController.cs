using Microsoft.AspNetCore.Mvc;
using Stock_Data_Api.Data;
using Stock_Data_Api.Models;

namespace Stock_Data_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxController : ControllerBase
    {
        private readonly DataDbContext _db;
        public TaxController(DataDbContext db)
        {
            this._db = db;
        }

        [HttpGet]
        public IEnumerable<Tax> GetTaxes()
        {
            return _db.Taxes.ToList();
        }

        [HttpPost]
        public IActionResult AddTax(Tax tax)
        {
            _db.Taxes.Add(tax);
            _db.SaveChanges();
            return Ok(tax);
        }
    }
}

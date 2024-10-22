using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Stock_Data_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentConditionsController : ControllerBase
    {
        private readonly DataDbContext _db;
        public PaymentConditionsController(DataDbContext db)
        {
            this._db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetPaymentConditions()
        {
            return Ok(await _db.PaymentConditions.ToListAsync());
        }
    }
}

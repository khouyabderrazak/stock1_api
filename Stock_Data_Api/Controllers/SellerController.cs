using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Data;

namespace Stock_Data_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly DataDbContext _db;
        public SellerController(DataDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetSellers()
        {
            return Ok(await _db.Sellers.ToListAsync());
        }
    }
}

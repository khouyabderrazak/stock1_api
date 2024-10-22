using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Data;

namespace Stock_Data_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly DataDbContext _db;
        public SupplierController(DataDbContext db)
        {
            this._db = db;
        }

        [HttpGet]
        public async Task<IActionResult> getAllSuppliers()
        {
            return Ok(await _db.Suppliers.ToListAsync());
        }
    }
}

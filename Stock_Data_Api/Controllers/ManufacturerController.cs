using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Data;

namespace Stock_Data_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {

        private readonly DataDbContext _db;
        public ManufacturerController(DataDbContext db)
        {
            this._db = db;
        }

        [HttpGet]
        public async Task<IActionResult> getAllManufatures()
        {
            return Ok(await _db.Manufacturers.ToListAsync());
        }
    }
}

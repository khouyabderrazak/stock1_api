using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Data;

namespace Stock_Data_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarkController : ControllerBase
    {
        private readonly DataDbContext _db;
        public MarkController(DataDbContext db)
        {
            this._db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMarks()
        {
            return Ok(await _db.Marks.ToListAsync());
        }
    }
}

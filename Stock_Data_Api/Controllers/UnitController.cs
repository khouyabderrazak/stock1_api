using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Data;

namespace Stock_Data_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly DataDbContext _db;
        public UnitController(DataDbContext db)
        {
            this._db = db;
        }

        [HttpGet]
        public async Task<IActionResult> getAllUnites()
        {
            return  Ok(await _db.Units.ToListAsync());
        }
    }
}

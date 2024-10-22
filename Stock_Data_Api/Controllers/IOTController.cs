using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stock_Data_Api.Data;
using Stock_Data_Api.Models;
using System.Threading.Tasks;

namespace Stock_Data_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IOTController : ControllerBase
    {
        private readonly DataDbContext _db;
        public IOTController(DataDbContext db)
        {
            _db = db;
        }

        [HttpGet("{parametre1}/{parametre2}/{parametre3}")]
        public async Task<ActionResult> GetData(string? parametre1, string? parametre2, string? parametre3)
        {
           
            DataIOT dataIOT = new DataIOT
            {
                X1 = parametre1,
                X2 = parametre2,
                X3 = parametre3
            };

            _db.IOTtable.Add(dataIOT);
            await _db.SaveChangesAsync();

            return Ok(dataIOT);
        }
    }
}

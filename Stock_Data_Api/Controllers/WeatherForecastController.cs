using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Data;
using Stock_Data_Api.Models.Sell;

namespace Stock_Data_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public readonly DataDbContext dbContext;
        public WeatherForecastController(DataDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<PaymentSell> Get()
        {
            return dbContext.PaymentSells.Include(ab=>ab.AssociatedDocs).Include(ab=>ab.Client).ToList();
        }
    }
}

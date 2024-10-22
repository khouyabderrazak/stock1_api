using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Stock_Data_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangeFireController : ControllerBase
    {

        [HttpPost]
        [Route("[action]")]
        public IActionResult send()
        {
            var index = BackgroundJob.Enqueue(() => Console.WriteLine("hello abderrazzak"));
            return Ok("request hello sent");

        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult shedule()
        {
            var index = BackgroundJob.Schedule(() => Console.WriteLine("hello abderrazzak"),TimeSpan.FromSeconds(30));
            return Ok("request hello sent");

        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult reccuring()
        {
             RecurringJob.AddOrUpdate(() => Console.WriteLine("database update"), Cron.Minutely);
            return Ok("database updated");

        }

    }
}

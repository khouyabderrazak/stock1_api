using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Stock_Data_Api.Data;
using Stock_Data_Api.Models;
using Stock_Data_Api.Models.Commons;
using Stock_Data_Api.Models.Inventory;
using Stock_Data_Api.Models.Sell;

namespace Stock_Data_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly DataDbContext _db;
        public ClientController(DataDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult> GetClients() 
        {
            return Ok(await _db.Clients.Include(e=>e.ClientContacts).ToListAsync());
        }


        [HttpPost, DisableRequestSizeLimit]
        public async Task<ActionResult> AddClients()
        {
            var formCollection = await Request.ReadFormAsync();

            var clientJson = formCollection["client"][0];
            var client = JsonConvert.DeserializeObject<Client>(clientJson);

            List<AssociatedDocsFile> associatedDocsFiles = new List<AssociatedDocsFile>();
            AssociatedDocs associatedDocs = new AssociatedDocs();

            if (formCollection.Files.Count > 0)
            {
                for(int i = 0; i < formCollection.Files.Count; i++)
                {
                    var associatedDocsFile = new AssociatedDocsFile();
                    var file = formCollection.Files[i];
                    associatedDocsFile.FilePath = OutherFunctions.uploadile(file);
                    associatedDocsFile.Label = "hhh";
                    associatedDocsFiles.Add(
                       associatedDocsFile     
                    );
                }

                associatedDocs.AssociatedDocsFiles = associatedDocsFiles;

                client.AssociatedDocs = associatedDocs;

            }
            if (ModelState.IsValid)
            {
              await  _db.Clients.AddAsync(client);
              await   _db.SaveChangesAsync();
              return Ok(client);

            }
            return BadRequest();
        }
    }
}

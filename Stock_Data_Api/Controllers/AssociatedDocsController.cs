using Microsoft.AspNetCore.Mvc;
using Stock_Data_Api.Data;
using Stock_Data_Api.Models;
using System.Net.Http.Headers;

namespace Stock_Data_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociatedDocsController : ControllerBase
    {
        private readonly DataDbContext _context;

        public AssociatedDocsController(DataDbContext _context) 
        {
            this._context = _context;
        }

        [HttpPost, DisableRequestSizeLimit]
        public IActionResult UploadAssociatedDocs()
        {
            try
            {
                var files = Request.Form.Files;
                var folderName = Path.Combine("Resources", "Images");
                var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var AssociatedDocs = new AssociatedDocs() { AssociatedDocsFiles = new List<AssociatedDocsFile>()};
                foreach (var file in files)
                {
                    var pathToSave = Path.Combine(desktopPath, folderName);
                    if (!Directory.Exists(pathToSave))
                    {
                        Directory.CreateDirectory(pathToSave);
                    }
                    //if (file.Length > 0)
                    //{
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    var File = new AssociatedDocsFile() { FilePath = fullPath , Label = fileName};
                    AssociatedDocs.AssociatedDocsFiles.Add(File);
                    //}
                    //else
                    //{
                    //    return BadRequest("Some Files Are Not added !");
                    //}
                }
                _context.AssociatedDocs.Add(AssociatedDocs);
                _context.SaveChanges();
                return Ok(AssociatedDocs.Id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"internal server error:{ex}");
            }
        }
    }
}

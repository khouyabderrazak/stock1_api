using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using System.Net.Http.Headers;

namespace Stock_Data_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadFilesController : ControllerBase
    {


        [HttpPost,DisableRequestSizeLimit]
        public IActionResult Upload()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("Resources", "Images");
                var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var pathToSave = Path.Combine(desktopPath, folderName);
                if (!Directory.Exists(pathToSave))
                {
                    Directory.CreateDirectory(pathToSave);
                }
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using(var stream=new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);    
                    }
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, $"internal servr error matrab:{ex}");
            }
        }
        [HttpGet]
        public async Task<IActionResult> DownLoadFile(string fileName)
        {
            var folderName = Path.Combine("Resources", "Images");
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            var fullPath = Path.Combine(pathToSave, fileName);

            var provider = new FileExtensionContentTypeProvider();
            if (provider.TryGetContentType(fullPath, out var contenttype))
            {
                contenttype = "application/octet-stream";
            }
            var bytes = await System.IO.File.ReadAllBytesAsync(fullPath);
            return File(bytes, contenttype, Path.GetFileName(fullPath));

        }

        [HttpDelete("{name}")]
        public async Task<IActionResult> DeleteImage(string name)
        {
            try
            {
                Boolean x = OutherFunctions.DeleteImage(name);

                if (x)
                {
                    return Ok("Image est supprimer avec success");
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}



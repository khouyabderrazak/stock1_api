﻿using Azure.Core;
using System.IO;
using System.Net.Http.Headers;

namespace Stock_Data_Api.Controllers
{
    public class OutherFunctions
    {

        public static string uploadile(IFormFile file)
        {
            var folderName = Path.Combine("Resources", "Images");
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            if (file.Length > 0)
            {
                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                string fullPath = Path.Combine(pathToSave, DateTime.Now.ToString("yyyyMMddHHmmss") + fileName);

                var dbPath = DateTime.Now.ToString("yyyyMMddHHmmss") + fileName;
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                return dbPath;
            }
            else
            {
                return null;
            }
        }

        public static Boolean DeleteImage(string name)
        {
            var folderName = Path.Combine("Resources", "Images");
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

            var imagePath = Path.Combine(pathToSave, name);
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
                return true;
            }

            return false;
        }
    }
}


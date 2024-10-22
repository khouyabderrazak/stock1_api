using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Stock_Data_Api.Controllers;
using Stock_Data_Api.Data;
using Stock_Data_Api.Models.Inventory;

namespace Stock_Data_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupArticlesController : ControllerBase
    {

        private readonly DataDbContext _db;
        public GroupArticlesController(DataDbContext db)
        {
            this._db = db;
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> addGroupArticles(){

            var formCollection = await Request.ReadFormAsync();

            var articleJson = formCollection["groupArticles"][0];
            var articleGroupModel = JsonConvert.DeserializeObject<ArticleGroup>(articleJson);

            if (articleGroupModel.Articles != null && articleGroupModel.Articles.Count>0)
            {
                  foreach (var article in  articleGroupModel.Articles)
                  {
                    setStockDisponible(article);
                  }
            }

            string? ImagePath = null;

            if (formCollection.Files.Count > 0)
            {
                var file = formCollection.Files[0];
                ImagePath = OutherFunctions.uploadile(file);
            }
            articleGroupModel.ImagePath = ImagePath;


            await _db.ArticleGroups.AddAsync(articleGroupModel);

           await _db.SaveChangesAsync();

            return Ok(articleGroupModel);
        }


        [HttpGet]
        public async Task<IActionResult> getAllGroupsArticles()
        {
            return Ok(await _db.ArticleGroups.Include(p=>p.Articles).ThenInclude(a=>a.ArticleStockInf).ToListAsync());
        }


        [HttpGet("getGroupArticlesById/{id}")]
        public async Task<IActionResult> getAllGroupsArticles(int id)
        {
            var groupe = await _db.ArticleGroups.Include(p=>p.Articles)
                                           
                                           .ThenInclude(p=>p.ArticleStockInf)
                                           
                                           .Include(p => p.Articles)
                                           
                                           .ThenInclude(p => p.ImportInfo)
                                           
                                           .Include(p => p.Articles)
                                           
                                           .ThenInclude(p => p.SellInfo)

                                           .FirstOrDefaultAsync(g=>g.ID==id);
            if (groupe==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(groupe);
            }
        }

        [NonAction]
        public void setStockDisponible(Article articleModel)
        {
            if (articleModel.ArticleStockInf != null)
            {
                if (articleModel.ArticleStockInf.StockOuverture != null)
                {
                    articleModel.ArticleStockInf.Stockdisponible = articleModel.ArticleStockInf.StockOuverture;
                }
            }
        }

      

    }

}

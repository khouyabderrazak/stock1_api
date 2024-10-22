using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Stock_Data_Api.Data;
using Stock_Data_Api.Models.Inventory;

namespace Stock_Data_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly DataDbContext _db;
        public ArticlesController(DataDbContext db)
        {
            this._db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllArticles()
        {
            return Ok(await _db.Articles.Include(p=>p.ArticleStockInf).ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticleById(int id)
        {
            var article = await _db.Articles
                .Include(p => p.SellInfo)
                .Include(p => p.ImportInfo)
                .Include(p => p.ArticleStockInf)
                .Include(p => p.Unit)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (article == null)
            {
                return NotFound();
            }

            return Ok(article);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticle(int id)
        {
            var article = await _db.Articles

                 .FirstOrDefaultAsync(p => p.Id == id);

            if (article == null)
            {
                return NotFound();
            }
            _db.Articles.Remove(article);
            _db.SaveChanges();
            return Ok(article);
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> AddArticle()
        {

            var formCollection = await Request.ReadFormAsync();

            var articleJson = formCollection["article"][0];
            var articleModel = JsonConvert.DeserializeObject<Article>(articleJson);

            string? ImagePath = null;
            setStockDisponible(articleModel);

            if (formCollection.Files.Count > 0)
            {
                var file = formCollection.Files[0];
                ImagePath = OutherFunctions.uploadile(file);
            }
            articleModel.ImagePath = ImagePath;

            await _db.Articles.AddAsync(articleModel);

            await _db.SaveChangesAsync();

            return Ok(articleModel);
        }


        [HttpDelete("deleteImage/{id}")]
        public async Task<IActionResult> DeleteImage(int id)
        {
            var article = await _db.Articles.FindAsync(id);
            if (article != null)
            {
                var name = article.ImagePath;
                try
                {
                    Boolean x = OutherFunctions.DeleteImage(name);

                    if (x)
                    {
                        article.ImagePath = null;
                        _db.Articles.Update(article);
                        _db.SaveChanges();
                        return Ok();
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
            else
            {
                return NotFound();
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateArticle(Article article)
        {
            _db.Articles.Update(article);
            _db.SaveChanges();
            return Ok(article);
        }


        [HttpPost("AddImage/{id}")]
        public async Task<IActionResult> AddImage(int id)
        {
            var article = await _db.Articles.FindAsync(id);
            if (article != null)
            {
                if (article.ImagePath != null)
                {
                    OutherFunctions.DeleteImage(article.ImagePath);
                }
                try
                {
                    var formCollection = await Request.ReadFormAsync();
                    string? ImagePath = null;
                    if (formCollection.Files.Count > 0)
                    {
                        var file = formCollection.Files[0];
                        ImagePath = OutherFunctions.uploadile(file);
                    }
                    article.ImagePath = ImagePath;
                    _db.Articles.Update(article);
                    _db.SaveChanges();

                    return Ok(article);

                }
                catch (Exception ex)
                {

                    return StatusCode(500, $"An error occurred: {ex.Message}");
                }
            }
            else
            {
                return NotFound();
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

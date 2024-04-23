using Store.Core.Dtos.Request;
using Store.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Store.Api.Controllers
{
    [Route("api/Article")]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<int> CreateArticle([FromBody] ArticleRequestDto article)
        {
            int id = _articleService.CreateArticle(article);
            return StatusCode(StatusCodes.Status201Created, id);
        }
    }
}

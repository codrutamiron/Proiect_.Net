using Store.Core.Dtos.Request;
using Store.Core.Mapping;
using Store.Database.Repositories;

namespace Store.Core.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public int CreateArticle(ArticleRequestDto article)
        {
            int id = _articleRepository.CreateArticle(article.ToArticle());
            return id;
        }
    }
}

using Store.Core.Dtos.Request;

namespace Store.Core.Services
{
    public interface IArticleService
    {
        int CreateArticle(ArticleRequestDto article);
    }
}

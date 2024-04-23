using Store.Database.Entities;

namespace Store.Database.Repositories
{
    public interface IArticleRepository
    {
        int CreateArticle(Article article);
    }
}

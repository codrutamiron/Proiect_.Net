using Store.Database.Context;
using Store.Database.Entities;

namespace Store.Database.Repositories
{
    public class ArticleRepository : BaseRepository, IArticleRepository
    {
        public ArticleRepository(StoreDbContext context) : base(context)
        {
        }

        public int CreateArticle(Article article)
        {
            var brand = _storeDbContext.Brands.Find(article.BrandId);

            if(brand == null)
            {
                // Create middleware to handle exceptions
                throw new Exception("Brand not found");
            }

            _storeDbContext.Articles.Add(article);
            _storeDbContext.SaveChanges();

            return article.Id;
        }
    }
}

using Store.Core.Dtos.Request;
using Store.Core.Dtos.Response;
using Store.Database.Entities;

namespace Store.Core.Mapping
{
    public static class ArticleMappingExtensions
    {
        public static ArticleResponseDto ToArticleResponseDto(this Article article)
        {
            var result = new ArticleResponseDto
            {
                Id = article.Id,
                Name = article.Title,
            };

            return result;
        }

        public static Article ToArticle(this ArticleRequestDto article)
        {
            return new Article
            {
                Title = article.Title,
                BrandId = article.BrandId
            };
        }
    }
}

using Store.Core.Dtos.Request;
using Store.Core.Dtos.Response;
using Store.Database.Entities;

namespace Store.Core.Mapping
{
    public static class BrandMappingExtensions
    {
        public static BrandResponseDto ToBrandResponseDto(this Brand brand)
        {
            var result = new BrandResponseDto();

            result.Id = brand.Id;
            result.FullName = brand.Name;

            List<ArticleResponseDto> articlesDto = new List<ArticleResponseDto>();

            foreach (var article in brand.Article)
            {
                articlesDto.Add(article.ToArticleResponseDto());
            }

            result.Articles = articlesDto;

            return result;
        }

        public static Brand ToBrand(this BrandRequestDto brand)
        {
            return new Brand
            {
                Name = brand.Name
            };
        }
    }
}

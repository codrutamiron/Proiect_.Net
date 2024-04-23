namespace Store.Core.Dtos.Response
{
    public class BrandResponseDto
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public List<ArticleResponseDto> Articles { get; set; }
    }
}

namespace Store.Database.Entities
{
    public class Article
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }
    }
}

namespace Store.Database.Entities
{
    public class Brand
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<Article> Article { get; set; }
    }
}

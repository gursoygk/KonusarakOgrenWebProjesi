namespace KO.Core.Models
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public int BrandId { get; set; }
        public Brand? Brand { get; set; }

        public ICollection<Comment>? Comments { get; set; }
    }
}

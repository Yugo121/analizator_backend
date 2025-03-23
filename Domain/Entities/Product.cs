namespace Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Sku { get; set; }
        public string Ean { get; set; }
        public decimal NetPrice { get; set; }
        public decimal GrossPrice { get; set; }
        public string? ModelName { get; set; }
        public bool IsStarred { get; set; }
        public List<ProductTag> Tags { get; set; } = new();
        public List<OrderProduct> OrderProducts { get; set; } = new();
    }
}

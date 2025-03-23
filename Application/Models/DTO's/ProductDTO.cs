using Application.Models.DTO_s;

namespace Application.Models.DTO_s
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Sku { get; set; }
        public string Ean { get; set; }
        public decimal NetPrice { get; set; }
        public decimal GrossPrice { get; set; }
        public string? ModelName { get; set; }
        public bool IsStarred { get; set; }
        public List<ProductTagDTO> Tags { get; set; } = new();
        public List<Guid> OrdersIds { get; set; } = new();

    }
}

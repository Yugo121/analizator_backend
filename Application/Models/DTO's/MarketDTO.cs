using Domain.Enums;

namespace Application.Models.DTO_s
{
    public class MarketDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public Currency Currency { get; set; }
        public List<OrderDTO> Orders { get; set; } = new();

    }
}

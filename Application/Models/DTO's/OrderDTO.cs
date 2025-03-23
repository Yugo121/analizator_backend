using Application.Models.DTO_s;
using Domain.Enums;

namespace Application.Models.DTO_s
{
    public class OrderDTO
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Currency Currency { get; set; }
        public decimal TotalPrice { get; set; }
        public Guid ClientId { get; set; }
        public ClientDTO Client { get; set; }
        public Guid MarketId { get; set; }
        public MarketDTO Market { get; set; }
        public List<OrderTagDTO> Tags { get; set; } = new();
        public List<Guid> ProductsIds { get; set; } = new();

    }
}

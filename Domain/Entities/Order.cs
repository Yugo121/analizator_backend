using Domain.Enums;

namespace Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Currency Currency { get; set; }
        public decimal TotalPrice { get; set; }
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
        public Guid MarketId { get; set; }
        public Market Market { get; set; }
        public List<OrderTag> Tags { get; set; } = new();
        public List<OrderProduct> OrderProducts { get; set; } = new();

    }
}

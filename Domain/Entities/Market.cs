using Domain.Enums;

namespace Domain.Entities
{
    public class Market
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public Currency Currency { get; set; }
        public List<Order> Orders { get; set; } = new();
    }
}

using Domain.Core;

namespace Domain.Entities
{
    public class OrderTag : BaseTag
    {
        public List<Order> Orders { get; set; }

    }
}

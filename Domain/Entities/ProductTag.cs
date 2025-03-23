using Domain.Core;

namespace Domain.Entities
{
    public class ProductTag : BaseTag
    {
        public List<Product> Products { get; set; }
    }
}

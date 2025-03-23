using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Client> Clients { get; set; }
        DbSet<Market> Markets { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

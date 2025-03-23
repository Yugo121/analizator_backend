using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Interfaces
{
    public interface IApplicationServiceRegistration
    {
        public void AddApplicationServices(IServiceCollection services, IConfiguration configuration);
    }
}

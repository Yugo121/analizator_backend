using Application.Interfaces;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Services
{
    public class ApplicationServiceRegistration : IApplicationServiceRegistration
    {
        public void AddApplicationServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(ApplicationServiceRegistration).Assembly);
            services.AddAutoMapper(typeof(MappingService).Assembly);
        }
    }
}

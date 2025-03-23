using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IInterfaceServiceRegistration
    {
        void AddInfrastructure(IServiceCollection services, IConfiguration configuration);
    }
}

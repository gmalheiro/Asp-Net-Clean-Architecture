using GloboTicket.TicketManagement.Applicati.Contracts.Persistence;
using GloboTicket.TicketManagement.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace GloboTicket.TicketManagement.Persistence
{
    public class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(IServiceCollection services
            , IConfiguration configuration)
        {
            services.AddDbContext<GloboTicketDbContext>(options =>
            options.UseSqlServer(configuration
                                 .GetConnectionString
                                 ("GloboTicketTicketManagementConnectionString")
                                 ));
            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<IEventRepository,EventRepository>();
            services.AddScoped<IOrderRepository,OrderRepository>();

            return services;

        }
    }
}

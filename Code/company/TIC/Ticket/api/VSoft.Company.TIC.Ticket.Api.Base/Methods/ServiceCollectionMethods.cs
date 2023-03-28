using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.TIC.Ticket.Business.Provider.Services;
using VSoft.Company.TIC.Ticket.Business.Services;
using VSoft.Company.TIC.Ticket.Data.Db.Contexts;
using VSoft.Company.TIC.Ticket.Repository.Services;
using VSoft.Company.TIC.Ticket.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.TIC.Ticket.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterTicketServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<TicketDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<ITicketRepository, EfcTicketRepository>();
            services.AddScoped<ITicketMgmtBus, TicketMgmtBus>();
           
        }
    }
}

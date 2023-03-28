using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.ORD.Order.Business.Provider.Services;
using VSoft.Company.ORD.Order.Business.Services;
using VSoft.Company.ORD.Order.Data.Db.Contexts;
using VSoft.Company.ORD.Order.Repository.Services;
using VSoft.Company.ORD.Order.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.ORD.Order.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterOrderServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<OrderDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IOrderRepository, EfcOrderRepository>();
            services.AddScoped<IOrderMgmtBus, OrderMgmtBus>();
           
        }
    }
}

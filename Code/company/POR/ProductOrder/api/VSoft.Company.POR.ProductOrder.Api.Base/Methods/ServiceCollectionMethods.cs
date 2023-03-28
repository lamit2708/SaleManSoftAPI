using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.POR.ProductOrder.Business.Provider.Services;
using VSoft.Company.POR.ProductOrder.Business.Services;
using VSoft.Company.POR.ProductOrder.Data.Db.Contexts;
using VSoft.Company.POR.ProductOrder.Repository.Services;
using VSoft.Company.POR.ProductOrder.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.POR.ProductOrder.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterProductOrderServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<ProductOrderDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IProductOrderRepository, EfcProductOrderRepository>();
            services.AddScoped<IProductOrderMgmtBus, ProductOrderMgmtBus>();
           
        }
    }
}

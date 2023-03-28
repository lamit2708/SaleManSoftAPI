using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.PRO.Product.Business.Provider.Services;
using VSoft.Company.PRO.Product.Business.Services;
using VSoft.Company.PRO.Product.Data.Db.Contexts;
using VSoft.Company.PRO.Product.Repository.Services;
using VSoft.Company.PRO.Product.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.PRO.Product.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterProductServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<ProductDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IProductRepository, EfcProductRepository>();
            services.AddScoped<IProductMgmtBus, ProductMgmtBus>();
           
        }
    }
}

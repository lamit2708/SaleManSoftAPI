using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.PRC.ProductCategory.Business.Provider.Services;
using VSoft.Company.PRC.ProductCategory.Business.Services;
using VSoft.Company.PRC.ProductCategory.Data.Db.Contexts;
using VSoft.Company.PRC.ProductCategory.Repository.Services;
using VSoft.Company.PRC.ProductCategory.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.PRC.ProductCategory.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterProductCategoryServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<ProductCategoryDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IProductCategoryRepository, EfcProductCategoryRepository>();
            services.AddScoped<IProductCategoryMgmtBus, ProductCategoryMgmtBus>();

        }
    }
}

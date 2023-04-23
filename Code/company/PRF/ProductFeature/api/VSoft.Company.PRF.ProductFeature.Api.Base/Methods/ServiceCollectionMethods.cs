using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.PRF.ProductFeature.Business.Provider.Services;
using VSoft.Company.PRF.ProductFeature.Business.Services;
using VSoft.Company.PRF.ProductFeature.Data.Db.Contexts;
using VSoft.Company.PRF.ProductFeature.Repository.Services;
using VSoft.Company.PRF.ProductFeature.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.PRF.ProductFeature.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterProductFeatureServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<ProductFeatureDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IProductFeatureRepository, EfcProductFeatureRepository>();
            services.AddScoped<IProductFeatureMgmtBus, ProductFeatureMgmtBus>();

        }
    }
}

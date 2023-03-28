using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.DQU.DealQuotation.Business.Provider.Services;
using VSoft.Company.DQU.DealQuotation.Business.Services;
using VSoft.Company.DQU.DealQuotation.Data.Db.Contexts;
using VSoft.Company.DQU.DealQuotation.Repository.Services;
using VSoft.Company.DQU.DealQuotation.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.DQU.DealQuotation.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterDealQuotationServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<DealQuotationDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IDealQuotationRepository, EfcDealQuotationRepository>();
            services.AddScoped<IDealQuotationMgmtBus, DealQuotationMgmtBus>();
           
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.VDT.VDealTag.Business.Provider.Services;
using VSoft.Company.VDT.VDealTag.Business.Services;
using VSoft.Company.VDT.VDealTag.Data.Db.Contexts;
using VSoft.Company.VDT.VDealTag.Repository.Services;
using VSoft.Company.VDT.VDealTag.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.VDT.VDealTag.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterVDealTagServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<VDealTagDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IVDealTagRepository, EfcVDealTagRepository>();
            services.AddScoped<IVDealTagMgmtBus, VDealTagMgmtBus>();
           
        }
    }
}

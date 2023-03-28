using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.TEA.Team.Business.Provider.Services;
using VSoft.Company.TEA.Team.Business.Services;
using VSoft.Company.TEA.Team.Data.Db.Contexts;
using VSoft.Company.TEA.Team.Repository.Services;
using VSoft.Company.TEA.Team.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.TEA.Team.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterTeamServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<TeamDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<ITeamRepository, EfcTeamRepository>();
            services.AddScoped<ITeamMgmtBus, TeamMgmtBus>();
           
        }
    }
}

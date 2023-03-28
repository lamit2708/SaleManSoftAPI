using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.ROL.Role.Business.Provider.Services;
using VSoft.Company.ROL.Role.Business.Services;
using VSoft.Company.ROL.Role.Data.Db.Contexts;
using VSoft.Company.ROL.Role.Repository.Services;
using VSoft.Company.ROL.Role.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.ROL.Role.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterRoleServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<RoleDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IRoleRepository, EfcRoleRepository>();
            services.AddScoped<IRoleMgmtBus, RoleMgmtBus>();
           
        }
    }
}

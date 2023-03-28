using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.URO.UserRole.Business.Provider.Services;
using VSoft.Company.URO.UserRole.Business.Services;
using VSoft.Company.URO.UserRole.Data.Db.Contexts;
using VSoft.Company.URO.UserRole.Repository.Services;
using VSoft.Company.URO.UserRole.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.URO.UserRole.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterUserRoleServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<UserRoleDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IUserRoleRepository, EfcUserRoleRepository>();
            services.AddScoped<IUserRoleMgmtBus, UserRoleMgmtBus>();
           
        }
    }
}

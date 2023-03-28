using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.USR.User.Business.Provider.Services;
using VSoft.Company.USR.User.Business.Services;
using VSoft.Company.USR.User.Data.Db.Contexts;
using VSoft.Company.USR.User.Repository.Services;
using VSoft.Company.USR.User.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.USR.User.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterUserServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<UserDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IUserRepository, EfcUserRepository>();
            services.AddScoped<IUserMgmtBus, UserMgmtBus>();
           
        }
    }
}

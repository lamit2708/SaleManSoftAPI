using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.QUE.Question.Business.Provider.Services;
using VSoft.Company.QUE.Question.Business.Services;
using VSoft.Company.QUE.Question.Data.Db.Contexts;
using VSoft.Company.QUE.Question.Repository.Services;
using VSoft.Company.QUE.Question.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.QUE.Question.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterQuestionServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<QuestionDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IQuestionRepository, EfcQuestionRepository>();
            services.AddScoped<IQuestionMgmtBus, QuestionMgmtBus>();
           
        }
    }
}

using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.ANW.Anwser.Api.Base.Methods;

namespace VSoft.Company.ANW.Anwser.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterAnwserApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterAnwserServices(configuration);
            });
        }
    }
}

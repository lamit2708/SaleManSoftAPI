using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.USR.User.Api.Base.Methods;

namespace VSoft.Company.USR.User.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterUserApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterUserServices(configuration);
            });
        }
    }
}

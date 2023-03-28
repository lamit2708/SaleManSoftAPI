using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.ACT.Activity.Api.Base.Methods;

namespace VSoft.Company.ACT.Activity.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterActivityApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterActivityServices(configuration);
            });
        }
    }
}

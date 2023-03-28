using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.PRI.Priority.Api.Base.Methods;

namespace VSoft.Company.PRI.Priority.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterPriorityApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterPriorityServices(configuration);
            });
        }
    }
}

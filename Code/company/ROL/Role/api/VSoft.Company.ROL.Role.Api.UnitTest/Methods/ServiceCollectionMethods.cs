using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.ROL.Role.Api.Base.Methods;

namespace VSoft.Company.ROL.Role.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterRoleApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterRoleServices(configuration);
            });
        }
    }
}

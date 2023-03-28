using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.URO.UserRole.Api.Base.Methods;

namespace VSoft.Company.URO.UserRole.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterUserRoleApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterUserRoleServices(configuration);
            });
        }
    }
}

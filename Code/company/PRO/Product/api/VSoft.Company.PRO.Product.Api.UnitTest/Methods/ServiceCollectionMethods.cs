using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.PRO.Product.Api.Base.Methods;

namespace VSoft.Company.PRO.Product.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterProductApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterProductServices(configuration);
            });
        }
    }
}

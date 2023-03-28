using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.POR.ProductOrder.Api.Base.Methods;

namespace VSoft.Company.POR.ProductOrder.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterProductOrderApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterProductOrderServices(configuration);
            });
        }
    }
}

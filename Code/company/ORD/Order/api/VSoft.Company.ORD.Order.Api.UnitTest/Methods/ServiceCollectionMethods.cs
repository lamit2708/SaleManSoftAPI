using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.ORD.Order.Api.Base.Methods;

namespace VSoft.Company.ORD.Order.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterOrderApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterOrderServices(configuration);
            });
        }
    }
}

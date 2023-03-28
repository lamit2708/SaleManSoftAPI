using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.DEA.Deal.Api.Base.Methods;

namespace VSoft.Company.DEA.Deal.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterDealApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterDealServices(configuration);
            });
        }
    }
}

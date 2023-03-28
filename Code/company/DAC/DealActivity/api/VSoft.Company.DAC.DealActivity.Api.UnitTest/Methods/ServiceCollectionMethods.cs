using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.DAC.DealActivity.Api.Base.Methods;

namespace VSoft.Company.DAC.DealActivity.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterDealActivityApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterDealActivityServices(configuration);
            });
        }
    }
}

using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.DST.DealStep.Api.Base.Methods;

namespace VSoft.Company.DST.DealStep.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterDealStepApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterDealStepServices(configuration);
            });
        }
    }
}

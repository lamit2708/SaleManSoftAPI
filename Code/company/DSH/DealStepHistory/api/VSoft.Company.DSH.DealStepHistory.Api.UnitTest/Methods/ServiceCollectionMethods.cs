using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.DSH.DealStepHistory.Api.Base.Methods;

namespace VSoft.Company.DSH.DealStepHistory.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterDealStepHistoryApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterDealStepHistoryServices(configuration);
            });
        }
    }
}

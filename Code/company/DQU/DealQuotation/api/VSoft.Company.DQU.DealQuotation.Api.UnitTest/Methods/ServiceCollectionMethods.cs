using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.DQU.DealQuotation.Api.Base.Methods;

namespace VSoft.Company.DQU.DealQuotation.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterDealQuotationApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterDealQuotationServices(configuration);
            });
        }
    }
}

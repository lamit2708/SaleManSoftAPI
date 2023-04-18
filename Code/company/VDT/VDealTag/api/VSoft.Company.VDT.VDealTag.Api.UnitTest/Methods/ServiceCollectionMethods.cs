using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.VDT.VDealTag.Api.Base.Methods;

namespace VSoft.Company.VDT.VDealTag.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterVDealTagApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterVDealTagServices(configuration);
            });
        }
    }
}

using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.PRF.ProductFeature.Api.Base.Methods;

namespace VSoft.Company.PRF.ProductFeature.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterProductFeatureApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterProductFeatureServices(configuration);
            });
        }
    }
}

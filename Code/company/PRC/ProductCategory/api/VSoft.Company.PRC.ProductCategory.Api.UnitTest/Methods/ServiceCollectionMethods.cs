using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.PRC.ProductCategory.Api.Base.Methods;

namespace VSoft.Company.PRC.ProductCategory.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterProductCategoryApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterProductCategoryServices(configuration);
            });
        }
    }
}

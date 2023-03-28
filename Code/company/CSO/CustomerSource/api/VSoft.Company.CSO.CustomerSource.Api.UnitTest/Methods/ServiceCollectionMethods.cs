using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.CSO.CustomerSource.Api.Base.Methods;

namespace VSoft.Company.CSO.CustomerSource.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterCustomerSourceApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterCustomerSourceServices(configuration);
            });
        }
    }
}

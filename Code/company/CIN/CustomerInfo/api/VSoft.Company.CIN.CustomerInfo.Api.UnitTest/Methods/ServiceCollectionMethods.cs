using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.CIN.CustomerInfo.Api.Base.Methods;

namespace VSoft.Company.CIN.CustomerInfo.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterCustomerInfoApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterCustomerInfoServices(configuration);
            });
        }
    }
}

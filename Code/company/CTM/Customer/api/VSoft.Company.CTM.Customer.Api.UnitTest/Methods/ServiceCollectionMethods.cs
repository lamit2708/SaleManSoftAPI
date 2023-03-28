using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.CTM.Customer.Api.Base.Methods;

namespace VSoft.Company.CTM.Customer.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterCustomerApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterCustomerServices(configuration);
            });
        }
    }
}

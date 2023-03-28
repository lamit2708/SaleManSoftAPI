using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.UCU.UserCustomer.Api.Base.Methods;

namespace VSoft.Company.UCU.UserCustomer.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterUserCustomerApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterUserCustomerServices(configuration);
            });
        }
    }
}

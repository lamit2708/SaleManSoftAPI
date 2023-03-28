using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.TIC.Ticket.Api.Base.Methods;

namespace VSoft.Company.TIC.Ticket.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterTicketApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterTicketServices(configuration);
            });
        }
    }
}

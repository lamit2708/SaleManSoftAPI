using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.TEA.Team.Api.Base.Methods;

namespace VSoft.Company.TEA.Team.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterTeamApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterTeamServices(configuration);
            });
        }
    }
}

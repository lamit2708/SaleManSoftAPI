using Microsoft.AspNetCore.Builder;
using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.QUE.Question.Api.Base.Methods;

namespace VSoft.Company.QUE.Question.Api.UnitTest.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterQuestionApi(this WebApplicationBuilder builder)
        {
            builder.RegisterTestApi((services, configuration) =>
            {
                services.RegisterQuestionServices(configuration);
            });
        }
    }
}

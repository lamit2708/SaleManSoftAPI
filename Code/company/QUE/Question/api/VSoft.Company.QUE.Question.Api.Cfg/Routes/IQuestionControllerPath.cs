using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.QUE.Question.Api.Cfg.Routes
{
    public interface IQuestionControllerPath: IApiControllerPath
    {
        string? Question { get; set; }
    }
}

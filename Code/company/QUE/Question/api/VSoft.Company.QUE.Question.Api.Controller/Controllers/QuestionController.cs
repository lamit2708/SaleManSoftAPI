using Microsoft.AspNetCore.Mvc;
using VSoft.Company.QUE.Question.Business.Services;
using VSoft.Company.QUE.Question.Api.Controller.Base.Controllers;
using VSoft.Company.QUE.Question.Api.Cfg.Routes;

namespace VSoft.Company.QUE.Question.Api.Controller.Controllers;

[Route($"{nameof(IQuestionControllerPath.Api)}/{nameof(IQuestionControllerPath.Question)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class QuestionController : QuestionBaseController
{
    public QuestionController(IQuestionMgmtBus bus) : base(bus)
    {
       
    }
}

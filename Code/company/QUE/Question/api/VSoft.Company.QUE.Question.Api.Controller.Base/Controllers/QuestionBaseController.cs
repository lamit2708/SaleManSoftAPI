using Microsoft.AspNetCore.Mvc;
using VSoft.Company.QUE.Question.Business.Services;
using VSoft.Company.QUE.Question.Business.Dto.Request;
using VSoft.Company.QUE.Question.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.QUE.Question.Api.Controller.Base.Controllers;

public abstract class QuestionBaseController : ControllerBase
{
    protected IQuestionMgmtBus Bus { get; private set; }

    public QuestionBaseController(IQuestionMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(IQuestionActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByLong dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IQuestionActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByLongs dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IQuestionActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] QuestionInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IQuestionActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] QuestionInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IQuestionActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] QuestionSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IQuestionActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] QuestionUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IQuestionActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] QuestionUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IQuestionActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] QuestionDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IQuestionActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] QuestionDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

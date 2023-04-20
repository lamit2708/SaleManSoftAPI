using Microsoft.AspNetCore.Mvc;
using VSoft.Company.CTM.Customer.Business.Services;
using VSoft.Company.CTM.Customer.Business.Dto.Request;
using VSoft.Company.CTM.Customer.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.CTM.Customer.Api.Controller.Base.Controllers;

public abstract class CustomerBaseController : ControllerBase
{
    protected ICustomerMgmtBus Bus { get; private set; }

    public CustomerBaseController(ICustomerMgmtBus bus)
    {
        Bus = bus;
    }
	[HttpGet(nameof(ICustomerActionName.GetAll))]
	public async Task<IActionResult> FindAllAsync()
	{
		var res = await Bus.GetAll();
		return Ok(res);
	}

	[HttpGet(nameof(ICustomerActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByLong dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(ICustomerActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByLongs dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(ICustomerActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] CustomerInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(ICustomerActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] CustomerInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(ICustomerActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] CustomerSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(ICustomerActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] CustomerUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(ICustomerActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] CustomerUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(ICustomerActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] CustomerDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(ICustomerActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] CustomerDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpGet(nameof(ICustomerActionName.FindTable))]
    public async Task<IActionResult> FindTableByKeySearch([FromQuery] CustomerTableKeySearchDtoRequest dtosRequest)
    {
        var res = await Bus.GetTableByKeySearch(dtosRequest);
        return Ok(res);
    }
}

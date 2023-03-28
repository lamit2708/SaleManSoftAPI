using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.TIC.Ticket.Business.Dto.Request;
using VSoft.Company.TIC.Ticket.Business.Dto.Response;

namespace VSoft.Company.TIC.Ticket.Client.Services;

public interface ITicketClient: IApiDtoClientJSon<ITicketClient>
{  

    Task<TicketFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<TicketFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<TicketInsertDtoResponse> CreateAsync(TicketInsertDtoRequest request);

    Task<TicketInsertRangeDtoResponse> CreateRangeAsync(TicketInsertRangeDtoRequest request);

    Task<TicketUpdateDtoResponse> UpdateAsync(TicketUpdateDtoRequest request);

    Task<TicketUpdateRangeDtoResponse> UpdateRangeAsync(TicketUpdateRangeDtoRequest request);

    Task<TicketDeleteDtoResponse> DeleteAsync(TicketDeleteDtoRequest request);

    Task<TicketDeleteRangeDtoResponse> DeleteRangeAsync(TicketDeleteRangeDtoRequest request);

    Task<TicketSaveRangeDtoResponse> SaveRangeAsync(TicketSaveRangeDtoRequest request);
   
}
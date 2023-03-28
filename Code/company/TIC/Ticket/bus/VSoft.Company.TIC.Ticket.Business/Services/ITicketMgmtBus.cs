using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.TIC.Ticket.Business.Dto.Request;
using VSoft.Company.TIC.Ticket.Business.Dto.Response;

namespace VSoft.Company.TIC.Ticket.Business.Services;

public interface ITicketMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByInt request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByInt request);

    TicketFindDtoResponse Find(MDtoRequestFindByInt request);

    Task<TicketFindDtoResponse> FindAsync(MDtoRequestFindByInt request);

    TicketFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request);

    Task<TicketFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request);

    TicketInsertDtoResponse Create(TicketInsertDtoRequest request);

    Task<TicketInsertDtoResponse> CreateAsync(TicketInsertDtoRequest request);

    TicketInsertRangeDtoResponse CreateRange(TicketInsertRangeDtoRequest request);

    Task<TicketInsertRangeDtoResponse> CreateRangeAsync(TicketInsertRangeDtoRequest request);

    TicketUpdateDtoResponse Update(TicketUpdateDtoRequest request);

    Task<TicketUpdateDtoResponse> UpdateAsync(TicketUpdateDtoRequest request);

    TicketUpdateRangeDtoResponse UpdateRange(TicketUpdateRangeDtoRequest request);

    Task<TicketUpdateRangeDtoResponse> UpdateRangeAsync(TicketUpdateRangeDtoRequest request);

    TicketDeleteDtoResponse Delete(TicketDeleteDtoRequest request);

    Task<TicketDeleteDtoResponse> DeleteAsync(TicketDeleteDtoRequest request);

    TicketDeleteRangeDtoResponse DeleteRange(TicketDeleteRangeDtoRequest request);

    Task<TicketDeleteRangeDtoResponse> DeleteRangeAsync(TicketDeleteRangeDtoRequest request);

    Task<TicketSaveRangeDtoResponse> SaveRangeAsync(TicketSaveRangeDtoRequest request);

    Task<TicketSaveRangeDtoResponse> SaveRangeTransactionAsync(TicketSaveRangeDtoRequest request);
}

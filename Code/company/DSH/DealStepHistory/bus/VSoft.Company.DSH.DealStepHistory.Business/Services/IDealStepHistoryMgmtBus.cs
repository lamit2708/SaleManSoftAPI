using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.DSH.DealStepHistory.Business.Dto.Request;
using VSoft.Company.DSH.DealStepHistory.Business.Dto.Response;

namespace VSoft.Company.DSH.DealStepHistory.Business.Services;

public interface IDealStepHistoryMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByLong request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByLong request);

    DealStepHistoryFindDtoResponse Find(MDtoRequestFindByLong request);

    Task<DealStepHistoryFindDtoResponse> FindAsync(MDtoRequestFindByLong request);

    DealStepHistoryFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request);

    Task<DealStepHistoryFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request);

    DealStepHistoryInsertDtoResponse Create(DealStepHistoryInsertDtoRequest request);

    Task<DealStepHistoryInsertDtoResponse> CreateAsync(DealStepHistoryInsertDtoRequest request);

    DealStepHistoryInsertRangeDtoResponse CreateRange(DealStepHistoryInsertRangeDtoRequest request);

    Task<DealStepHistoryInsertRangeDtoResponse> CreateRangeAsync(DealStepHistoryInsertRangeDtoRequest request);

    DealStepHistoryUpdateDtoResponse Update(DealStepHistoryUpdateDtoRequest request);

    Task<DealStepHistoryUpdateDtoResponse> UpdateAsync(DealStepHistoryUpdateDtoRequest request);

    DealStepHistoryUpdateRangeDtoResponse UpdateRange(DealStepHistoryUpdateRangeDtoRequest request);

    Task<DealStepHistoryUpdateRangeDtoResponse> UpdateRangeAsync(DealStepHistoryUpdateRangeDtoRequest request);

    DealStepHistoryDeleteDtoResponse Delete(DealStepHistoryDeleteDtoRequest request);

    Task<DealStepHistoryDeleteDtoResponse> DeleteAsync(DealStepHistoryDeleteDtoRequest request);

    DealStepHistoryDeleteRangeDtoResponse DeleteRange(DealStepHistoryDeleteRangeDtoRequest request);

    Task<DealStepHistoryDeleteRangeDtoResponse> DeleteRangeAsync(DealStepHistoryDeleteRangeDtoRequest request);

    Task<DealStepHistorySaveRangeDtoResponse> SaveRangeAsync(DealStepHistorySaveRangeDtoRequest request);

    Task<DealStepHistorySaveRangeDtoResponse> SaveRangeTransactionAsync(DealStepHistorySaveRangeDtoRequest request);
}

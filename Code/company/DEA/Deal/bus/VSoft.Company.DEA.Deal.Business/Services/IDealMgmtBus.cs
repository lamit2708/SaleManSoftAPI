using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.DEA.Deal.Business.Dto.Request;
using VSoft.Company.DEA.Deal.Business.Dto.Response;

namespace VSoft.Company.DEA.Deal.Business.Services;

public interface IDealMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByLong request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByLong request);

    DealFindDtoResponse Find(MDtoRequestFindByLong request);

    Task<DealFindDtoResponse> FindAsync(MDtoRequestFindByLong request);

    DealFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request);

    Task<DealFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request);

    DealInsertDtoResponse Create(DealInsertDtoRequest request);

    Task<DealInsertDtoResponse> CreateAsync(DealInsertDtoRequest request);

    DealInsertRangeDtoResponse CreateRange(DealInsertRangeDtoRequest request);

    Task<DealInsertRangeDtoResponse> CreateRangeAsync(DealInsertRangeDtoRequest request);

    DealUpdateDtoResponse Update(DealUpdateDtoRequest request);

    Task<DealUpdateDtoResponse> UpdateAsync(DealUpdateDtoRequest request);

    Task<DealUpdateDtoResponse> UpdateStepAsync(DealChangeStepDtoRequest request);

    DealUpdateRangeDtoResponse UpdateRange(DealUpdateRangeDtoRequest request);

    Task<DealUpdateRangeDtoResponse> UpdateRangeAsync(DealUpdateRangeDtoRequest request);

    DealDeleteDtoResponse Delete(DealDeleteDtoRequest request);

    Task<DealDeleteDtoResponse> DeleteAsync(DealDeleteDtoRequest request);

    DealDeleteRangeDtoResponse DeleteRange(DealDeleteRangeDtoRequest request);

    Task<DealDeleteRangeDtoResponse> DeleteRangeAsync(DealDeleteRangeDtoRequest request);

    Task<DealSaveRangeDtoResponse> SaveRangeAsync(DealSaveRangeDtoRequest request);

    Task<DealSaveRangeDtoResponse> SaveRangeTransactionAsync(DealSaveRangeDtoRequest request);

    Task<DealTableKeySearchDtoResponse> GetTableByKeySearch(DealTableKeySearchDtoRequest request);
    Task<DealTableKeySearchDtoResponse> GetViewByKeySearch(DealTableKeySearchDtoRequest request);
}

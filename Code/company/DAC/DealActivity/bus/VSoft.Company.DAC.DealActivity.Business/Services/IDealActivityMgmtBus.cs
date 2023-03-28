using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.DAC.DealActivity.Business.Dto.Request;
using VSoft.Company.DAC.DealActivity.Business.Dto.Response;

namespace VSoft.Company.DAC.DealActivity.Business.Services;

public interface IDealActivityMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByInt request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByInt request);

    DealActivityFindDtoResponse Find(MDtoRequestFindByInt request);

    Task<DealActivityFindDtoResponse> FindAsync(MDtoRequestFindByInt request);

    DealActivityFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request);

    Task<DealActivityFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request);

    DealActivityInsertDtoResponse Create(DealActivityInsertDtoRequest request);

    Task<DealActivityInsertDtoResponse> CreateAsync(DealActivityInsertDtoRequest request);

    DealActivityInsertRangeDtoResponse CreateRange(DealActivityInsertRangeDtoRequest request);

    Task<DealActivityInsertRangeDtoResponse> CreateRangeAsync(DealActivityInsertRangeDtoRequest request);

    DealActivityUpdateDtoResponse Update(DealActivityUpdateDtoRequest request);

    Task<DealActivityUpdateDtoResponse> UpdateAsync(DealActivityUpdateDtoRequest request);

    DealActivityUpdateRangeDtoResponse UpdateRange(DealActivityUpdateRangeDtoRequest request);

    Task<DealActivityUpdateRangeDtoResponse> UpdateRangeAsync(DealActivityUpdateRangeDtoRequest request);

    DealActivityDeleteDtoResponse Delete(DealActivityDeleteDtoRequest request);

    Task<DealActivityDeleteDtoResponse> DeleteAsync(DealActivityDeleteDtoRequest request);

    DealActivityDeleteRangeDtoResponse DeleteRange(DealActivityDeleteRangeDtoRequest request);

    Task<DealActivityDeleteRangeDtoResponse> DeleteRangeAsync(DealActivityDeleteRangeDtoRequest request);

    Task<DealActivitySaveRangeDtoResponse> SaveRangeAsync(DealActivitySaveRangeDtoRequest request);

    Task<DealActivitySaveRangeDtoResponse> SaveRangeTransactionAsync(DealActivitySaveRangeDtoRequest request);
}

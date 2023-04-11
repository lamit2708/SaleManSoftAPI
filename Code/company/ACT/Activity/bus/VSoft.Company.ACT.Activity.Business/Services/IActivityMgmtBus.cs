using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.ACT.Activity.Business.Dto.Request;
using VSoft.Company.ACT.Activity.Business.Dto.Response;

namespace VSoft.Company.ACT.Activity.Business.Services;

public interface IActivityMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByInt request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByInt request);

    ActivityFindDtoResponse Find(MDtoRequestFindByInt request);

    Task<ActivityFindDtoResponse> FindAsync(MDtoRequestFindByInt request);

    ActivityFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request);

    Task<ActivityFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request);

    ActivityInsertDtoResponse Create(ActivityInsertDtoRequest request);

    Task<ActivityInsertDtoResponse> CreateAsync(ActivityInsertDtoRequest request);

    ActivityInsertRangeDtoResponse CreateRange(ActivityInsertRangeDtoRequest request);

    Task<ActivityInsertRangeDtoResponse> CreateRangeAsync(ActivityInsertRangeDtoRequest request);

    ActivityUpdateDtoResponse Update(ActivityUpdateDtoRequest request);

    Task<ActivityUpdateDtoResponse> UpdateAsync(ActivityUpdateDtoRequest request);

    ActivityUpdateRangeDtoResponse UpdateRange(ActivityUpdateRangeDtoRequest request);

    Task<ActivityUpdateRangeDtoResponse> UpdateRangeAsync(ActivityUpdateRangeDtoRequest request);

    ActivityDeleteDtoResponse Delete(ActivityDeleteDtoRequest request);

    Task<ActivityDeleteDtoResponse> DeleteAsync(ActivityDeleteDtoRequest request);

    ActivityDeleteRangeDtoResponse DeleteRange(ActivityDeleteRangeDtoRequest request);

    Task<ActivityDeleteRangeDtoResponse> DeleteRangeAsync(ActivityDeleteRangeDtoRequest request);

    Task<ActivitySaveRangeDtoResponse> SaveRangeAsync(ActivitySaveRangeDtoRequest request);

    Task<ActivitySaveRangeDtoResponse> SaveRangeTransactionAsync(ActivitySaveRangeDtoRequest request);

    Task<ActivityTableKeySearchDtoResponse> GetTableByKeySearch(ActivityTableKeySearchDtoRequest request);
}

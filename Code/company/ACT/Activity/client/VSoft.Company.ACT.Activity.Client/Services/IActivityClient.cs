using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.ACT.Activity.Business.Dto.Request;
using VSoft.Company.ACT.Activity.Business.Dto.Response;

namespace VSoft.Company.ACT.Activity.Client.Services;

public interface IActivityClient: IApiDtoClientJSon<IActivityClient>
{  

    Task<ActivityFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<ActivityFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<ActivityInsertDtoResponse> CreateAsync(ActivityInsertDtoRequest request);

    Task<ActivityInsertRangeDtoResponse> CreateRangeAsync(ActivityInsertRangeDtoRequest request);

    Task<ActivityUpdateDtoResponse> UpdateAsync(ActivityUpdateDtoRequest request);

    Task<ActivityUpdateRangeDtoResponse> UpdateRangeAsync(ActivityUpdateRangeDtoRequest request);

    Task<ActivityDeleteDtoResponse> DeleteAsync(ActivityDeleteDtoRequest request);

    Task<ActivityDeleteRangeDtoResponse> DeleteRangeAsync(ActivityDeleteRangeDtoRequest request);

    Task<ActivitySaveRangeDtoResponse> SaveRangeAsync(ActivitySaveRangeDtoRequest request);
   
}
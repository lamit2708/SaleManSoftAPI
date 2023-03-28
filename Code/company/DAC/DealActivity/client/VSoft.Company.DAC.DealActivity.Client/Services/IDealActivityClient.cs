using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.DAC.DealActivity.Business.Dto.Request;
using VSoft.Company.DAC.DealActivity.Business.Dto.Response;

namespace VSoft.Company.DAC.DealActivity.Client.Services;

public interface IDealActivityClient: IApiDtoClientJSon<IDealActivityClient>
{  

    Task<DealActivityFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<DealActivityFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<DealActivityInsertDtoResponse> CreateAsync(DealActivityInsertDtoRequest request);

    Task<DealActivityInsertRangeDtoResponse> CreateRangeAsync(DealActivityInsertRangeDtoRequest request);

    Task<DealActivityUpdateDtoResponse> UpdateAsync(DealActivityUpdateDtoRequest request);

    Task<DealActivityUpdateRangeDtoResponse> UpdateRangeAsync(DealActivityUpdateRangeDtoRequest request);

    Task<DealActivityDeleteDtoResponse> DeleteAsync(DealActivityDeleteDtoRequest request);

    Task<DealActivityDeleteRangeDtoResponse> DeleteRangeAsync(DealActivityDeleteRangeDtoRequest request);

    Task<DealActivitySaveRangeDtoResponse> SaveRangeAsync(DealActivitySaveRangeDtoRequest request);
   
}
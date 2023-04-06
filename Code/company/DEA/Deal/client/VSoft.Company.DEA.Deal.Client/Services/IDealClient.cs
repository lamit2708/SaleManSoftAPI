using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.DEA.Deal.Business.Dto.Request;
using VSoft.Company.DEA.Deal.Business.Dto.Response;

namespace VSoft.Company.DEA.Deal.Client.Services;

public interface IDealClient: IApiDtoClientJSon<IDealClient>
{
    Task<DealTableKeySearchDtoResponse> GetTableByKeyword(DealTableKeySearchDtoRequest request);

    Task<DealFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<DealFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<DealInsertDtoResponse> CreateAsync(DealInsertDtoRequest request);

    Task<DealInsertRangeDtoResponse> CreateRangeAsync(DealInsertRangeDtoRequest request);

    Task<DealUpdateDtoResponse> UpdateAsync(DealUpdateDtoRequest request);

    Task<DealUpdateRangeDtoResponse> UpdateRangeAsync(DealUpdateRangeDtoRequest request);

    Task<DealDeleteDtoResponse> DeleteAsync(DealDeleteDtoRequest request);

    Task<DealDeleteRangeDtoResponse> DeleteRangeAsync(DealDeleteRangeDtoRequest request);

    Task<DealSaveRangeDtoResponse> SaveRangeAsync(DealSaveRangeDtoRequest request);
   
}
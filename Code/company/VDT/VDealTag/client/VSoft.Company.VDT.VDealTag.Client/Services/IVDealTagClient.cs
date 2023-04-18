using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.VDT.VDealTag.Business.Dto.Request;
using VSoft.Company.VDT.VDealTag.Business.Dto.Response;

namespace VSoft.Company.VDT.VDealTag.Client.Services;

public interface IVDealTagClient: IApiDtoClientJSon<IVDealTagClient>
{  

    Task<VDealTagFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<VDealTagFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<VDealTagInsertDtoResponse> CreateAsync(VDealTagInsertDtoRequest request);

    Task<VDealTagInsertRangeDtoResponse> CreateRangeAsync(VDealTagInsertRangeDtoRequest request);

    Task<VDealTagUpdateDtoResponse> UpdateAsync(VDealTagUpdateDtoRequest request);

    Task<VDealTagUpdateRangeDtoResponse> UpdateRangeAsync(VDealTagUpdateRangeDtoRequest request);

    Task<VDealTagDeleteDtoResponse> DeleteAsync(VDealTagDeleteDtoRequest request);

    Task<VDealTagDeleteRangeDtoResponse> DeleteRangeAsync(VDealTagDeleteRangeDtoRequest request);

    Task<VDealTagSaveRangeDtoResponse> SaveRangeAsync(VDealTagSaveRangeDtoRequest request);
    Task<VDealTagTableKeySearchDtoResponse> GetTableByKeyword(VDealTagTableKeySearchDtoRequest request);

}
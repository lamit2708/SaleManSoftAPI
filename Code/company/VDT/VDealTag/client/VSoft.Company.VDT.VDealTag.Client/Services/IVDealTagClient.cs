using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.VDT.VDealTag.Business.Dto.Request;
using VSoft.Company.VDT.VDealTag.Business.Dto.Response;

namespace VSoft.Company.VDT.VDealTag.Client.Services;

public interface IVDealTagClient: IApiDtoClientJSon<IVDealTagClient>
{  

    Task<VDealTagFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<VDealTagFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<VDealTagTableKeySearchDtoResponse> GetTableByKeyword(VDealTagTableKeySearchDtoRequest request);

}
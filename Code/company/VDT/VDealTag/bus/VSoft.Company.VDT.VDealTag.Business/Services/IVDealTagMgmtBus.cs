using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.VDT.VDealTag.Business.Dto.Request;
using VSoft.Company.VDT.VDealTag.Business.Dto.Response;

namespace VSoft.Company.VDT.VDealTag.Business.Services;

public interface IVDealTagMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByLong request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByLong request);

    VDealTagFindDtoResponse Find(MDtoRequestFindByLong request);

    Task<VDealTagFindDtoResponse> FindAsync(MDtoRequestFindByLong request);

    VDealTagFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request);

    Task<VDealTagFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request);

    Task<VDealTagTableKeySearchDtoResponse> GetTableByKeySearch(VDealTagTableKeySearchDtoRequest request);
}

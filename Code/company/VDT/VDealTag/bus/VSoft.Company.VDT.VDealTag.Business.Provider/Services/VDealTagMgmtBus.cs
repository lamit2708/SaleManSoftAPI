using VSoft.Company.VDT.VDealTag.Business.Dto.Request;
using VSoft.Company.VDT.VDealTag.Business.Dto.Response;
using VSoft.Company.VDT.VDealTag.Business.Services;
using VSoft.Company.VDT.VDealTag.Repository.Services;
using VSoft.Company.VDT.VDealTag.Data.Entity.Models;
using VSoft.Company.VDT.VDealTag.Business.Dto.Extension.Methods;
using VSoft.Company.VDT.VDealTag.Business.entity.Extension.Methods;
using VSoft.Company.VDT.VDealTag.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.VDT.VDealTag.Business.Provider.Services;

public class VDealTagMgmtBus : BusinessRepositoryService<VDealTagDto, IVDealTagRepository>, IVDealTagMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(VDealTagDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(VDealTagDto.CustomerName),
        
    };

    public VDealTagMgmtBus(IVDealTagRepository customerRepository) : base(customerRepository)
    {

    }

    public MDtoResponseString GetFullName(MDtoRequestFindByLong request)
    {
        return GetValue<MDtoRequestFindByLong, MDtoResponseString, long, string>
        (
            nameof(GetFullName), request, "email",
            (id) => Repository?.GetFullName(id)
        );
    }

    public async Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByLong request)
    {
        return await GetValueAsync<MDtoRequestFindByLong, MDtoResponseString, long, string>
        (
            nameof(GetFullNameAsync), request, "email",
            async (id) => await (Repository?.GetFullNameAsync(id) ?? Task.FromResult<string?>(null))
        );
    }

    public VDealTagFindDtoResponse Find(MDtoRequestFindByLong request)
    {
        return Find<MDtoRequestFindByLong, VDealTagFindDtoResponse, long>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<VDealTagFindDtoResponse> FindAsync(MDtoRequestFindByLong request)
    {
        return await FindAsync<MDtoRequestFindByLong, VDealTagFindDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MVDealTagEntity?>(null)))?.GetDto()
        );
    }

    public VDealTagFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request)
    {
        return FindRange<MDtoRequestFindRangeByLongs, VDealTagFindRangeDtoResponse, long>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<VDealTagFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByLongs, VDealTagFindRangeDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MVDealTagEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }
    
    public async Task<VDealTagTableKeySearchDtoResponse> GetTableByKeySearch(VDealTagTableKeySearchDtoRequest request)
    {
        var rsRespo = await Repository?.GetTableByKeySearchAsync(request.Data, request.PagingParams);
        var response = new VDealTagTableKeySearchDtoResponse();
        if (rsRespo != null)
        {
            response.Data = rsRespo.Items.GetDto().ToArray();
            response.MetaData = rsRespo.MetaData;
            response.IsSuccess = true;
        };
        return response;
    }

    public async Task<VDealTagFilterDtoResponse> GetDataByFilter(VDealTagFilterDtoRequest request)
    {
        var filter = request.Filter;
        var rsRespo = await Repository?.GetAllDealTagByFilter(filter.UserId, filter.TeamId, filter.Date, filter.Keyword);
        var response = new VDealTagFilterDtoResponse();
        if (rsRespo != null)
        {
            response.Data = rsRespo?.GetDto().ToArray();
            response.Filter = filter;
            response.IsSuccess = true;
        }
        return response;
    }
}

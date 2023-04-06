using VSoft.Company.DEA.Deal.Business.Dto.Request;
using VSoft.Company.DEA.Deal.Business.Dto.Response;
using VSoft.Company.DEA.Deal.Business.Services;
using VSoft.Company.DEA.Deal.Repository.Services;
using VSoft.Company.DEA.Deal.Data.Entity.Models;
using VSoft.Company.DEA.Deal.Business.Dto.Extension.Methods;
using VSoft.Company.DEA.Deal.Business.entity.Extension.Methods;
using VSoft.Company.DEA.Deal.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.DEA.Deal.Business.Provider.Services;

public class DealMgmtBus : BusinessRepositoryService<DealDto, IDealRepository>, IDealMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(DealDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(DealDto.Name),
        
    };

    public DealMgmtBus(IDealRepository customerRepository) : base(customerRepository)
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

    public DealFindDtoResponse Find(MDtoRequestFindByLong request)
    {
        return Find<MDtoRequestFindByLong, DealFindDtoResponse, long>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<DealFindDtoResponse> FindAsync(MDtoRequestFindByLong request)
    {
        return await FindAsync<MDtoRequestFindByLong, DealFindDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MDealEntity?>(null)))?.GetDto()
        );
    }

    public DealFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request)
    {
        return FindRange<MDtoRequestFindRangeByLongs, DealFindRangeDtoResponse, long>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<DealFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByLongs, DealFindRangeDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MDealEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public DealInsertDtoResponse Create(DealInsertDtoRequest request)
    {
        return Create<DealInsertDtoRequest, DealInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MDealEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<DealInsertDtoResponse> CreateAsync(DealInsertDtoRequest request)
    {
        return await CreateAsync<DealInsertDtoRequest, DealInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MDealEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MDealEntity?>(new MDealEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public DealInsertRangeDtoResponse CreateRange(DealInsertRangeDtoRequest request)
    {
        return CreateRange<DealInsertRangeDtoRequest, DealInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MDealEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<DealInsertRangeDtoResponse> CreateRangeAsync(DealInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<DealInsertRangeDtoRequest, DealInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MDealEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MDealEntity>?>(Array.Empty<MDealEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public DealUpdateDtoResponse Update(DealUpdateDtoRequest request)
    {
        return Update<DealUpdateDtoRequest, DealUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MDealEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<DealUpdateDtoResponse> UpdateAsync(DealUpdateDtoRequest request)
    {
        return await UpdateAsync<DealUpdateDtoRequest, DealUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MDealEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MDealEntity?>(new MDealEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public DealUpdateRangeDtoResponse UpdateRange(DealUpdateRangeDtoRequest request)
    {
        return UpdateRange<DealUpdateRangeDtoRequest, DealUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MDealEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<DealUpdateRangeDtoResponse> UpdateRangeAsync(DealUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<DealUpdateRangeDtoRequest, DealUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MDealEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MDealEntity>?>(Array.Empty<MDealEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public DealDeleteDtoResponse Delete(DealDeleteDtoRequest request)
    {
        return Delete<DealDeleteDtoRequest, DealDeleteDtoResponse, long>
        (
             request,
             (id) =>
             {
                 var inputEntity = Repository?.GetById(id);
                 var resultEntity = inputEntity != null ? Repository?.Delete(inputEntity) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public async Task<DealDeleteDtoResponse> DeleteAsync(DealDeleteDtoRequest request)
    {
        return await DeleteAsync<DealDeleteDtoRequest, DealDeleteDtoResponse, long>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MDealEntity?>(new MDealEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MDealEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public DealDeleteRangeDtoResponse DeleteRange(DealDeleteRangeDtoRequest request)
    {
        return DeleteRange<DealDeleteRangeDtoRequest, DealDeleteRangeDtoResponse, long>
        (
             request,
             (ids) =>
             {
                 var inputEntities = Repository?.GetByIds(ids);
                 var resultEntities = Repository?.DeleteRange(inputEntities);
                 return resultEntities?.Select(e => e.GetDto()).ToArray();
             }
        );
    }

    public async Task<DealDeleteRangeDtoResponse> DeleteRangeAsync(DealDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<DealDeleteRangeDtoRequest, DealDeleteRangeDtoResponse, long>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MDealEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MDealEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<DealSaveRangeDtoResponse> SaveRangeAsync(DealSaveRangeDtoRequest request, Func<MSaveRangeParams<MDealEntity>?, Task<MSaveRangeResults<MDealEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new DealSaveRangeDtoResponse()
        {
            IsSuccess = false,
            CreatedData = null,
            UpdatedData = null,
            DeletedData = null,
            Message = $"Không có các dữ liệu {ContextName} để thay đổi!",
        }.GetResponse(functionName);
        var createCount = createData?.Length ?? 0;
        var updateCount = updateData?.Length ?? 0;
        var deleteCount = deleteData?.Length ?? 0;
        try
        {
            var createMsg = GetSaveRequiredMessages(createData);
            if (!string.IsNullOrWhiteSpace(createMsg))
            {
                return new DealSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new DealSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MDealEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MDealEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MDealEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MDealEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new DealSaveRangeDtoResponse()
            {
                IsSuccess = true,
                TotalCreated = createCount,
                TotalUpdated = updateCount,
                TotalDeleted = deleteCount,
                CreatedData = resultCreateDtos,
                UpdatedData = resultUpdateDtos,
                DeletedData = resultDeleteDtos,
                Message = sb.ToString(),
            }.GetResponse(functionName);
        }
        catch (Exception ex)
        {
            return new DealSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<DealSaveRangeDtoResponse> SaveRangeAsync(DealSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MDealEntity>?>(null));
    }

    public async Task<DealSaveRangeDtoResponse> SaveRangeTransactionAsync(DealSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MDealEntity>?>(null));
    }

    public async Task<DealTableKeySearchDtoResponse> GetTableByKeySearch(DealTableKeySearchDtoRequest request)
    {
        var rsRespo = await Repository?.GetTableByKeySearchAsync(request.Data, request.PagingParams);
        var response = new DealTableKeySearchDtoResponse();
        if (rsRespo != null)
        {
            response.Data = rsRespo.Items.GetDto().ToArray();
            response.MetaData = rsRespo.MetaData;
            response.IsSuccess = true;
        };
        return response;
    }
}

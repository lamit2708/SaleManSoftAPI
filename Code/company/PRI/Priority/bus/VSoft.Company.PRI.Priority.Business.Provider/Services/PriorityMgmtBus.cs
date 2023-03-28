using VSoft.Company.PRI.Priority.Business.Dto.Request;
using VSoft.Company.PRI.Priority.Business.Dto.Response;
using VSoft.Company.PRI.Priority.Business.Services;
using VSoft.Company.PRI.Priority.Repository.Services;
using VSoft.Company.PRI.Priority.Data.Entity.Models;
using VSoft.Company.PRI.Priority.Business.Dto.Extension.Methods;
using VSoft.Company.PRI.Priority.Business.entity.Extension.Methods;
using VSoft.Company.PRI.Priority.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.PRI.Priority.Business.Provider.Services;

public class PriorityMgmtBus : BusinessRepositoryService<PriorityDto, IPriorityRepository>, IPriorityMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(PriorityDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(PriorityDto.Name),
        
    };

    public PriorityMgmtBus(IPriorityRepository customerRepository) : base(customerRepository)
    {

    }

    public MDtoResponseString GetFullName(MDtoRequestFindByInt request)
    {
        return GetValue<MDtoRequestFindByInt, MDtoResponseString, int, string>
        (
            nameof(GetFullName), request, "email",
            (id) => Repository?.GetFullName(id)
        );
    }

    public async Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByInt request)
    {
        return await GetValueAsync<MDtoRequestFindByInt, MDtoResponseString, int, string>
        (
            nameof(GetFullNameAsync), request, "email",
            async (id) => await (Repository?.GetFullNameAsync(id) ?? Task.FromResult<string?>(null))
        );
    }

    public PriorityFindDtoResponse Find(MDtoRequestFindByInt request)
    {
        return Find<MDtoRequestFindByInt, PriorityFindDtoResponse, int>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<PriorityFindDtoResponse> FindAsync(MDtoRequestFindByInt request)
    {
        return await FindAsync<MDtoRequestFindByInt, PriorityFindDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MPriorityEntity?>(null)))?.GetDto()
        );
    }

    public PriorityFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request)
    {
        return FindRange<MDtoRequestFindRangeByInts, PriorityFindRangeDtoResponse, int>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<PriorityFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByInts, PriorityFindRangeDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MPriorityEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public PriorityInsertDtoResponse Create(PriorityInsertDtoRequest request)
    {
        return Create<PriorityInsertDtoRequest, PriorityInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MPriorityEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<PriorityInsertDtoResponse> CreateAsync(PriorityInsertDtoRequest request)
    {
        return await CreateAsync<PriorityInsertDtoRequest, PriorityInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MPriorityEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MPriorityEntity?>(new MPriorityEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public PriorityInsertRangeDtoResponse CreateRange(PriorityInsertRangeDtoRequest request)
    {
        return CreateRange<PriorityInsertRangeDtoRequest, PriorityInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MPriorityEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<PriorityInsertRangeDtoResponse> CreateRangeAsync(PriorityInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<PriorityInsertRangeDtoRequest, PriorityInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MPriorityEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MPriorityEntity>?>(Array.Empty<MPriorityEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public PriorityUpdateDtoResponse Update(PriorityUpdateDtoRequest request)
    {
        return Update<PriorityUpdateDtoRequest, PriorityUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MPriorityEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<PriorityUpdateDtoResponse> UpdateAsync(PriorityUpdateDtoRequest request)
    {
        return await UpdateAsync<PriorityUpdateDtoRequest, PriorityUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MPriorityEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MPriorityEntity?>(new MPriorityEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public PriorityUpdateRangeDtoResponse UpdateRange(PriorityUpdateRangeDtoRequest request)
    {
        return UpdateRange<PriorityUpdateRangeDtoRequest, PriorityUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MPriorityEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<PriorityUpdateRangeDtoResponse> UpdateRangeAsync(PriorityUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<PriorityUpdateRangeDtoRequest, PriorityUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MPriorityEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MPriorityEntity>?>(Array.Empty<MPriorityEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public PriorityDeleteDtoResponse Delete(PriorityDeleteDtoRequest request)
    {
        return Delete<PriorityDeleteDtoRequest, PriorityDeleteDtoResponse, long>
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

    public async Task<PriorityDeleteDtoResponse> DeleteAsync(PriorityDeleteDtoRequest request)
    {
        return await DeleteAsync<PriorityDeleteDtoRequest, PriorityDeleteDtoResponse, long>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MPriorityEntity?>(new MPriorityEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MPriorityEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public PriorityDeleteRangeDtoResponse DeleteRange(PriorityDeleteRangeDtoRequest request)
    {
        return DeleteRange<PriorityDeleteRangeDtoRequest, PriorityDeleteRangeDtoResponse, int>
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

    public async Task<PriorityDeleteRangeDtoResponse> DeleteRangeAsync(PriorityDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<PriorityDeleteRangeDtoRequest, PriorityDeleteRangeDtoResponse, int>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MPriorityEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MPriorityEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<PrioritySaveRangeDtoResponse> SaveRangeAsync(PrioritySaveRangeDtoRequest request, Func<MSaveRangeParams<MPriorityEntity>?, Task<MSaveRangeResults<MPriorityEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new PrioritySaveRangeDtoResponse()
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
                return new PrioritySaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new PrioritySaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MPriorityEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MPriorityEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MPriorityEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MPriorityEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new PrioritySaveRangeDtoResponse()
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
            return new PrioritySaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<PrioritySaveRangeDtoResponse> SaveRangeAsync(PrioritySaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MPriorityEntity>?>(null));
    }

    public async Task<PrioritySaveRangeDtoResponse> SaveRangeTransactionAsync(PrioritySaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MPriorityEntity>?>(null));
    }
}

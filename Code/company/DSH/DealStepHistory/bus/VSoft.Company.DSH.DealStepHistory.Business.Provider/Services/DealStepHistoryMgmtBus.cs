using VSoft.Company.DSH.DealStepHistory.Business.Dto.Request;
using VSoft.Company.DSH.DealStepHistory.Business.Dto.Response;
using VSoft.Company.DSH.DealStepHistory.Business.Services;
using VSoft.Company.DSH.DealStepHistory.Repository.Services;
using VSoft.Company.DSH.DealStepHistory.Data.Entity.Models;
using VSoft.Company.DSH.DealStepHistory.Business.Dto.Extension.Methods;
using VSoft.Company.DSH.DealStepHistory.Business.entity.Extension.Methods;
using VSoft.Company.DSH.DealStepHistory.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.DSH.DealStepHistory.Business.Provider.Services;

public class DealStepHistoryMgmtBus : BusinessRepositoryService<DealStepHistoryDto, IDealStepHistoryRepository>, IDealStepHistoryMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(DealStepHistoryDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(DealStepHistoryDto.DealStepId),
        
    };

    public DealStepHistoryMgmtBus(IDealStepHistoryRepository customerRepository) : base(customerRepository)
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

    public DealStepHistoryFindDtoResponse Find(MDtoRequestFindByLong request)
    {
        return Find<MDtoRequestFindByLong, DealStepHistoryFindDtoResponse, long>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<DealStepHistoryFindDtoResponse> FindAsync(MDtoRequestFindByLong request)
    {
        return await FindAsync<MDtoRequestFindByLong, DealStepHistoryFindDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MDealStepHistoryEntity?>(null)))?.GetDto()
        );
    }

    public DealStepHistoryFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request)
    {
        return FindRange<MDtoRequestFindRangeByLongs, DealStepHistoryFindRangeDtoResponse, long>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<DealStepHistoryFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByLongs, DealStepHistoryFindRangeDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MDealStepHistoryEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public DealStepHistoryInsertDtoResponse Create(DealStepHistoryInsertDtoRequest request)
    {
        return Create<DealStepHistoryInsertDtoRequest, DealStepHistoryInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MDealStepHistoryEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<DealStepHistoryInsertDtoResponse> CreateAsync(DealStepHistoryInsertDtoRequest request)
    {
        return await CreateAsync<DealStepHistoryInsertDtoRequest, DealStepHistoryInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MDealStepHistoryEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MDealStepHistoryEntity?>(new MDealStepHistoryEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public DealStepHistoryInsertRangeDtoResponse CreateRange(DealStepHistoryInsertRangeDtoRequest request)
    {
        return CreateRange<DealStepHistoryInsertRangeDtoRequest, DealStepHistoryInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MDealStepHistoryEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<DealStepHistoryInsertRangeDtoResponse> CreateRangeAsync(DealStepHistoryInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<DealStepHistoryInsertRangeDtoRequest, DealStepHistoryInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MDealStepHistoryEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MDealStepHistoryEntity>?>(Array.Empty<MDealStepHistoryEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public DealStepHistoryUpdateDtoResponse Update(DealStepHistoryUpdateDtoRequest request)
    {
        return Update<DealStepHistoryUpdateDtoRequest, DealStepHistoryUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MDealStepHistoryEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<DealStepHistoryUpdateDtoResponse> UpdateAsync(DealStepHistoryUpdateDtoRequest request)
    {
        return await UpdateAsync<DealStepHistoryUpdateDtoRequest, DealStepHistoryUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MDealStepHistoryEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MDealStepHistoryEntity?>(new MDealStepHistoryEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public DealStepHistoryUpdateRangeDtoResponse UpdateRange(DealStepHistoryUpdateRangeDtoRequest request)
    {
        return UpdateRange<DealStepHistoryUpdateRangeDtoRequest, DealStepHistoryUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MDealStepHistoryEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<DealStepHistoryUpdateRangeDtoResponse> UpdateRangeAsync(DealStepHistoryUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<DealStepHistoryUpdateRangeDtoRequest, DealStepHistoryUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MDealStepHistoryEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MDealStepHistoryEntity>?>(Array.Empty<MDealStepHistoryEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public DealStepHistoryDeleteDtoResponse Delete(DealStepHistoryDeleteDtoRequest request)
    {
        return Delete<DealStepHistoryDeleteDtoRequest, DealStepHistoryDeleteDtoResponse, long>
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

    public async Task<DealStepHistoryDeleteDtoResponse> DeleteAsync(DealStepHistoryDeleteDtoRequest request)
    {
        return await DeleteAsync<DealStepHistoryDeleteDtoRequest, DealStepHistoryDeleteDtoResponse, long>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MDealStepHistoryEntity?>(new MDealStepHistoryEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MDealStepHistoryEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public DealStepHistoryDeleteRangeDtoResponse DeleteRange(DealStepHistoryDeleteRangeDtoRequest request)
    {
        return DeleteRange<DealStepHistoryDeleteRangeDtoRequest, DealStepHistoryDeleteRangeDtoResponse, long>
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

    public async Task<DealStepHistoryDeleteRangeDtoResponse> DeleteRangeAsync(DealStepHistoryDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<DealStepHistoryDeleteRangeDtoRequest, DealStepHistoryDeleteRangeDtoResponse, long>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MDealStepHistoryEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MDealStepHistoryEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<DealStepHistorySaveRangeDtoResponse> SaveRangeAsync(DealStepHistorySaveRangeDtoRequest request, Func<MSaveRangeParams<MDealStepHistoryEntity>?, Task<MSaveRangeResults<MDealStepHistoryEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new DealStepHistorySaveRangeDtoResponse()
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
                return new DealStepHistorySaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new DealStepHistorySaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MDealStepHistoryEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MDealStepHistoryEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MDealStepHistoryEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MDealStepHistoryEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new DealStepHistorySaveRangeDtoResponse()
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
            return new DealStepHistorySaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<DealStepHistorySaveRangeDtoResponse> SaveRangeAsync(DealStepHistorySaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MDealStepHistoryEntity>?>(null));
    }

    public async Task<DealStepHistorySaveRangeDtoResponse> SaveRangeTransactionAsync(DealStepHistorySaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MDealStepHistoryEntity>?>(null));
    }
}

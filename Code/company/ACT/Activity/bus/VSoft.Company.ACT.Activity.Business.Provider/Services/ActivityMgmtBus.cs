using VSoft.Company.ACT.Activity.Business.Dto.Request;
using VSoft.Company.ACT.Activity.Business.Dto.Response;
using VSoft.Company.ACT.Activity.Business.Services;
using VSoft.Company.ACT.Activity.Repository.Services;
using VSoft.Company.ACT.Activity.Data.Entity.Models;
using VSoft.Company.ACT.Activity.Business.Dto.Extension.Methods;
using VSoft.Company.ACT.Activity.Business.entity.Extension.Methods;
using VSoft.Company.ACT.Activity.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.ACT.Activity.Business.Provider.Services;

public class ActivityMgmtBus : BusinessRepositoryService<ActivityDto, IActivityRepository>, IActivityMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(ActivityDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(ActivityDto.Name),
        
    };

    public ActivityMgmtBus(IActivityRepository customerRepository) : base(customerRepository)
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

    public ActivityFindDtoResponse Find(MDtoRequestFindByInt request)
    {
        return Find<MDtoRequestFindByInt, ActivityFindDtoResponse, int>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<ActivityFindDtoResponse> FindAsync(MDtoRequestFindByInt request)
    {
        return await FindAsync<MDtoRequestFindByInt, ActivityFindDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MActivityEntity?>(null)))?.GetDto()
        );
    }

    public ActivityFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request)
    {
        return FindRange<MDtoRequestFindRangeByInts, ActivityFindRangeDtoResponse, int>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<ActivityFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByInts, ActivityFindRangeDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MActivityEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public ActivityInsertDtoResponse Create(ActivityInsertDtoRequest request)
    {
        return Create<ActivityInsertDtoRequest, ActivityInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MActivityEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<ActivityInsertDtoResponse> CreateAsync(ActivityInsertDtoRequest request)
    {
        return await CreateAsync<ActivityInsertDtoRequest, ActivityInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MActivityEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MActivityEntity?>(new MActivityEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public ActivityInsertRangeDtoResponse CreateRange(ActivityInsertRangeDtoRequest request)
    {
        return CreateRange<ActivityInsertRangeDtoRequest, ActivityInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MActivityEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<ActivityInsertRangeDtoResponse> CreateRangeAsync(ActivityInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<ActivityInsertRangeDtoRequest, ActivityInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MActivityEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MActivityEntity>?>(Array.Empty<MActivityEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public ActivityUpdateDtoResponse Update(ActivityUpdateDtoRequest request)
    {
        return Update<ActivityUpdateDtoRequest, ActivityUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MActivityEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<ActivityUpdateDtoResponse> UpdateAsync(ActivityUpdateDtoRequest request)
    {
        return await UpdateAsync<ActivityUpdateDtoRequest, ActivityUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MActivityEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MActivityEntity?>(new MActivityEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public ActivityUpdateRangeDtoResponse UpdateRange(ActivityUpdateRangeDtoRequest request)
    {
        return UpdateRange<ActivityUpdateRangeDtoRequest, ActivityUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MActivityEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<ActivityUpdateRangeDtoResponse> UpdateRangeAsync(ActivityUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<ActivityUpdateRangeDtoRequest, ActivityUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MActivityEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MActivityEntity>?>(Array.Empty<MActivityEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public ActivityDeleteDtoResponse Delete(ActivityDeleteDtoRequest request)
    {
        return Delete<ActivityDeleteDtoRequest, ActivityDeleteDtoResponse, long>
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

    public async Task<ActivityDeleteDtoResponse> DeleteAsync(ActivityDeleteDtoRequest request)
    {
        return await DeleteAsync<ActivityDeleteDtoRequest, ActivityDeleteDtoResponse, long>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MActivityEntity?>(new MActivityEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MActivityEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public ActivityDeleteRangeDtoResponse DeleteRange(ActivityDeleteRangeDtoRequest request)
    {
        return DeleteRange<ActivityDeleteRangeDtoRequest, ActivityDeleteRangeDtoResponse, int>
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

    public async Task<ActivityDeleteRangeDtoResponse> DeleteRangeAsync(ActivityDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<ActivityDeleteRangeDtoRequest, ActivityDeleteRangeDtoResponse, int>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MActivityEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MActivityEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<ActivitySaveRangeDtoResponse> SaveRangeAsync(ActivitySaveRangeDtoRequest request, Func<MSaveRangeParams<MActivityEntity>?, Task<MSaveRangeResults<MActivityEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new ActivitySaveRangeDtoResponse()
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
                return new ActivitySaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new ActivitySaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MActivityEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MActivityEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MActivityEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MActivityEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new ActivitySaveRangeDtoResponse()
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
            return new ActivitySaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<ActivitySaveRangeDtoResponse> SaveRangeAsync(ActivitySaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MActivityEntity>?>(null));
    }

    public async Task<ActivitySaveRangeDtoResponse> SaveRangeTransactionAsync(ActivitySaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MActivityEntity>?>(null));
    }
}

using VSoft.Company.TEA.Team.Business.Dto.Request;
using VSoft.Company.TEA.Team.Business.Dto.Response;
using VSoft.Company.TEA.Team.Business.Services;
using VSoft.Company.TEA.Team.Repository.Services;
using VSoft.Company.TEA.Team.Data.Entity.Models;
using VSoft.Company.TEA.Team.Business.Dto.Extension.Methods;
using VSoft.Company.TEA.Team.Business.entity.Extension.Methods;
using VSoft.Company.TEA.Team.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.TEA.Team.Business.Provider.Services;

public class TeamMgmtBus : BusinessRepositoryService<TeamDto, ITeamRepository>, ITeamMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(TeamDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(TeamDto.Name),
        
    };

    public TeamMgmtBus(ITeamRepository customerRepository) : base(customerRepository)
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

    public TeamFindDtoResponse Find(MDtoRequestFindByInt request)
    {
        return Find<MDtoRequestFindByInt, TeamFindDtoResponse, int>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<TeamFindDtoResponse> FindAsync(MDtoRequestFindByInt request)
    {
        return await FindAsync<MDtoRequestFindByInt, TeamFindDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MTeamEntity?>(null)))?.GetDto()
        );
    }

    public TeamFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request)
    {
        return FindRange<MDtoRequestFindRangeByInts, TeamFindRangeDtoResponse, int>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<TeamFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByInts, TeamFindRangeDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MTeamEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public TeamInsertDtoResponse Create(TeamInsertDtoRequest request)
    {
        return Create<TeamInsertDtoRequest, TeamInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MTeamEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<TeamInsertDtoResponse> CreateAsync(TeamInsertDtoRequest request)
    {
        return await CreateAsync<TeamInsertDtoRequest, TeamInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MTeamEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MTeamEntity?>(new MTeamEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public TeamInsertRangeDtoResponse CreateRange(TeamInsertRangeDtoRequest request)
    {
        return CreateRange<TeamInsertRangeDtoRequest, TeamInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MTeamEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<TeamInsertRangeDtoResponse> CreateRangeAsync(TeamInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<TeamInsertRangeDtoRequest, TeamInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MTeamEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MTeamEntity>?>(Array.Empty<MTeamEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public TeamUpdateDtoResponse Update(TeamUpdateDtoRequest request)
    {
        return Update<TeamUpdateDtoRequest, TeamUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MTeamEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<TeamUpdateDtoResponse> UpdateAsync(TeamUpdateDtoRequest request)
    {
        return await UpdateAsync<TeamUpdateDtoRequest, TeamUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MTeamEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MTeamEntity?>(new MTeamEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public TeamUpdateRangeDtoResponse UpdateRange(TeamUpdateRangeDtoRequest request)
    {
        return UpdateRange<TeamUpdateRangeDtoRequest, TeamUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MTeamEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<TeamUpdateRangeDtoResponse> UpdateRangeAsync(TeamUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<TeamUpdateRangeDtoRequest, TeamUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MTeamEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MTeamEntity>?>(Array.Empty<MTeamEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public TeamDeleteDtoResponse Delete(TeamDeleteDtoRequest request)
    {
        return Delete<TeamDeleteDtoRequest, TeamDeleteDtoResponse, long>
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

    public async Task<TeamDeleteDtoResponse> DeleteAsync(TeamDeleteDtoRequest request)
    {
        return await DeleteAsync<TeamDeleteDtoRequest, TeamDeleteDtoResponse, long>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MTeamEntity?>(new MTeamEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MTeamEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public TeamDeleteRangeDtoResponse DeleteRange(TeamDeleteRangeDtoRequest request)
    {
        return DeleteRange<TeamDeleteRangeDtoRequest, TeamDeleteRangeDtoResponse, int>
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

    public async Task<TeamDeleteRangeDtoResponse> DeleteRangeAsync(TeamDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<TeamDeleteRangeDtoRequest, TeamDeleteRangeDtoResponse, int>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MTeamEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MTeamEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<TeamSaveRangeDtoResponse> SaveRangeAsync(TeamSaveRangeDtoRequest request, Func<MSaveRangeParams<MTeamEntity>?, Task<MSaveRangeResults<MTeamEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new TeamSaveRangeDtoResponse()
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
                return new TeamSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new TeamSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MTeamEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MTeamEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MTeamEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MTeamEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new TeamSaveRangeDtoResponse()
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
            return new TeamSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<TeamSaveRangeDtoResponse> SaveRangeAsync(TeamSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MTeamEntity>?>(null));
    }

    public async Task<TeamSaveRangeDtoResponse> SaveRangeTransactionAsync(TeamSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MTeamEntity>?>(null));
    }
}

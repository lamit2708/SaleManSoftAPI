using VSoft.Company.ROL.Role.Business.Dto.Request;
using VSoft.Company.ROL.Role.Business.Dto.Response;
using VSoft.Company.ROL.Role.Business.Services;
using VSoft.Company.ROL.Role.Repository.Services;
using VSoft.Company.ROL.Role.Data.Entity.Models;
using VSoft.Company.ROL.Role.Business.Dto.Extension.Methods;
using VSoft.Company.ROL.Role.Business.entity.Extension.Methods;
using VSoft.Company.ROL.Role.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.ROL.Role.Business.Provider.Services;

public class RoleMgmtBus : BusinessRepositoryService<RoleDto, IRoleRepository>, IRoleMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(RoleDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(RoleDto.Name),
        
    };

    public RoleMgmtBus(IRoleRepository customerRepository) : base(customerRepository)
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

    public RoleFindDtoResponse Find(MDtoRequestFindByInt request)
    {
        return Find<MDtoRequestFindByInt, RoleFindDtoResponse, int>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<RoleFindDtoResponse> FindAsync(MDtoRequestFindByInt request)
    {
        return await FindAsync<MDtoRequestFindByInt, RoleFindDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MRoleEntity?>(null)))?.GetDto()
        );
    }

    public RoleFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request)
    {
        return FindRange<MDtoRequestFindRangeByInts, RoleFindRangeDtoResponse, int>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<RoleFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByInts, RoleFindRangeDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MRoleEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public RoleInsertDtoResponse Create(RoleInsertDtoRequest request)
    {
        return Create<RoleInsertDtoRequest, RoleInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MRoleEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<RoleInsertDtoResponse> CreateAsync(RoleInsertDtoRequest request)
    {
        return await CreateAsync<RoleInsertDtoRequest, RoleInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MRoleEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MRoleEntity?>(new MRoleEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public RoleInsertRangeDtoResponse CreateRange(RoleInsertRangeDtoRequest request)
    {
        return CreateRange<RoleInsertRangeDtoRequest, RoleInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MRoleEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<RoleInsertRangeDtoResponse> CreateRangeAsync(RoleInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<RoleInsertRangeDtoRequest, RoleInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MRoleEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MRoleEntity>?>(Array.Empty<MRoleEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public RoleUpdateDtoResponse Update(RoleUpdateDtoRequest request)
    {
        return Update<RoleUpdateDtoRequest, RoleUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MRoleEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<RoleUpdateDtoResponse> UpdateAsync(RoleUpdateDtoRequest request)
    {
        return await UpdateAsync<RoleUpdateDtoRequest, RoleUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MRoleEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MRoleEntity?>(new MRoleEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public RoleUpdateRangeDtoResponse UpdateRange(RoleUpdateRangeDtoRequest request)
    {
        return UpdateRange<RoleUpdateRangeDtoRequest, RoleUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MRoleEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<RoleUpdateRangeDtoResponse> UpdateRangeAsync(RoleUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<RoleUpdateRangeDtoRequest, RoleUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MRoleEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MRoleEntity>?>(Array.Empty<MRoleEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public RoleDeleteDtoResponse Delete(RoleDeleteDtoRequest request)
    {
        return Delete<RoleDeleteDtoRequest, RoleDeleteDtoResponse, long>
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

    public async Task<RoleDeleteDtoResponse> DeleteAsync(RoleDeleteDtoRequest request)
    {
        return await DeleteAsync<RoleDeleteDtoRequest, RoleDeleteDtoResponse, long>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MRoleEntity?>(new MRoleEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MRoleEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public RoleDeleteRangeDtoResponse DeleteRange(RoleDeleteRangeDtoRequest request)
    {
        return DeleteRange<RoleDeleteRangeDtoRequest, RoleDeleteRangeDtoResponse, int>
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

    public async Task<RoleDeleteRangeDtoResponse> DeleteRangeAsync(RoleDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<RoleDeleteRangeDtoRequest, RoleDeleteRangeDtoResponse, int>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MRoleEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MRoleEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<RoleSaveRangeDtoResponse> SaveRangeAsync(RoleSaveRangeDtoRequest request, Func<MSaveRangeParams<MRoleEntity>?, Task<MSaveRangeResults<MRoleEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new RoleSaveRangeDtoResponse()
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
                return new RoleSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new RoleSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MRoleEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MRoleEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MRoleEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MRoleEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new RoleSaveRangeDtoResponse()
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
            return new RoleSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<RoleSaveRangeDtoResponse> SaveRangeAsync(RoleSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MRoleEntity>?>(null));
    }

    public async Task<RoleSaveRangeDtoResponse> SaveRangeTransactionAsync(RoleSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MRoleEntity>?>(null));
    }
}

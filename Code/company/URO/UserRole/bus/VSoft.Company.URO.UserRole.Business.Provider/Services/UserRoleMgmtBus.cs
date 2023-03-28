using VSoft.Company.URO.UserRole.Business.Dto.Request;
using VSoft.Company.URO.UserRole.Business.Dto.Response;
using VSoft.Company.URO.UserRole.Business.Services;
using VSoft.Company.URO.UserRole.Repository.Services;
using VSoft.Company.URO.UserRole.Data.Entity.Models;
using VSoft.Company.URO.UserRole.Business.Dto.Extension.Methods;
using VSoft.Company.URO.UserRole.Business.entity.Extension.Methods;
using VSoft.Company.URO.UserRole.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.URO.UserRole.Business.Provider.Services;

public class UserRoleMgmtBus : BusinessRepositoryService<UserRoleDto, IUserRoleRepository>, IUserRoleMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(UserRoleDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(UserRoleDto.UserId),
        
    };

    public UserRoleMgmtBus(IUserRoleRepository customerRepository) : base(customerRepository)
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

    public UserRoleFindDtoResponse Find(MDtoRequestFindByLong request)
    {
        return Find<MDtoRequestFindByLong, UserRoleFindDtoResponse, long>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<UserRoleFindDtoResponse> FindAsync(MDtoRequestFindByLong request)
    {
        return await FindAsync<MDtoRequestFindByLong, UserRoleFindDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MUserRoleEntity?>(null)))?.GetDto()
        );
    }

    public UserRoleFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request)
    {
        return FindRange<MDtoRequestFindRangeByLongs, UserRoleFindRangeDtoResponse, long>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<UserRoleFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByLongs, UserRoleFindRangeDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MUserRoleEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public UserRoleInsertDtoResponse Create(UserRoleInsertDtoRequest request)
    {
        return Create<UserRoleInsertDtoRequest, UserRoleInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MUserRoleEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<UserRoleInsertDtoResponse> CreateAsync(UserRoleInsertDtoRequest request)
    {
        return await CreateAsync<UserRoleInsertDtoRequest, UserRoleInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MUserRoleEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MUserRoleEntity?>(new MUserRoleEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public UserRoleInsertRangeDtoResponse CreateRange(UserRoleInsertRangeDtoRequest request)
    {
        return CreateRange<UserRoleInsertRangeDtoRequest, UserRoleInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MUserRoleEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<UserRoleInsertRangeDtoResponse> CreateRangeAsync(UserRoleInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<UserRoleInsertRangeDtoRequest, UserRoleInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MUserRoleEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MUserRoleEntity>?>(Array.Empty<MUserRoleEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public UserRoleUpdateDtoResponse Update(UserRoleUpdateDtoRequest request)
    {
        return Update<UserRoleUpdateDtoRequest, UserRoleUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MUserRoleEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<UserRoleUpdateDtoResponse> UpdateAsync(UserRoleUpdateDtoRequest request)
    {
        return await UpdateAsync<UserRoleUpdateDtoRequest, UserRoleUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MUserRoleEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MUserRoleEntity?>(new MUserRoleEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public UserRoleUpdateRangeDtoResponse UpdateRange(UserRoleUpdateRangeDtoRequest request)
    {
        return UpdateRange<UserRoleUpdateRangeDtoRequest, UserRoleUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MUserRoleEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<UserRoleUpdateRangeDtoResponse> UpdateRangeAsync(UserRoleUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<UserRoleUpdateRangeDtoRequest, UserRoleUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MUserRoleEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MUserRoleEntity>?>(Array.Empty<MUserRoleEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public UserRoleDeleteDtoResponse Delete(UserRoleDeleteDtoRequest request)
    {
        return Delete<UserRoleDeleteDtoRequest, UserRoleDeleteDtoResponse, long>
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

    public async Task<UserRoleDeleteDtoResponse> DeleteAsync(UserRoleDeleteDtoRequest request)
    {
        return await DeleteAsync<UserRoleDeleteDtoRequest, UserRoleDeleteDtoResponse, long>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MUserRoleEntity?>(new MUserRoleEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MUserRoleEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public UserRoleDeleteRangeDtoResponse DeleteRange(UserRoleDeleteRangeDtoRequest request)
    {
        return DeleteRange<UserRoleDeleteRangeDtoRequest, UserRoleDeleteRangeDtoResponse, long>
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

    public async Task<UserRoleDeleteRangeDtoResponse> DeleteRangeAsync(UserRoleDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<UserRoleDeleteRangeDtoRequest, UserRoleDeleteRangeDtoResponse, long>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MUserRoleEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MUserRoleEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<UserRoleSaveRangeDtoResponse> SaveRangeAsync(UserRoleSaveRangeDtoRequest request, Func<MSaveRangeParams<MUserRoleEntity>?, Task<MSaveRangeResults<MUserRoleEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new UserRoleSaveRangeDtoResponse()
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
                return new UserRoleSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new UserRoleSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MUserRoleEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MUserRoleEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MUserRoleEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MUserRoleEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new UserRoleSaveRangeDtoResponse()
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
            return new UserRoleSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<UserRoleSaveRangeDtoResponse> SaveRangeAsync(UserRoleSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MUserRoleEntity>?>(null));
    }

    public async Task<UserRoleSaveRangeDtoResponse> SaveRangeTransactionAsync(UserRoleSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MUserRoleEntity>?>(null));
    }
}

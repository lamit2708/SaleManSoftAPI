using VSoft.Company.USR.User.Business.Dto.Request;
using VSoft.Company.USR.User.Business.Dto.Response;
using VSoft.Company.USR.User.Business.Services;
using VSoft.Company.USR.User.Repository.Services;
using VSoft.Company.USR.User.Data.Entity.Models;
using VSoft.Company.USR.User.Business.Dto.Extension.Methods;
using VSoft.Company.USR.User.Business.entity.Extension.Methods;
using VSoft.Company.USR.User.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.USR.User.Business.Provider.Services;

public class UserMgmtBus : BusinessRepositoryService<UserDto, IUserRepository>, IUserMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(UserDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(UserDto.Name),
        
    };

    public UserMgmtBus(IUserRepository userRepository) : base(userRepository)
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

    public UserFindDtoResponse Find(MDtoRequestFindByInt request)
    {
        return Find<MDtoRequestFindByInt, UserFindDtoResponse, int>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<UserFindDtoResponse> FindAsync(MDtoRequestFindByInt request)
    {
        return await FindAsync<MDtoRequestFindByInt, UserFindDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MUserEntity?>(null)))?.GetDto()
        );
    }

    public UserFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request)
    {
        return FindRange<MDtoRequestFindRangeByInts, UserFindRangeDtoResponse, int>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<UserFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByInts, UserFindRangeDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MUserEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public UserInsertDtoResponse Create(UserInsertDtoRequest request)
    {
        return Create<UserInsertDtoRequest, UserInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MUserEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<UserInsertDtoResponse> CreateAsync(UserInsertDtoRequest request)
    {
        return await CreateAsync<UserInsertDtoRequest, UserInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MUserEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MUserEntity?>(new MUserEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public UserInsertRangeDtoResponse CreateRange(UserInsertRangeDtoRequest request)
    {
        return CreateRange<UserInsertRangeDtoRequest, UserInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MUserEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<UserInsertRangeDtoResponse> CreateRangeAsync(UserInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<UserInsertRangeDtoRequest, UserInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MUserEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MUserEntity>?>(Array.Empty<MUserEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public UserUpdateDtoResponse Update(UserUpdateDtoRequest request)
    {
        return Update<UserUpdateDtoRequest, UserUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MUserEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<UserUpdateDtoResponse> UpdateAsync(UserUpdateDtoRequest request)
    {
        return await UpdateAsync<UserUpdateDtoRequest, UserUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MUserEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MUserEntity?>(new MUserEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public UserUpdateRangeDtoResponse UpdateRange(UserUpdateRangeDtoRequest request)
    {
        return UpdateRange<UserUpdateRangeDtoRequest, UserUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MUserEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<UserUpdateRangeDtoResponse> UpdateRangeAsync(UserUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<UserUpdateRangeDtoRequest, UserUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MUserEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MUserEntity>?>(Array.Empty<MUserEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public UserDeleteDtoResponse Delete(UserDeleteDtoRequest request)
    {
        return Delete<UserDeleteDtoRequest, UserDeleteDtoResponse, int>
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

    public async Task<UserDeleteDtoResponse> DeleteAsync(UserDeleteDtoRequest request)
    {
        return await DeleteAsync<UserDeleteDtoRequest, UserDeleteDtoResponse, int>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MUserEntity?>(new MUserEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MUserEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public UserDeleteRangeDtoResponse DeleteRange(UserDeleteRangeDtoRequest request)
    {
        return DeleteRange<UserDeleteRangeDtoRequest, UserDeleteRangeDtoResponse, int>
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

    public async Task<UserDeleteRangeDtoResponse> DeleteRangeAsync(UserDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<UserDeleteRangeDtoRequest, UserDeleteRangeDtoResponse, int>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MUserEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MUserEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<UserSaveRangeDtoResponse> SaveRangeAsync(UserSaveRangeDtoRequest request, Func<MSaveRangeParams<MUserEntity>?, Task<MSaveRangeResults<MUserEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new UserSaveRangeDtoResponse()
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
                return new UserSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new UserSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MUserEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MUserEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MUserEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MUserEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new UserSaveRangeDtoResponse()
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
            return new UserSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<UserSaveRangeDtoResponse> SaveRangeAsync(UserSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MUserEntity>?>(null));
    }

    public async Task<UserSaveRangeDtoResponse> SaveRangeTransactionAsync(UserSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MUserEntity>?>(null));
    }

    public async Task<UserTableKeySearchDtoResponse> GetTableByKeySearch(UserTableKeySearchDtoRequest request)
    {
        var rsRespo = await Repository?.GetTableByKeySearchAsync(request.Data, request.PagingParams);
        var response = new UserTableKeySearchDtoResponse();
        if (rsRespo != null)
        {
            response.Data = rsRespo.Items.GetDto().ToArray();
            response.MetaData = rsRespo.MetaData;
            response.IsSuccess = true;
        };
        return response;
    }
}

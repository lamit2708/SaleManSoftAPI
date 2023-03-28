using VSoft.Company.UCU.UserCustomer.Business.Dto.Request;
using VSoft.Company.UCU.UserCustomer.Business.Dto.Response;
using VSoft.Company.UCU.UserCustomer.Business.Services;
using VSoft.Company.UCU.UserCustomer.Repository.Services;
using VSoft.Company.UCU.UserCustomer.Data.Entity.Models;
using VSoft.Company.UCU.UserCustomer.Business.Dto.Extension.Methods;
using VSoft.Company.UCU.UserCustomer.Business.entity.Extension.Methods;
using VSoft.Company.UCU.UserCustomer.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.UCU.UserCustomer.Business.Provider.Services;

public class UserCustomerMgmtBus : BusinessRepositoryService<UserCustomerDto, IUserCustomerRepository>, IUserCustomerMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(UserCustomerDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(UserCustomerDto.CustomerId),
        
    };

    public UserCustomerMgmtBus(IUserCustomerRepository customerRepository) : base(customerRepository)
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

    public UserCustomerFindDtoResponse Find(MDtoRequestFindByInt request)
    {
        return Find<MDtoRequestFindByInt, UserCustomerFindDtoResponse, int>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<UserCustomerFindDtoResponse> FindAsync(MDtoRequestFindByInt request)
    {
        return await FindAsync<MDtoRequestFindByInt, UserCustomerFindDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MUserCustomerEntity?>(null)))?.GetDto()
        );
    }

    public UserCustomerFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request)
    {
        return FindRange<MDtoRequestFindRangeByInts, UserCustomerFindRangeDtoResponse, int>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<UserCustomerFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByInts, UserCustomerFindRangeDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MUserCustomerEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public UserCustomerInsertDtoResponse Create(UserCustomerInsertDtoRequest request)
    {
        return Create<UserCustomerInsertDtoRequest, UserCustomerInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MUserCustomerEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<UserCustomerInsertDtoResponse> CreateAsync(UserCustomerInsertDtoRequest request)
    {
        return await CreateAsync<UserCustomerInsertDtoRequest, UserCustomerInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MUserCustomerEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MUserCustomerEntity?>(new MUserCustomerEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public UserCustomerInsertRangeDtoResponse CreateRange(UserCustomerInsertRangeDtoRequest request)
    {
        return CreateRange<UserCustomerInsertRangeDtoRequest, UserCustomerInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MUserCustomerEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<UserCustomerInsertRangeDtoResponse> CreateRangeAsync(UserCustomerInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<UserCustomerInsertRangeDtoRequest, UserCustomerInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MUserCustomerEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MUserCustomerEntity>?>(Array.Empty<MUserCustomerEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public UserCustomerUpdateDtoResponse Update(UserCustomerUpdateDtoRequest request)
    {
        return Update<UserCustomerUpdateDtoRequest, UserCustomerUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MUserCustomerEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<UserCustomerUpdateDtoResponse> UpdateAsync(UserCustomerUpdateDtoRequest request)
    {
        return await UpdateAsync<UserCustomerUpdateDtoRequest, UserCustomerUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MUserCustomerEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MUserCustomerEntity?>(new MUserCustomerEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public UserCustomerUpdateRangeDtoResponse UpdateRange(UserCustomerUpdateRangeDtoRequest request)
    {
        return UpdateRange<UserCustomerUpdateRangeDtoRequest, UserCustomerUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MUserCustomerEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<UserCustomerUpdateRangeDtoResponse> UpdateRangeAsync(UserCustomerUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<UserCustomerUpdateRangeDtoRequest, UserCustomerUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MUserCustomerEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MUserCustomerEntity>?>(Array.Empty<MUserCustomerEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public UserCustomerDeleteDtoResponse Delete(UserCustomerDeleteDtoRequest request)
    {
        return Delete<UserCustomerDeleteDtoRequest, UserCustomerDeleteDtoResponse, int>
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

    public async Task<UserCustomerDeleteDtoResponse> DeleteAsync(UserCustomerDeleteDtoRequest request)
    {
        return await DeleteAsync<UserCustomerDeleteDtoRequest, UserCustomerDeleteDtoResponse, int>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MUserCustomerEntity?>(new MUserCustomerEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MUserCustomerEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public UserCustomerDeleteRangeDtoResponse DeleteRange(UserCustomerDeleteRangeDtoRequest request)
    {
        return DeleteRange<UserCustomerDeleteRangeDtoRequest, UserCustomerDeleteRangeDtoResponse, int>
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

    public async Task<UserCustomerDeleteRangeDtoResponse> DeleteRangeAsync(UserCustomerDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<UserCustomerDeleteRangeDtoRequest, UserCustomerDeleteRangeDtoResponse, int>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MUserCustomerEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MUserCustomerEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<UserCustomerSaveRangeDtoResponse> SaveRangeAsync(UserCustomerSaveRangeDtoRequest request, Func<MSaveRangeParams<MUserCustomerEntity>?, Task<MSaveRangeResults<MUserCustomerEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new UserCustomerSaveRangeDtoResponse()
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
                return new UserCustomerSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new UserCustomerSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MUserCustomerEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MUserCustomerEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MUserCustomerEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MUserCustomerEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new UserCustomerSaveRangeDtoResponse()
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
            return new UserCustomerSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<UserCustomerSaveRangeDtoResponse> SaveRangeAsync(UserCustomerSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MUserCustomerEntity>?>(null));
    }

    public async Task<UserCustomerSaveRangeDtoResponse> SaveRangeTransactionAsync(UserCustomerSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MUserCustomerEntity>?>(null));
    }
}

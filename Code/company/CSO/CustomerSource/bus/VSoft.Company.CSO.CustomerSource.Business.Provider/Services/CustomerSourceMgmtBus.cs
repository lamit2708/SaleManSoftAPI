using VSoft.Company.CSO.CustomerSource.Business.Dto.Request;
using VSoft.Company.CSO.CustomerSource.Business.Dto.Response;
using VSoft.Company.CSO.CustomerSource.Business.Services;
using VSoft.Company.CSO.CustomerSource.Repository.Services;
using VSoft.Company.CSO.CustomerSource.Data.Entity.Models;
using VSoft.Company.CSO.CustomerSource.Business.Dto.Extension.Methods;
using VSoft.Company.CSO.CustomerSource.Business.entity.Extension.Methods;
using VSoft.Company.CSO.CustomerSource.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.CSO.CustomerSource.Business.Provider.Services;

public class CustomerSourceMgmtBus : BusinessRepositoryService<CustomerSourceDto, ICustomerSourceRepository>, ICustomerSourceMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(CustomerSourceDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(CustomerSourceDto.Name),
        
    };

    public CustomerSourceMgmtBus(ICustomerSourceRepository customerRepository) : base(customerRepository)
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

    public CustomerSourceFindDtoResponse Find(MDtoRequestFindByInt request)
    {
        return Find<MDtoRequestFindByInt, CustomerSourceFindDtoResponse, int>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<CustomerSourceFindDtoResponse> FindAsync(MDtoRequestFindByInt request)
    {
        return await FindAsync<MDtoRequestFindByInt, CustomerSourceFindDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MCustomerSourceEntity?>(null)))?.GetDto()
        );
    }

    public CustomerSourceFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request)
    {
        return FindRange<MDtoRequestFindRangeByInts, CustomerSourceFindRangeDtoResponse, int>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<CustomerSourceFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByInts, CustomerSourceFindRangeDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MCustomerSourceEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public CustomerSourceInsertDtoResponse Create(CustomerSourceInsertDtoRequest request)
    {
        return Create<CustomerSourceInsertDtoRequest, CustomerSourceInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MCustomerSourceEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<CustomerSourceInsertDtoResponse> CreateAsync(CustomerSourceInsertDtoRequest request)
    {
        return await CreateAsync<CustomerSourceInsertDtoRequest, CustomerSourceInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MCustomerSourceEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MCustomerSourceEntity?>(new MCustomerSourceEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public CustomerSourceInsertRangeDtoResponse CreateRange(CustomerSourceInsertRangeDtoRequest request)
    {
        return CreateRange<CustomerSourceInsertRangeDtoRequest, CustomerSourceInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MCustomerSourceEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<CustomerSourceInsertRangeDtoResponse> CreateRangeAsync(CustomerSourceInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<CustomerSourceInsertRangeDtoRequest, CustomerSourceInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MCustomerSourceEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MCustomerSourceEntity>?>(Array.Empty<MCustomerSourceEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public CustomerSourceUpdateDtoResponse Update(CustomerSourceUpdateDtoRequest request)
    {
        return Update<CustomerSourceUpdateDtoRequest, CustomerSourceUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MCustomerSourceEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<CustomerSourceUpdateDtoResponse> UpdateAsync(CustomerSourceUpdateDtoRequest request)
    {
        return await UpdateAsync<CustomerSourceUpdateDtoRequest, CustomerSourceUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MCustomerSourceEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MCustomerSourceEntity?>(new MCustomerSourceEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public CustomerSourceUpdateRangeDtoResponse UpdateRange(CustomerSourceUpdateRangeDtoRequest request)
    {
        return UpdateRange<CustomerSourceUpdateRangeDtoRequest, CustomerSourceUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MCustomerSourceEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<CustomerSourceUpdateRangeDtoResponse> UpdateRangeAsync(CustomerSourceUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<CustomerSourceUpdateRangeDtoRequest, CustomerSourceUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MCustomerSourceEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MCustomerSourceEntity>?>(Array.Empty<MCustomerSourceEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public CustomerSourceDeleteDtoResponse Delete(CustomerSourceDeleteDtoRequest request)
    {
        return Delete<CustomerSourceDeleteDtoRequest, CustomerSourceDeleteDtoResponse, long>
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

    public async Task<CustomerSourceDeleteDtoResponse> DeleteAsync(CustomerSourceDeleteDtoRequest request)
    {
        return await DeleteAsync<CustomerSourceDeleteDtoRequest, CustomerSourceDeleteDtoResponse, long>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MCustomerSourceEntity?>(new MCustomerSourceEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MCustomerSourceEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public CustomerSourceDeleteRangeDtoResponse DeleteRange(CustomerSourceDeleteRangeDtoRequest request)
    {
        return DeleteRange<CustomerSourceDeleteRangeDtoRequest, CustomerSourceDeleteRangeDtoResponse, int>
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

    public async Task<CustomerSourceDeleteRangeDtoResponse> DeleteRangeAsync(CustomerSourceDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<CustomerSourceDeleteRangeDtoRequest, CustomerSourceDeleteRangeDtoResponse, int>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MCustomerSourceEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MCustomerSourceEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<CustomerSourceSaveRangeDtoResponse> SaveRangeAsync(CustomerSourceSaveRangeDtoRequest request, Func<MSaveRangeParams<MCustomerSourceEntity>?, Task<MSaveRangeResults<MCustomerSourceEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new CustomerSourceSaveRangeDtoResponse()
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
                return new CustomerSourceSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new CustomerSourceSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MCustomerSourceEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MCustomerSourceEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MCustomerSourceEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MCustomerSourceEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new CustomerSourceSaveRangeDtoResponse()
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
            return new CustomerSourceSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<CustomerSourceSaveRangeDtoResponse> SaveRangeAsync(CustomerSourceSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MCustomerSourceEntity>?>(null));
    }

    public async Task<CustomerSourceSaveRangeDtoResponse> SaveRangeTransactionAsync(CustomerSourceSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MCustomerSourceEntity>?>(null));
    }
}

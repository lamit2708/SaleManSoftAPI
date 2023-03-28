using VSoft.Company.CTM.Customer.Business.Dto.Request;
using VSoft.Company.CTM.Customer.Business.Dto.Response;
using VSoft.Company.CTM.Customer.Business.Services;
using VSoft.Company.CTM.Customer.Repository.Services;
using VSoft.Company.CTM.Customer.Data.Entity.Models;
using VSoft.Company.CTM.Customer.Business.Dto.Extension.Methods;
using VSoft.Company.CTM.Customer.Business.entity.Extension.Methods;
using VSoft.Company.CTM.Customer.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.CTM.Customer.Business.Provider.Services;

public class CustomerMgmtBus : BusinessRepositoryService<CustomerDto, ICustomerRepository>, ICustomerMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(CustomerDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(CustomerDto.Name),
        
    };

    public CustomerMgmtBus(ICustomerRepository customerRepository) : base(customerRepository)
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

    public CustomerFindDtoResponse Find(MDtoRequestFindByLong request)
    {
        return Find<MDtoRequestFindByLong, CustomerFindDtoResponse, long>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<CustomerFindDtoResponse> FindAsync(MDtoRequestFindByLong request)
    {
        return await FindAsync<MDtoRequestFindByLong, CustomerFindDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MCustomerEntity?>(null)))?.GetDto()
        );
    }

    public CustomerFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request)
    {
        return FindRange<MDtoRequestFindRangeByLongs, CustomerFindRangeDtoResponse, long>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<CustomerFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByLongs, CustomerFindRangeDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MCustomerEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public CustomerInsertDtoResponse Create(CustomerInsertDtoRequest request)
    {
        return Create<CustomerInsertDtoRequest, CustomerInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MCustomerEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<CustomerInsertDtoResponse> CreateAsync(CustomerInsertDtoRequest request)
    {
        return await CreateAsync<CustomerInsertDtoRequest, CustomerInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MCustomerEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MCustomerEntity?>(new MCustomerEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public CustomerInsertRangeDtoResponse CreateRange(CustomerInsertRangeDtoRequest request)
    {
        return CreateRange<CustomerInsertRangeDtoRequest, CustomerInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MCustomerEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<CustomerInsertRangeDtoResponse> CreateRangeAsync(CustomerInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<CustomerInsertRangeDtoRequest, CustomerInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MCustomerEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MCustomerEntity>?>(Array.Empty<MCustomerEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public CustomerUpdateDtoResponse Update(CustomerUpdateDtoRequest request)
    {
        return Update<CustomerUpdateDtoRequest, CustomerUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MCustomerEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<CustomerUpdateDtoResponse> UpdateAsync(CustomerUpdateDtoRequest request)
    {
        return await UpdateAsync<CustomerUpdateDtoRequest, CustomerUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MCustomerEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MCustomerEntity?>(new MCustomerEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public CustomerUpdateRangeDtoResponse UpdateRange(CustomerUpdateRangeDtoRequest request)
    {
        return UpdateRange<CustomerUpdateRangeDtoRequest, CustomerUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MCustomerEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<CustomerUpdateRangeDtoResponse> UpdateRangeAsync(CustomerUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<CustomerUpdateRangeDtoRequest, CustomerUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MCustomerEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MCustomerEntity>?>(Array.Empty<MCustomerEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public CustomerDeleteDtoResponse Delete(CustomerDeleteDtoRequest request)
    {
        return Delete<CustomerDeleteDtoRequest, CustomerDeleteDtoResponse, long>
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

    public async Task<CustomerDeleteDtoResponse> DeleteAsync(CustomerDeleteDtoRequest request)
    {
        return await DeleteAsync<CustomerDeleteDtoRequest, CustomerDeleteDtoResponse, long>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MCustomerEntity?>(new MCustomerEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MCustomerEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public CustomerDeleteRangeDtoResponse DeleteRange(CustomerDeleteRangeDtoRequest request)
    {
        return DeleteRange<CustomerDeleteRangeDtoRequest, CustomerDeleteRangeDtoResponse, long>
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

    public async Task<CustomerDeleteRangeDtoResponse> DeleteRangeAsync(CustomerDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<CustomerDeleteRangeDtoRequest, CustomerDeleteRangeDtoResponse, long>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MCustomerEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MCustomerEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<CustomerSaveRangeDtoResponse> SaveRangeAsync(CustomerSaveRangeDtoRequest request, Func<MSaveRangeParams<MCustomerEntity>?, Task<MSaveRangeResults<MCustomerEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new CustomerSaveRangeDtoResponse()
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
                return new CustomerSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new CustomerSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MCustomerEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MCustomerEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MCustomerEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MCustomerEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new CustomerSaveRangeDtoResponse()
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
            return new CustomerSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<CustomerSaveRangeDtoResponse> SaveRangeAsync(CustomerSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MCustomerEntity>?>(null));
    }

    public async Task<CustomerSaveRangeDtoResponse> SaveRangeTransactionAsync(CustomerSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MCustomerEntity>?>(null));
    }
}

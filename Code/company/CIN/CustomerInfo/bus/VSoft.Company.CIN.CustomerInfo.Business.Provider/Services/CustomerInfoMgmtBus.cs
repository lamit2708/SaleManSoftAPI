using VSoft.Company.CIN.CustomerInfo.Business.Dto.Request;
using VSoft.Company.CIN.CustomerInfo.Business.Dto.Response;
using VSoft.Company.CIN.CustomerInfo.Business.Services;
using VSoft.Company.CIN.CustomerInfo.Repository.Services;
using VSoft.Company.CIN.CustomerInfo.Data.Entity.Models;
using VSoft.Company.CIN.CustomerInfo.Business.Dto.Extension.Methods;
using VSoft.Company.CIN.CustomerInfo.Business.entity.Extension.Methods;
using VSoft.Company.CIN.CustomerInfo.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.CIN.CustomerInfo.Business.Provider.Services;

public class CustomerInfoMgmtBus : BusinessRepositoryService<CustomerInfoDto, ICustomerInfoRepository>, ICustomerInfoMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(CustomerInfoDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(CustomerInfoDto.CustomerSourceId),
        
    };

    public CustomerInfoMgmtBus(ICustomerInfoRepository customerRepository) : base(customerRepository)
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

    public CustomerInfoFindDtoResponse Find(MDtoRequestFindByLong request)
    {
        return Find<MDtoRequestFindByLong, CustomerInfoFindDtoResponse, long>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<CustomerInfoFindDtoResponse> FindAsync(MDtoRequestFindByLong request)
    {
        return await FindAsync<MDtoRequestFindByLong, CustomerInfoFindDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MCustomerInfoEntity?>(null)))?.GetDto()
        );
    }

    public CustomerInfoFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request)
    {
        return FindRange<MDtoRequestFindRangeByLongs, CustomerInfoFindRangeDtoResponse, long>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<CustomerInfoFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByLongs, CustomerInfoFindRangeDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MCustomerInfoEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public CustomerInfoInsertDtoResponse Create(CustomerInfoInsertDtoRequest request)
    {
        return Create<CustomerInfoInsertDtoRequest, CustomerInfoInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MCustomerInfoEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<CustomerInfoInsertDtoResponse> CreateAsync(CustomerInfoInsertDtoRequest request)
    {
        return await CreateAsync<CustomerInfoInsertDtoRequest, CustomerInfoInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MCustomerInfoEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MCustomerInfoEntity?>(new MCustomerInfoEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public CustomerInfoInsertRangeDtoResponse CreateRange(CustomerInfoInsertRangeDtoRequest request)
    {
        return CreateRange<CustomerInfoInsertRangeDtoRequest, CustomerInfoInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MCustomerInfoEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<CustomerInfoInsertRangeDtoResponse> CreateRangeAsync(CustomerInfoInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<CustomerInfoInsertRangeDtoRequest, CustomerInfoInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MCustomerInfoEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MCustomerInfoEntity>?>(Array.Empty<MCustomerInfoEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public CustomerInfoUpdateDtoResponse Update(CustomerInfoUpdateDtoRequest request)
    {
        return Update<CustomerInfoUpdateDtoRequest, CustomerInfoUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MCustomerInfoEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<CustomerInfoUpdateDtoResponse> UpdateAsync(CustomerInfoUpdateDtoRequest request)
    {
        return await UpdateAsync<CustomerInfoUpdateDtoRequest, CustomerInfoUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MCustomerInfoEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MCustomerInfoEntity?>(new MCustomerInfoEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public CustomerInfoUpdateRangeDtoResponse UpdateRange(CustomerInfoUpdateRangeDtoRequest request)
    {
        return UpdateRange<CustomerInfoUpdateRangeDtoRequest, CustomerInfoUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MCustomerInfoEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<CustomerInfoUpdateRangeDtoResponse> UpdateRangeAsync(CustomerInfoUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<CustomerInfoUpdateRangeDtoRequest, CustomerInfoUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MCustomerInfoEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MCustomerInfoEntity>?>(Array.Empty<MCustomerInfoEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public CustomerInfoDeleteDtoResponse Delete(CustomerInfoDeleteDtoRequest request)
    {
        return Delete<CustomerInfoDeleteDtoRequest, CustomerInfoDeleteDtoResponse, long>
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

    public async Task<CustomerInfoDeleteDtoResponse> DeleteAsync(CustomerInfoDeleteDtoRequest request)
    {
        return await DeleteAsync<CustomerInfoDeleteDtoRequest, CustomerInfoDeleteDtoResponse, long>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MCustomerInfoEntity?>(new MCustomerInfoEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MCustomerInfoEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public CustomerInfoDeleteRangeDtoResponse DeleteRange(CustomerInfoDeleteRangeDtoRequest request)
    {
        return DeleteRange<CustomerInfoDeleteRangeDtoRequest, CustomerInfoDeleteRangeDtoResponse, long>
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

    public async Task<CustomerInfoDeleteRangeDtoResponse> DeleteRangeAsync(CustomerInfoDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<CustomerInfoDeleteRangeDtoRequest, CustomerInfoDeleteRangeDtoResponse, long>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MCustomerInfoEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MCustomerInfoEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<CustomerInfoSaveRangeDtoResponse> SaveRangeAsync(CustomerInfoSaveRangeDtoRequest request, Func<MSaveRangeParams<MCustomerInfoEntity>?, Task<MSaveRangeResults<MCustomerInfoEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new CustomerInfoSaveRangeDtoResponse()
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
                return new CustomerInfoSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new CustomerInfoSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MCustomerInfoEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MCustomerInfoEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MCustomerInfoEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MCustomerInfoEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new CustomerInfoSaveRangeDtoResponse()
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
            return new CustomerInfoSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<CustomerInfoSaveRangeDtoResponse> SaveRangeAsync(CustomerInfoSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MCustomerInfoEntity>?>(null));
    }

    public async Task<CustomerInfoSaveRangeDtoResponse> SaveRangeTransactionAsync(CustomerInfoSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MCustomerInfoEntity>?>(null));
    }
}

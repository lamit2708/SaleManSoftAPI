using VSoft.Company.POR.ProductOrder.Business.Dto.Request;
using VSoft.Company.POR.ProductOrder.Business.Dto.Response;
using VSoft.Company.POR.ProductOrder.Business.Services;
using VSoft.Company.POR.ProductOrder.Repository.Services;
using VSoft.Company.POR.ProductOrder.Data.Entity.Models;
using VSoft.Company.POR.ProductOrder.Business.Dto.Extension.Methods;
using VSoft.Company.POR.ProductOrder.Business.entity.Extension.Methods;
using VSoft.Company.POR.ProductOrder.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.POR.ProductOrder.Business.Provider.Services;

public class ProductOrderMgmtBus : BusinessRepositoryService<ProductOrderDto, IProductOrderRepository>, IProductOrderMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(ProductOrderDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(ProductOrderDto.OrderId),
        
    };

    public ProductOrderMgmtBus(IProductOrderRepository customerRepository) : base(customerRepository)
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

    public ProductOrderFindDtoResponse Find(MDtoRequestFindByInt request)
    {
        return Find<MDtoRequestFindByInt, ProductOrderFindDtoResponse, int>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<ProductOrderFindDtoResponse> FindAsync(MDtoRequestFindByInt request)
    {
        return await FindAsync<MDtoRequestFindByInt, ProductOrderFindDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MProductOrderEntity?>(null)))?.GetDto()
        );
    }

    public ProductOrderFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request)
    {
        return FindRange<MDtoRequestFindRangeByInts, ProductOrderFindRangeDtoResponse, int>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<ProductOrderFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByInts, ProductOrderFindRangeDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MProductOrderEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public ProductOrderInsertDtoResponse Create(ProductOrderInsertDtoRequest request)
    {
        return Create<ProductOrderInsertDtoRequest, ProductOrderInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MProductOrderEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<ProductOrderInsertDtoResponse> CreateAsync(ProductOrderInsertDtoRequest request)
    {
        return await CreateAsync<ProductOrderInsertDtoRequest, ProductOrderInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MProductOrderEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MProductOrderEntity?>(new MProductOrderEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public ProductOrderInsertRangeDtoResponse CreateRange(ProductOrderInsertRangeDtoRequest request)
    {
        return CreateRange<ProductOrderInsertRangeDtoRequest, ProductOrderInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MProductOrderEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<ProductOrderInsertRangeDtoResponse> CreateRangeAsync(ProductOrderInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<ProductOrderInsertRangeDtoRequest, ProductOrderInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MProductOrderEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MProductOrderEntity>?>(Array.Empty<MProductOrderEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public ProductOrderUpdateDtoResponse Update(ProductOrderUpdateDtoRequest request)
    {
        return Update<ProductOrderUpdateDtoRequest, ProductOrderUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MProductOrderEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<ProductOrderUpdateDtoResponse> UpdateAsync(ProductOrderUpdateDtoRequest request)
    {
        return await UpdateAsync<ProductOrderUpdateDtoRequest, ProductOrderUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MProductOrderEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MProductOrderEntity?>(new MProductOrderEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public ProductOrderUpdateRangeDtoResponse UpdateRange(ProductOrderUpdateRangeDtoRequest request)
    {
        return UpdateRange<ProductOrderUpdateRangeDtoRequest, ProductOrderUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MProductOrderEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<ProductOrderUpdateRangeDtoResponse> UpdateRangeAsync(ProductOrderUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<ProductOrderUpdateRangeDtoRequest, ProductOrderUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MProductOrderEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MProductOrderEntity>?>(Array.Empty<MProductOrderEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public ProductOrderDeleteDtoResponse Delete(ProductOrderDeleteDtoRequest request)
    {
        return Delete<ProductOrderDeleteDtoRequest, ProductOrderDeleteDtoResponse, long>
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

    public async Task<ProductOrderDeleteDtoResponse> DeleteAsync(ProductOrderDeleteDtoRequest request)
    {
        return await DeleteAsync<ProductOrderDeleteDtoRequest, ProductOrderDeleteDtoResponse, long>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MProductOrderEntity?>(new MProductOrderEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MProductOrderEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public ProductOrderDeleteRangeDtoResponse DeleteRange(ProductOrderDeleteRangeDtoRequest request)
    {
        return DeleteRange<ProductOrderDeleteRangeDtoRequest, ProductOrderDeleteRangeDtoResponse, int>
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

    public async Task<ProductOrderDeleteRangeDtoResponse> DeleteRangeAsync(ProductOrderDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<ProductOrderDeleteRangeDtoRequest, ProductOrderDeleteRangeDtoResponse, int>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MProductOrderEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MProductOrderEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<ProductOrderSaveRangeDtoResponse> SaveRangeAsync(ProductOrderSaveRangeDtoRequest request, Func<MSaveRangeParams<MProductOrderEntity>?, Task<MSaveRangeResults<MProductOrderEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new ProductOrderSaveRangeDtoResponse()
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
                return new ProductOrderSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new ProductOrderSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MProductOrderEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MProductOrderEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MProductOrderEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MProductOrderEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new ProductOrderSaveRangeDtoResponse()
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
            return new ProductOrderSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<ProductOrderSaveRangeDtoResponse> SaveRangeAsync(ProductOrderSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MProductOrderEntity>?>(null));
    }

    public async Task<ProductOrderSaveRangeDtoResponse> SaveRangeTransactionAsync(ProductOrderSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MProductOrderEntity>?>(null));
    }
}

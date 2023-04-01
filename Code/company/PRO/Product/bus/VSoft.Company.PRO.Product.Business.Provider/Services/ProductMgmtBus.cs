using VSoft.Company.PRO.Product.Business.Dto.Request;
using VSoft.Company.PRO.Product.Business.Dto.Response;
using VSoft.Company.PRO.Product.Business.Services;
using VSoft.Company.PRO.Product.Repository.Services;
using VSoft.Company.PRO.Product.Data.Entity.Models;
using VSoft.Company.PRO.Product.Business.Dto.Extension.Methods;
using VSoft.Company.PRO.Product.Business.entity.Extension.Methods;
using VSoft.Company.PRO.Product.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.PRO.Product.Business.Provider.Services;

public class ProductMgmtBus : BusinessRepositoryService<ProductDto, IProductRepository>, IProductMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(ProductDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(ProductDto.Name),
        
    };

    public ProductMgmtBus(IProductRepository customerRepository) : base(customerRepository)
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

    public ProductFindDtoResponse Find(MDtoRequestFindByInt request)
    {
        return Find<MDtoRequestFindByInt, ProductFindDtoResponse, int>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<ProductFindDtoResponse> FindAsync(MDtoRequestFindByInt request)
    {
        return await FindAsync<MDtoRequestFindByInt, ProductFindDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MProductEntity?>(null)))?.GetDto()
        );
    }

    public ProductFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request)
    {
        return FindRange<MDtoRequestFindRangeByInts, ProductFindRangeDtoResponse, int>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<ProductFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByInts, ProductFindRangeDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MProductEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public ProductInsertDtoResponse Create(ProductInsertDtoRequest request)
    {
        return Create<ProductInsertDtoRequest, ProductInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MProductEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<ProductInsertDtoResponse> CreateAsync(ProductInsertDtoRequest request)
    {
        return await CreateAsync<ProductInsertDtoRequest, ProductInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MProductEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MProductEntity?>(new MProductEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public ProductInsertRangeDtoResponse CreateRange(ProductInsertRangeDtoRequest request)
    {
        return CreateRange<ProductInsertRangeDtoRequest, ProductInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MProductEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<ProductInsertRangeDtoResponse> CreateRangeAsync(ProductInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<ProductInsertRangeDtoRequest, ProductInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MProductEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MProductEntity>?>(Array.Empty<MProductEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public ProductUpdateDtoResponse Update(ProductUpdateDtoRequest request)
    {
        return Update<ProductUpdateDtoRequest, ProductUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MProductEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<ProductUpdateDtoResponse> UpdateAsync(ProductUpdateDtoRequest request)
    {
        return await UpdateAsync<ProductUpdateDtoRequest, ProductUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MProductEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MProductEntity?>(new MProductEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public ProductUpdateRangeDtoResponse UpdateRange(ProductUpdateRangeDtoRequest request)
    {
        return UpdateRange<ProductUpdateRangeDtoRequest, ProductUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MProductEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<ProductUpdateRangeDtoResponse> UpdateRangeAsync(ProductUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<ProductUpdateRangeDtoRequest, ProductUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MProductEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MProductEntity>?>(Array.Empty<MProductEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public ProductDeleteDtoResponse Delete(ProductDeleteDtoRequest request)
    {
        return Delete<ProductDeleteDtoRequest, ProductDeleteDtoResponse, int>
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

    public async Task<ProductDeleteDtoResponse> DeleteAsync(ProductDeleteDtoRequest request)
    {
        return await DeleteAsync<ProductDeleteDtoRequest, ProductDeleteDtoResponse, int>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MProductEntity?>(new MProductEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MProductEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public ProductDeleteRangeDtoResponse DeleteRange(ProductDeleteRangeDtoRequest request)
    {
        return DeleteRange<ProductDeleteRangeDtoRequest, ProductDeleteRangeDtoResponse, int>
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

    public async Task<ProductDeleteRangeDtoResponse> DeleteRangeAsync(ProductDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<ProductDeleteRangeDtoRequest, ProductDeleteRangeDtoResponse, int>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MProductEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MProductEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<ProductSaveRangeDtoResponse> SaveRangeAsync(ProductSaveRangeDtoRequest request, Func<MSaveRangeParams<MProductEntity>?, Task<MSaveRangeResults<MProductEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new ProductSaveRangeDtoResponse()
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
                return new ProductSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new ProductSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MProductEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MProductEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MProductEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MProductEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new ProductSaveRangeDtoResponse()
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
            return new ProductSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<ProductSaveRangeDtoResponse> SaveRangeAsync(ProductSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MProductEntity>?>(null));
    }

    public async Task<ProductSaveRangeDtoResponse> SaveRangeTransactionAsync(ProductSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MProductEntity>?>(null));
    }
}

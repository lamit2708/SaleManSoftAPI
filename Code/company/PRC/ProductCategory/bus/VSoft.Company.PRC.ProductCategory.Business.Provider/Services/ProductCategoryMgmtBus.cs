using VSoft.Company.PRC.ProductCategory.Business.Dto.Request;
using VSoft.Company.PRC.ProductCategory.Business.Dto.Response;
using VSoft.Company.PRC.ProductCategory.Business.Services;
using VSoft.Company.PRC.ProductCategory.Repository.Services;
using VSoft.Company.PRC.ProductCategory.Data.Entity.Models;
using VSoft.Company.PRC.ProductCategory.Business.Dto.Extension.Methods;
using VSoft.Company.PRC.ProductCategory.Business.entity.Extension.Methods;
using VSoft.Company.PRC.ProductCategory.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.PRC.ProductCategory.Business.Provider.Services;

public class ProductCategoryMgmtBus : BusinessRepositoryService<ProductCategoryDto, IProductCategoryRepository>, IProductCategoryMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(ProductCategoryDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(ProductCategoryDto.Name),

    };

    public ProductCategoryMgmtBus(IProductCategoryRepository productCategoryRepository) : base(productCategoryRepository)
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

    public ProductCategoryFindDtoResponse Find(MDtoRequestFindByInt request)
    {
        return Find<MDtoRequestFindByInt, ProductCategoryFindDtoResponse, int>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<ProductCategoryFindDtoResponse> FindAsync(MDtoRequestFindByInt request)
    {
        return await FindAsync<MDtoRequestFindByInt, ProductCategoryFindDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MProductCategoryEntity?>(null)))?.GetDto()
        );
    }

    public ProductCategoryFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request)
    {
        return FindRange<MDtoRequestFindRangeByInts, ProductCategoryFindRangeDtoResponse, int>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<ProductCategoryFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByInts, ProductCategoryFindRangeDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MProductCategoryEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public ProductCategoryInsertDtoResponse Create(ProductCategoryInsertDtoRequest request)
    {
        return Create<ProductCategoryInsertDtoRequest, ProductCategoryInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MProductCategoryEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<ProductCategoryInsertDtoResponse> CreateAsync(ProductCategoryInsertDtoRequest request)
    {
        return await CreateAsync<ProductCategoryInsertDtoRequest, ProductCategoryInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MProductCategoryEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MProductCategoryEntity?>(new MProductCategoryEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public ProductCategoryInsertRangeDtoResponse CreateRange(ProductCategoryInsertRangeDtoRequest request)
    {
        return CreateRange<ProductCategoryInsertRangeDtoRequest, ProductCategoryInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MProductCategoryEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<ProductCategoryInsertRangeDtoResponse> CreateRangeAsync(ProductCategoryInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<ProductCategoryInsertRangeDtoRequest, ProductCategoryInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MProductCategoryEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MProductCategoryEntity>?>(Array.Empty<MProductCategoryEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public ProductCategoryUpdateDtoResponse Update(ProductCategoryUpdateDtoRequest request)
    {
        return Update<ProductCategoryUpdateDtoRequest, ProductCategoryUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MProductCategoryEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<ProductCategoryUpdateDtoResponse> UpdateAsync(ProductCategoryUpdateDtoRequest request)
    {
        return await UpdateAsync<ProductCategoryUpdateDtoRequest, ProductCategoryUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MProductCategoryEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MProductCategoryEntity?>(new MProductCategoryEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public ProductCategoryUpdateRangeDtoResponse UpdateRange(ProductCategoryUpdateRangeDtoRequest request)
    {
        return UpdateRange<ProductCategoryUpdateRangeDtoRequest, ProductCategoryUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MProductCategoryEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<ProductCategoryUpdateRangeDtoResponse> UpdateRangeAsync(ProductCategoryUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<ProductCategoryUpdateRangeDtoRequest, ProductCategoryUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MProductCategoryEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MProductCategoryEntity>?>(Array.Empty<MProductCategoryEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public ProductCategoryDeleteDtoResponse Delete(ProductCategoryDeleteDtoRequest request)
    {
        return Delete<ProductCategoryDeleteDtoRequest, ProductCategoryDeleteDtoResponse, int>
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

    public async Task<ProductCategoryDeleteDtoResponse> DeleteAsync(ProductCategoryDeleteDtoRequest request)
    {
        return await DeleteAsync<ProductCategoryDeleteDtoRequest, ProductCategoryDeleteDtoResponse, int>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MProductCategoryEntity?>(new MProductCategoryEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MProductCategoryEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public ProductCategoryDeleteRangeDtoResponse DeleteRange(ProductCategoryDeleteRangeDtoRequest request)
    {
        return DeleteRange<ProductCategoryDeleteRangeDtoRequest, ProductCategoryDeleteRangeDtoResponse, int>
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

    public async Task<ProductCategoryDeleteRangeDtoResponse> DeleteRangeAsync(ProductCategoryDeleteRangeDtoRequest request)
    {
        return await DeleteRangeAsync<ProductCategoryDeleteRangeDtoRequest, ProductCategoryDeleteRangeDtoResponse, int>
        (
             request,
             async (ids) =>
             {
                 var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MProductCategoryEntity>?>(null));
                 var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MProductCategoryEntity>?>(null));
                 return resultEntities?.Select(e => e.GetDto()).ToArray();
             }
        );
    }


    protected async Task<ProductCategorySaveRangeDtoResponse> SaveRangeAsync(ProductCategorySaveRangeDtoRequest request, Func<MSaveRangeParams<MProductCategoryEntity>?, Task<MSaveRangeResults<MProductCategoryEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new ProductCategorySaveRangeDtoResponse()
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
                return new ProductCategorySaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new ProductCategorySaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MProductCategoryEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MProductCategoryEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MProductCategoryEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MProductCategoryEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new ProductCategorySaveRangeDtoResponse()
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
            return new ProductCategorySaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<ProductCategorySaveRangeDtoResponse> SaveRangeAsync(ProductCategorySaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MProductCategoryEntity>?>(null));
    }

    public async Task<ProductCategorySaveRangeDtoResponse> SaveRangeTransactionAsync(ProductCategorySaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MProductCategoryEntity>?>(null));
    }

    public async Task<ProductCategoryTableKeySearchDtoResponse> GetTableByKeySearch(ProductCategoryTableKeySearchDtoRequest request)
    {
        var rsRespo = await Repository?.GetTableByKeySearchAsync(request.Data, request.PagingParams);
        var response = new ProductCategoryTableKeySearchDtoResponse();
        if (rsRespo != null)
        {
            response.Data = rsRespo.Items.GetDto().ToArray();
            response.MetaData = rsRespo.MetaData;
            response.IsSuccess = true;
        };
        return response;
    }

    public async Task<ProductCategoryFindRangeDtoResponse> GetAll()
    {
        var rsRespo = Repository?.GetAll()?.ToList();
        var response = new ProductCategoryFindRangeDtoResponse();
        if (rsRespo != null)
        {
            response.Data = rsRespo.GetDto().ToArray();
            response.Total = rsRespo.Count;
            response.IsSuccess = true;
        };
        return response;
    }
}

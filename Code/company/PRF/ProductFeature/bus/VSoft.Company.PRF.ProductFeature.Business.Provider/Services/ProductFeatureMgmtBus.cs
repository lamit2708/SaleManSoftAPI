using VSoft.Company.PRF.ProductFeature.Business.Dto.Request;
using VSoft.Company.PRF.ProductFeature.Business.Dto.Response;
using VSoft.Company.PRF.ProductFeature.Business.Services;
using VSoft.Company.PRF.ProductFeature.Repository.Services;
using VSoft.Company.PRF.ProductFeature.Data.Entity.Models;
using VSoft.Company.PRF.ProductFeature.Business.Dto.Extension.Methods;
using VSoft.Company.PRF.ProductFeature.Business.entity.Extension.Methods;
using VSoft.Company.PRF.ProductFeature.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VegunSoft.Framework.Paging.Provider.Response;
using VegunSoft.Framework.Paging.Provider.Request;
using VSoft.Company.PRF.ProductFeature.Business.entity.Extension.Methods;

namespace VSoft.Company.PRF.ProductFeature.Business.Provider.Services;

public class ProductFeatureMgmtBus : BusinessRepositoryService<ProductFeatureDto, IProductFeatureRepository>, IProductFeatureMgmtBus
{
    protected override string? ContextName { get; set; } = nameof(ProductFeatureDto);

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(ProductFeatureDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(ProductFeatureDto.Name),

    };

    public ProductFeatureMgmtBus(IProductFeatureRepository customerRepository) : base(customerRepository)
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

    public ProductFeatureFindDtoResponse Find(MDtoRequestFindByInt request)
    {
        return Find<MDtoRequestFindByInt, ProductFeatureFindDtoResponse, int>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<ProductFeatureFindDtoResponse> FindAsync(MDtoRequestFindByInt request)
    {
        return await FindAsync<MDtoRequestFindByInt, ProductFeatureFindDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MProductFeatureEntity?>(null)))?.GetDto()
        );
    }

    public ProductFeatureFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request)
    {
        return FindRange<MDtoRequestFindRangeByInts, ProductFeatureFindRangeDtoResponse, int>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<ProductFeatureFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByInts, ProductFeatureFindRangeDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MProductFeatureEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public ProductFeatureInsertDtoResponse Create(ProductFeatureInsertDtoRequest request)
    {
        return Create<ProductFeatureInsertDtoRequest, ProductFeatureInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MProductFeatureEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<ProductFeatureInsertDtoResponse> CreateAsync(ProductFeatureInsertDtoRequest request)
    {
        return await CreateAsync<ProductFeatureInsertDtoRequest, ProductFeatureInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MProductFeatureEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MProductFeatureEntity?>(new MProductFeatureEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public ProductFeatureInsertRangeDtoResponse CreateRange(ProductFeatureInsertRangeDtoRequest request)
    {
        return CreateRange<ProductFeatureInsertRangeDtoRequest, ProductFeatureInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MProductFeatureEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<ProductFeatureInsertRangeDtoResponse> CreateRangeAsync(ProductFeatureInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<ProductFeatureInsertRangeDtoRequest, ProductFeatureInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MProductFeatureEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MProductFeatureEntity>?>(Array.Empty<MProductFeatureEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public ProductFeatureUpdateDtoResponse Update(ProductFeatureUpdateDtoRequest request)
    {
        return Update<ProductFeatureUpdateDtoRequest, ProductFeatureUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MProductFeatureEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<ProductFeatureUpdateDtoResponse> UpdateAsync(ProductFeatureUpdateDtoRequest request)
    {
        return await UpdateAsync<ProductFeatureUpdateDtoRequest, ProductFeatureUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MProductFeatureEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MProductFeatureEntity?>(new MProductFeatureEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public ProductFeatureUpdateRangeDtoResponse UpdateRange(ProductFeatureUpdateRangeDtoRequest request)
    {
        return UpdateRange<ProductFeatureUpdateRangeDtoRequest, ProductFeatureUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MProductFeatureEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<ProductFeatureUpdateRangeDtoResponse> UpdateRangeAsync(ProductFeatureUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<ProductFeatureUpdateRangeDtoRequest, ProductFeatureUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MProductFeatureEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MProductFeatureEntity>?>(Array.Empty<MProductFeatureEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public ProductFeatureDeleteDtoResponse Delete(ProductFeatureDeleteDtoRequest request)
    {
        return Delete<ProductFeatureDeleteDtoRequest, ProductFeatureDeleteDtoResponse, int>
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

    public async Task<ProductFeatureDeleteDtoResponse> DeleteAsync(ProductFeatureDeleteDtoRequest request)
    {
        return await DeleteAsync<ProductFeatureDeleteDtoRequest, ProductFeatureDeleteDtoResponse, int>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MProductFeatureEntity?>(new MProductFeatureEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MProductFeatureEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public ProductFeatureDeleteRangeDtoResponse DeleteRange(ProductFeatureDeleteRangeDtoRequest request)
    {
        return DeleteRange<ProductFeatureDeleteRangeDtoRequest, ProductFeatureDeleteRangeDtoResponse, int>
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

    public async Task<ProductFeatureDeleteRangeDtoResponse> DeleteRangeAsync(ProductFeatureDeleteRangeDtoRequest request)
    {
        return await DeleteRangeAsync<ProductFeatureDeleteRangeDtoRequest, ProductFeatureDeleteRangeDtoResponse, int>
        (
             request,
             async (ids) =>
             {
                 var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MProductFeatureEntity>?>(null));
                 var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MProductFeatureEntity>?>(null));
                 return resultEntities?.Select(e => e.GetDto()).ToArray();
             }
        );
    }


    protected async Task<ProductFeatureSaveRangeDtoResponse> SaveRangeAsync(ProductFeatureSaveRangeDtoRequest request, Func<MSaveRangeParams<MProductFeatureEntity>?, Task<MSaveRangeResults<MProductFeatureEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new ProductFeatureSaveRangeDtoResponse()
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
                return new ProductFeatureSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new ProductFeatureSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MProductFeatureEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MProductFeatureEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MProductFeatureEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MProductFeatureEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new ProductFeatureSaveRangeDtoResponse()
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
            return new ProductFeatureSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<ProductFeatureSaveRangeDtoResponse> SaveRangeAsync(ProductFeatureSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MProductFeatureEntity>?>(null));
    }

    public async Task<ProductFeatureSaveRangeDtoResponse> SaveRangeTransactionAsync(ProductFeatureSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MProductFeatureEntity>?>(null));
    }

    public async Task<ProductFeatureTableKeySearchDtoResponse> GetTableByKeySearch(ProductFeatureTableKeySearchDtoRequest request)
    {
        var rsRespo = await Repository?.GetTableByKeySearchAsync(request.Data, request.PagingParams);
        var response = new ProductFeatureTableKeySearchDtoResponse();
        if (rsRespo != null)
        {
            response.Data = rsRespo.Items.GetDto().ToArray();
            response.MetaData = rsRespo.MetaData;
            response.IsSuccess = true;
        };
        return response;
    }

    public async Task<ProductFeatureKeyValueResponse> GetAll()
    {
        var rsRespo = Repository?.GetAll()?.ToList();
        var rs = rsRespo.Select(x => new KeyValuePair<int, string>(x.Id, x.Name)).ToArray();

        var response = new ProductFeatureKeyValueResponse();
        if (rsRespo != null)
        {
            response.Data = rs;
            response.Total = rsRespo.Count;
            response.IsSuccess = true;
        };
        return response;
    }
}

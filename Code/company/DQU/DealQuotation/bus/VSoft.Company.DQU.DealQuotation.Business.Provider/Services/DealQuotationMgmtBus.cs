using VSoft.Company.DQU.DealQuotation.Business.Dto.Request;
using VSoft.Company.DQU.DealQuotation.Business.Dto.Response;
using VSoft.Company.DQU.DealQuotation.Business.Services;
using VSoft.Company.DQU.DealQuotation.Repository.Services;
using VSoft.Company.DQU.DealQuotation.Data.Entity.Models;
using VSoft.Company.DQU.DealQuotation.Business.Dto.Extension.Methods;
using VSoft.Company.DQU.DealQuotation.Business.entity.Extension.Methods;
using VSoft.Company.DQU.DealQuotation.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.DQU.DealQuotation.Business.Provider.Services;

public class DealQuotationMgmtBus : BusinessRepositoryService<DealQuotationDto, IDealQuotationRepository>, IDealQuotationMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(DealQuotationDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(DealQuotationDto.DealId),
        
    };

    public DealQuotationMgmtBus(IDealQuotationRepository customerRepository) : base(customerRepository)
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

    public DealQuotationFindDtoResponse Find(MDtoRequestFindByLong request)
    {
        return Find<MDtoRequestFindByLong, DealQuotationFindDtoResponse, long>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<DealQuotationFindDtoResponse> FindAsync(MDtoRequestFindByLong request)
    {
        return await FindAsync<MDtoRequestFindByLong, DealQuotationFindDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MDealQuotationEntity?>(null)))?.GetDto()
        );
    }

    public DealQuotationFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request)
    {
        return FindRange<MDtoRequestFindRangeByLongs, DealQuotationFindRangeDtoResponse, long>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<DealQuotationFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByLongs, DealQuotationFindRangeDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MDealQuotationEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public DealQuotationInsertDtoResponse Create(DealQuotationInsertDtoRequest request)
    {
        return Create<DealQuotationInsertDtoRequest, DealQuotationInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MDealQuotationEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<DealQuotationInsertDtoResponse> CreateAsync(DealQuotationInsertDtoRequest request)
    {
        return await CreateAsync<DealQuotationInsertDtoRequest, DealQuotationInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MDealQuotationEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MDealQuotationEntity?>(new MDealQuotationEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public DealQuotationInsertRangeDtoResponse CreateRange(DealQuotationInsertRangeDtoRequest request)
    {
        return CreateRange<DealQuotationInsertRangeDtoRequest, DealQuotationInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MDealQuotationEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<DealQuotationInsertRangeDtoResponse> CreateRangeAsync(DealQuotationInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<DealQuotationInsertRangeDtoRequest, DealQuotationInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MDealQuotationEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MDealQuotationEntity>?>(Array.Empty<MDealQuotationEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public DealQuotationUpdateDtoResponse Update(DealQuotationUpdateDtoRequest request)
    {
        return Update<DealQuotationUpdateDtoRequest, DealQuotationUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MDealQuotationEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<DealQuotationUpdateDtoResponse> UpdateAsync(DealQuotationUpdateDtoRequest request)
    {
        return await UpdateAsync<DealQuotationUpdateDtoRequest, DealQuotationUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MDealQuotationEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MDealQuotationEntity?>(new MDealQuotationEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public DealQuotationUpdateRangeDtoResponse UpdateRange(DealQuotationUpdateRangeDtoRequest request)
    {
        return UpdateRange<DealQuotationUpdateRangeDtoRequest, DealQuotationUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MDealQuotationEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<DealQuotationUpdateRangeDtoResponse> UpdateRangeAsync(DealQuotationUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<DealQuotationUpdateRangeDtoRequest, DealQuotationUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MDealQuotationEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MDealQuotationEntity>?>(Array.Empty<MDealQuotationEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public DealQuotationDeleteDtoResponse Delete(DealQuotationDeleteDtoRequest request)
    {
        return Delete<DealQuotationDeleteDtoRequest, DealQuotationDeleteDtoResponse, long>
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

    public async Task<DealQuotationDeleteDtoResponse> DeleteAsync(DealQuotationDeleteDtoRequest request)
    {
        return await DeleteAsync<DealQuotationDeleteDtoRequest, DealQuotationDeleteDtoResponse, long>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MDealQuotationEntity?>(new MDealQuotationEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MDealQuotationEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public DealQuotationDeleteRangeDtoResponse DeleteRange(DealQuotationDeleteRangeDtoRequest request)
    {
        return DeleteRange<DealQuotationDeleteRangeDtoRequest, DealQuotationDeleteRangeDtoResponse, long>
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

    public async Task<DealQuotationDeleteRangeDtoResponse> DeleteRangeAsync(DealQuotationDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<DealQuotationDeleteRangeDtoRequest, DealQuotationDeleteRangeDtoResponse, long>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MDealQuotationEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MDealQuotationEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<DealQuotationSaveRangeDtoResponse> SaveRangeAsync(DealQuotationSaveRangeDtoRequest request, Func<MSaveRangeParams<MDealQuotationEntity>?, Task<MSaveRangeResults<MDealQuotationEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new DealQuotationSaveRangeDtoResponse()
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
                return new DealQuotationSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new DealQuotationSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MDealQuotationEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MDealQuotationEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MDealQuotationEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MDealQuotationEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new DealQuotationSaveRangeDtoResponse()
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
            return new DealQuotationSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<DealQuotationSaveRangeDtoResponse> SaveRangeAsync(DealQuotationSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MDealQuotationEntity>?>(null));
    }

    public async Task<DealQuotationSaveRangeDtoResponse> SaveRangeTransactionAsync(DealQuotationSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MDealQuotationEntity>?>(null));
    }
}

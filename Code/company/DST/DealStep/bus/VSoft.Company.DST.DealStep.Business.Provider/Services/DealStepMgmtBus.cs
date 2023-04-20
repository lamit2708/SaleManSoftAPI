using VSoft.Company.DST.DealStep.Business.Dto.Request;
using VSoft.Company.DST.DealStep.Business.Dto.Response;
using VSoft.Company.DST.DealStep.Business.Services;
using VSoft.Company.DST.DealStep.Repository.Services;
using VSoft.Company.DST.DealStep.Data.Entity.Models;
using VSoft.Company.DST.DealStep.Business.Dto.Extension.Methods;
using VSoft.Company.DST.DealStep.Business.entity.Extension.Methods;
using VSoft.Company.DST.DealStep.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.DST.DealStep.Business.Provider.Services;

public class DealStepMgmtBus : BusinessRepositoryService<DealStepDto, IDealStepRepository>, IDealStepMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(DealStepDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(DealStepDto.Name),
        
    };

    public DealStepMgmtBus(IDealStepRepository customerRepository) : base(customerRepository)
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

    public DealStepFindDtoResponse Find(MDtoRequestFindByInt request)
    {
        return Find<MDtoRequestFindByInt, DealStepFindDtoResponse, int>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<DealStepFindDtoResponse> FindAsync(MDtoRequestFindByInt request)
    {
        return await FindAsync<MDtoRequestFindByInt, DealStepFindDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MDealStepEntity?>(null)))?.GetDto()
        );
    }

    public DealStepFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request)
    {
        return FindRange<MDtoRequestFindRangeByInts, DealStepFindRangeDtoResponse, int>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<DealStepFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByInts, DealStepFindRangeDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MDealStepEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public DealStepInsertDtoResponse Create(DealStepInsertDtoRequest request)
    {
        return Create<DealStepInsertDtoRequest, DealStepInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MDealStepEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<DealStepInsertDtoResponse> CreateAsync(DealStepInsertDtoRequest request)
    {
        return await CreateAsync<DealStepInsertDtoRequest, DealStepInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MDealStepEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MDealStepEntity?>(new MDealStepEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public DealStepInsertRangeDtoResponse CreateRange(DealStepInsertRangeDtoRequest request)
    {
        return CreateRange<DealStepInsertRangeDtoRequest, DealStepInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MDealStepEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<DealStepInsertRangeDtoResponse> CreateRangeAsync(DealStepInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<DealStepInsertRangeDtoRequest, DealStepInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MDealStepEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MDealStepEntity>?>(Array.Empty<MDealStepEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public DealStepUpdateDtoResponse Update(DealStepUpdateDtoRequest request)
    {
        return Update<DealStepUpdateDtoRequest, DealStepUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MDealStepEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<DealStepUpdateDtoResponse> UpdateAsync(DealStepUpdateDtoRequest request)
    {
        return await UpdateAsync<DealStepUpdateDtoRequest, DealStepUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MDealStepEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MDealStepEntity?>(new MDealStepEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public DealStepUpdateRangeDtoResponse UpdateRange(DealStepUpdateRangeDtoRequest request)
    {
        return UpdateRange<DealStepUpdateRangeDtoRequest, DealStepUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MDealStepEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<DealStepUpdateRangeDtoResponse> UpdateRangeAsync(DealStepUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<DealStepUpdateRangeDtoRequest, DealStepUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MDealStepEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MDealStepEntity>?>(Array.Empty<MDealStepEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public DealStepDeleteDtoResponse Delete(DealStepDeleteDtoRequest request)
    {
        return Delete<DealStepDeleteDtoRequest, DealStepDeleteDtoResponse, long>
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

    public async Task<DealStepDeleteDtoResponse> DeleteAsync(DealStepDeleteDtoRequest request)
    {
        return await DeleteAsync<DealStepDeleteDtoRequest, DealStepDeleteDtoResponse, long>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MDealStepEntity?>(new MDealStepEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MDealStepEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public DealStepDeleteRangeDtoResponse DeleteRange(DealStepDeleteRangeDtoRequest request)
    {
        return DeleteRange<DealStepDeleteRangeDtoRequest, DealStepDeleteRangeDtoResponse, int>
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

    public async Task<DealStepDeleteRangeDtoResponse> DeleteRangeAsync(DealStepDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<DealStepDeleteRangeDtoRequest, DealStepDeleteRangeDtoResponse, int>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MDealStepEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MDealStepEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<DealStepSaveRangeDtoResponse> SaveRangeAsync(DealStepSaveRangeDtoRequest request, Func<MSaveRangeParams<MDealStepEntity>?, Task<MSaveRangeResults<MDealStepEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new DealStepSaveRangeDtoResponse()
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
                return new DealStepSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new DealStepSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MDealStepEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MDealStepEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MDealStepEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MDealStepEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new DealStepSaveRangeDtoResponse()
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
            return new DealStepSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<DealStepSaveRangeDtoResponse> SaveRangeAsync(DealStepSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MDealStepEntity>?>(null));
    }

    public async Task<DealStepSaveRangeDtoResponse> SaveRangeTransactionAsync(DealStepSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MDealStepEntity>?>(null));
    }

    public async Task<DealStepFindRangeDtoResponse> GetAll()
    {
        var rsRespo = Repository?.GetAll()?.ToList();
        var response = new DealStepFindRangeDtoResponse();
        if (rsRespo != null)
        {
            response.Data = rsRespo.GetDto().ToArray();
            response.Total = rsRespo.Count;
            response.IsSuccess = true;
        };
        return response;
    }
}

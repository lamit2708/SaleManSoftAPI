using VSoft.Company.TIC.Ticket.Business.Dto.Request;
using VSoft.Company.TIC.Ticket.Business.Dto.Response;
using VSoft.Company.TIC.Ticket.Business.Services;
using VSoft.Company.TIC.Ticket.Repository.Services;
using VSoft.Company.TIC.Ticket.Data.Entity.Models;
using VSoft.Company.TIC.Ticket.Business.Dto.Extension.Methods;
using VSoft.Company.TIC.Ticket.Business.entity.Extension.Methods;
using VSoft.Company.TIC.Ticket.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.TIC.Ticket.Business.Provider.Services;

public class TicketMgmtBus : BusinessRepositoryService<TicketDto, ITicketRepository>, ITicketMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(TicketDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(TicketDto.Name),
        
    };

    public TicketMgmtBus(ITicketRepository customerRepository) : base(customerRepository)
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

    public TicketFindDtoResponse Find(MDtoRequestFindByInt request)
    {
        return Find<MDtoRequestFindByInt, TicketFindDtoResponse, int>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<TicketFindDtoResponse> FindAsync(MDtoRequestFindByInt request)
    {
        return await FindAsync<MDtoRequestFindByInt, TicketFindDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MTicketEntity?>(null)))?.GetDto()
        );
    }

    public TicketFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request)
    {
        return FindRange<MDtoRequestFindRangeByInts, TicketFindRangeDtoResponse, int>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<TicketFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByInts, TicketFindRangeDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MTicketEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public TicketInsertDtoResponse Create(TicketInsertDtoRequest request)
    {
        return Create<TicketInsertDtoRequest, TicketInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MTicketEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<TicketInsertDtoResponse> CreateAsync(TicketInsertDtoRequest request)
    {
        return await CreateAsync<TicketInsertDtoRequest, TicketInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MTicketEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MTicketEntity?>(new MTicketEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public TicketInsertRangeDtoResponse CreateRange(TicketInsertRangeDtoRequest request)
    {
        return CreateRange<TicketInsertRangeDtoRequest, TicketInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MTicketEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<TicketInsertRangeDtoResponse> CreateRangeAsync(TicketInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<TicketInsertRangeDtoRequest, TicketInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MTicketEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MTicketEntity>?>(Array.Empty<MTicketEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public TicketUpdateDtoResponse Update(TicketUpdateDtoRequest request)
    {
        return Update<TicketUpdateDtoRequest, TicketUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MTicketEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<TicketUpdateDtoResponse> UpdateAsync(TicketUpdateDtoRequest request)
    {
        return await UpdateAsync<TicketUpdateDtoRequest, TicketUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MTicketEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MTicketEntity?>(new MTicketEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public TicketUpdateRangeDtoResponse UpdateRange(TicketUpdateRangeDtoRequest request)
    {
        return UpdateRange<TicketUpdateRangeDtoRequest, TicketUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MTicketEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<TicketUpdateRangeDtoResponse> UpdateRangeAsync(TicketUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<TicketUpdateRangeDtoRequest, TicketUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MTicketEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MTicketEntity>?>(Array.Empty<MTicketEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public TicketDeleteDtoResponse Delete(TicketDeleteDtoRequest request)
    {
        return Delete<TicketDeleteDtoRequest, TicketDeleteDtoResponse, int>
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

    public async Task<TicketDeleteDtoResponse> DeleteAsync(TicketDeleteDtoRequest request)
    {
        return await DeleteAsync<TicketDeleteDtoRequest, TicketDeleteDtoResponse, int>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MTicketEntity?>(new MTicketEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MTicketEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public TicketDeleteRangeDtoResponse DeleteRange(TicketDeleteRangeDtoRequest request)
    {
        return DeleteRange<TicketDeleteRangeDtoRequest, TicketDeleteRangeDtoResponse, int>
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

    public async Task<TicketDeleteRangeDtoResponse> DeleteRangeAsync(TicketDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<TicketDeleteRangeDtoRequest, TicketDeleteRangeDtoResponse, int>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MTicketEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MTicketEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<TicketSaveRangeDtoResponse> SaveRangeAsync(TicketSaveRangeDtoRequest request, Func<MSaveRangeParams<MTicketEntity>?, Task<MSaveRangeResults<MTicketEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new TicketSaveRangeDtoResponse()
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
                return new TicketSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new TicketSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MTicketEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MTicketEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MTicketEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MTicketEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new TicketSaveRangeDtoResponse()
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
            return new TicketSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<TicketSaveRangeDtoResponse> SaveRangeAsync(TicketSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MTicketEntity>?>(null));
    }

    public async Task<TicketSaveRangeDtoResponse> SaveRangeTransactionAsync(TicketSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MTicketEntity>?>(null));
    }
}

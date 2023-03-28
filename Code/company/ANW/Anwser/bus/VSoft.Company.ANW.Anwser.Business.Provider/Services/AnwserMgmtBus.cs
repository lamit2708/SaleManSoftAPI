using VSoft.Company.ANW.Anwser.Business.Dto.Request;
using VSoft.Company.ANW.Anwser.Business.Dto.Response;
using VSoft.Company.ANW.Anwser.Business.Services;
using VSoft.Company.ANW.Anwser.Repository.Services;
using VSoft.Company.ANW.Anwser.Data.Entity.Models;
using VSoft.Company.ANW.Anwser.Business.Dto.Extension.Methods;
using VSoft.Company.ANW.Anwser.Business.entity.Extension.Methods;
using VSoft.Company.ANW.Anwser.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.ANW.Anwser.Business.Provider.Services;

public class AnwserMgmtBus : BusinessRepositoryService<AnwserDto, IAnwserRepository>, IAnwserMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(AnwserDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(AnwserDto.QuestionId),
        
    };

    public AnwserMgmtBus(IAnwserRepository customerRepository) : base(customerRepository)
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

    public AnwserFindDtoResponse Find(MDtoRequestFindByLong request)
    {
        return Find<MDtoRequestFindByLong, AnwserFindDtoResponse, long>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<AnwserFindDtoResponse> FindAsync(MDtoRequestFindByLong request)
    {
        return await FindAsync<MDtoRequestFindByLong, AnwserFindDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MAnwserEntity?>(null)))?.GetDto()
        );
    }

    public AnwserFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request)
    {
        return FindRange<MDtoRequestFindRangeByLongs, AnwserFindRangeDtoResponse, long>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<AnwserFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByLongs, AnwserFindRangeDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MAnwserEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public AnwserInsertDtoResponse Create(AnwserInsertDtoRequest request)
    {
        return Create<AnwserInsertDtoRequest, AnwserInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MAnwserEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<AnwserInsertDtoResponse> CreateAsync(AnwserInsertDtoRequest request)
    {
        return await CreateAsync<AnwserInsertDtoRequest, AnwserInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MAnwserEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MAnwserEntity?>(new MAnwserEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public AnwserInsertRangeDtoResponse CreateRange(AnwserInsertRangeDtoRequest request)
    {
        return CreateRange<AnwserInsertRangeDtoRequest, AnwserInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MAnwserEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<AnwserInsertRangeDtoResponse> CreateRangeAsync(AnwserInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<AnwserInsertRangeDtoRequest, AnwserInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MAnwserEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MAnwserEntity>?>(Array.Empty<MAnwserEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public AnwserUpdateDtoResponse Update(AnwserUpdateDtoRequest request)
    {
        return Update<AnwserUpdateDtoRequest, AnwserUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MAnwserEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<AnwserUpdateDtoResponse> UpdateAsync(AnwserUpdateDtoRequest request)
    {
        return await UpdateAsync<AnwserUpdateDtoRequest, AnwserUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MAnwserEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MAnwserEntity?>(new MAnwserEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public AnwserUpdateRangeDtoResponse UpdateRange(AnwserUpdateRangeDtoRequest request)
    {
        return UpdateRange<AnwserUpdateRangeDtoRequest, AnwserUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MAnwserEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<AnwserUpdateRangeDtoResponse> UpdateRangeAsync(AnwserUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<AnwserUpdateRangeDtoRequest, AnwserUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MAnwserEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MAnwserEntity>?>(Array.Empty<MAnwserEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public AnwserDeleteDtoResponse Delete(AnwserDeleteDtoRequest request)
    {
        return Delete<AnwserDeleteDtoRequest, AnwserDeleteDtoResponse, long>
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

    public async Task<AnwserDeleteDtoResponse> DeleteAsync(AnwserDeleteDtoRequest request)
    {
        return await DeleteAsync<AnwserDeleteDtoRequest, AnwserDeleteDtoResponse, long>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MAnwserEntity?>(new MAnwserEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MAnwserEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public AnwserDeleteRangeDtoResponse DeleteRange(AnwserDeleteRangeDtoRequest request)
    {
        return DeleteRange<AnwserDeleteRangeDtoRequest, AnwserDeleteRangeDtoResponse, long>
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

    public async Task<AnwserDeleteRangeDtoResponse> DeleteRangeAsync(AnwserDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<AnwserDeleteRangeDtoRequest, AnwserDeleteRangeDtoResponse, long>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MAnwserEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MAnwserEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<AnwserSaveRangeDtoResponse> SaveRangeAsync(AnwserSaveRangeDtoRequest request, Func<MSaveRangeParams<MAnwserEntity>?, Task<MSaveRangeResults<MAnwserEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new AnwserSaveRangeDtoResponse()
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
                return new AnwserSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new AnwserSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MAnwserEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MAnwserEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MAnwserEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MAnwserEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new AnwserSaveRangeDtoResponse()
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
            return new AnwserSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<AnwserSaveRangeDtoResponse> SaveRangeAsync(AnwserSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MAnwserEntity>?>(null));
    }

    public async Task<AnwserSaveRangeDtoResponse> SaveRangeTransactionAsync(AnwserSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MAnwserEntity>?>(null));
    }
}

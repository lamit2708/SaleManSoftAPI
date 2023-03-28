using VSoft.Company.QUE.Question.Business.Dto.Request;
using VSoft.Company.QUE.Question.Business.Dto.Response;
using VSoft.Company.QUE.Question.Business.Services;
using VSoft.Company.QUE.Question.Repository.Services;
using VSoft.Company.QUE.Question.Data.Entity.Models;
using VSoft.Company.QUE.Question.Business.Dto.Extension.Methods;
using VSoft.Company.QUE.Question.Business.entity.Extension.Methods;
using VSoft.Company.QUE.Question.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.QUE.Question.Business.Provider.Services;

public class QuestionMgmtBus : BusinessRepositoryService<QuestionDto, IQuestionRepository>, IQuestionMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(QuestionDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(QuestionDto.TicketId),
        
    };

    public QuestionMgmtBus(IQuestionRepository customerRepository) : base(customerRepository)
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

    public QuestionFindDtoResponse Find(MDtoRequestFindByLong request)
    {
        return Find<MDtoRequestFindByLong, QuestionFindDtoResponse, long>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<QuestionFindDtoResponse> FindAsync(MDtoRequestFindByLong request)
    {
        return await FindAsync<MDtoRequestFindByLong, QuestionFindDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MQuestionEntity?>(null)))?.GetDto()
        );
    }

    public QuestionFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request)
    {
        return FindRange<MDtoRequestFindRangeByLongs, QuestionFindRangeDtoResponse, long>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<QuestionFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByLongs, QuestionFindRangeDtoResponse, long>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MQuestionEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public QuestionInsertDtoResponse Create(QuestionInsertDtoRequest request)
    {
        return Create<QuestionInsertDtoRequest, QuestionInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MQuestionEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<QuestionInsertDtoResponse> CreateAsync(QuestionInsertDtoRequest request)
    {
        return await CreateAsync<QuestionInsertDtoRequest, QuestionInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MQuestionEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MQuestionEntity?>(new MQuestionEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public QuestionInsertRangeDtoResponse CreateRange(QuestionInsertRangeDtoRequest request)
    {
        return CreateRange<QuestionInsertRangeDtoRequest, QuestionInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MQuestionEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<QuestionInsertRangeDtoResponse> CreateRangeAsync(QuestionInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<QuestionInsertRangeDtoRequest, QuestionInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MQuestionEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MQuestionEntity>?>(Array.Empty<MQuestionEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public QuestionUpdateDtoResponse Update(QuestionUpdateDtoRequest request)
    {
        return Update<QuestionUpdateDtoRequest, QuestionUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MQuestionEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<QuestionUpdateDtoResponse> UpdateAsync(QuestionUpdateDtoRequest request)
    {
        return await UpdateAsync<QuestionUpdateDtoRequest, QuestionUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MQuestionEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MQuestionEntity?>(new MQuestionEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public QuestionUpdateRangeDtoResponse UpdateRange(QuestionUpdateRangeDtoRequest request)
    {
        return UpdateRange<QuestionUpdateRangeDtoRequest, QuestionUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MQuestionEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<QuestionUpdateRangeDtoResponse> UpdateRangeAsync(QuestionUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<QuestionUpdateRangeDtoRequest, QuestionUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MQuestionEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MQuestionEntity>?>(Array.Empty<MQuestionEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public QuestionDeleteDtoResponse Delete(QuestionDeleteDtoRequest request)
    {
        return Delete<QuestionDeleteDtoRequest, QuestionDeleteDtoResponse, long>
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

    public async Task<QuestionDeleteDtoResponse> DeleteAsync(QuestionDeleteDtoRequest request)
    {
        return await DeleteAsync<QuestionDeleteDtoRequest, QuestionDeleteDtoResponse, long>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MQuestionEntity?>(new MQuestionEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MQuestionEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public QuestionDeleteRangeDtoResponse DeleteRange(QuestionDeleteRangeDtoRequest request)
    {
        return DeleteRange<QuestionDeleteRangeDtoRequest, QuestionDeleteRangeDtoResponse, long>
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

    public async Task<QuestionDeleteRangeDtoResponse> DeleteRangeAsync(QuestionDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<QuestionDeleteRangeDtoRequest, QuestionDeleteRangeDtoResponse, long>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MQuestionEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MQuestionEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<QuestionSaveRangeDtoResponse> SaveRangeAsync(QuestionSaveRangeDtoRequest request, Func<MSaveRangeParams<MQuestionEntity>?, Task<MSaveRangeResults<MQuestionEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new QuestionSaveRangeDtoResponse()
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
                return new QuestionSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new QuestionSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MQuestionEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MQuestionEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MQuestionEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MQuestionEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new QuestionSaveRangeDtoResponse()
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
            return new QuestionSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<QuestionSaveRangeDtoResponse> SaveRangeAsync(QuestionSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MQuestionEntity>?>(null));
    }

    public async Task<QuestionSaveRangeDtoResponse> SaveRangeTransactionAsync(QuestionSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MQuestionEntity>?>(null));
    }
}

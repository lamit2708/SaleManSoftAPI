using VSoft.Company.ORD.Order.Business.Dto.Request;
using VSoft.Company.ORD.Order.Business.Dto.Response;
using VSoft.Company.ORD.Order.Business.Services;
using VSoft.Company.ORD.Order.Repository.Services;
using VSoft.Company.ORD.Order.Data.Entity.Models;
using VSoft.Company.ORD.Order.Business.Dto.Extension.Methods;
using VSoft.Company.ORD.Order.Business.entity.Extension.Methods;
using VSoft.Company.ORD.Order.Business.Dto.Data;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Business.Provider.Methods;
using System.Text;
using VegunSoft.Framework.Business.Provider.Repository.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;

namespace VSoft.Company.ORD.Order.Business.Provider.Services;

public class OrderMgmtBus : BusinessRepositoryService<OrderDto, IOrderRepository>, IOrderMgmtBus
{
    protected override string? ContextName { get; set; } = "khách hàng";

    protected override List<string>? KeyRequiredFields { get; set; } = new List<string>()
    {
        nameof(OrderDto.Id)
    };

    protected override List<string>? SaveRequiredFields { get; set; } = new List<string>()
    {
        nameof(OrderDto.CustomerId),
        
    };

    public OrderMgmtBus(IOrderRepository customerRepository) : base(customerRepository)
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

    public OrderFindDtoResponse Find(MDtoRequestFindByInt request)
    {
        return Find<MDtoRequestFindByInt, OrderFindDtoResponse, int>
        (
            request,
            (id) => Repository?.GetById(id)?.GetDto()
        );
    }

    public async Task<OrderFindDtoResponse> FindAsync(MDtoRequestFindByInt request)
    {
        return await FindAsync<MDtoRequestFindByInt, OrderFindDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MOrderEntity?>(null)))?.GetDto()
        );
    }

    public OrderFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request)
    {
        return FindRange<MDtoRequestFindRangeByInts, OrderFindRangeDtoResponse, int>
        (
            request,
            (id) => Repository?.GetByIds(id)?.Select(e => e.GetDto()).ToArray()
        );
    }

    public async Task<OrderFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request)
    {
        return await FindRangeAsync<MDtoRequestFindRangeByInts, OrderFindRangeDtoResponse, int>
        (
            request,
            async (id) => (await (Repository?.GetByIdsAsync(id) ?? Task.FromResult<IEnumerable<MOrderEntity>?>(null)))?.Select(e => e.GetDto()).ToArray()
        );
    }

    public OrderInsertDtoResponse Create(OrderInsertDtoRequest request)
    {
        return Create<OrderInsertDtoRequest, OrderInsertDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MOrderEntity();
                return Repository?.Create(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<OrderInsertDtoResponse> CreateAsync(OrderInsertDtoRequest request)
    {
        return await CreateAsync<OrderInsertDtoRequest, OrderInsertDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(false) ?? new MOrderEntity();
                var resultEntity = await (Repository?.CreateAsync(inputEntity) ?? Task.FromResult<MOrderEntity?>(new MOrderEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public OrderInsertRangeDtoResponse CreateRange(OrderInsertRangeDtoRequest request)
    {
        return CreateRange<OrderInsertRangeDtoRequest, OrderInsertRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MOrderEntity>();
                return Repository?.CreateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public async Task<OrderInsertRangeDtoResponse> CreateRangeAsync(OrderInsertRangeDtoRequest request)
    {
        return await CreateRangeAsync<OrderInsertRangeDtoRequest, OrderInsertRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(false)) ?? new List<MOrderEntity>();
                var resultEntities = await (Repository?.CreateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MOrderEntity>?>(Array.Empty<MOrderEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public OrderUpdateDtoResponse Update(OrderUpdateDtoRequest request)
    {
        return Update<OrderUpdateDtoRequest, OrderUpdateDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MOrderEntity();
                return Repository?.Update(inputEntity)?.GetDto();
            }
        );
    }

    public async Task<OrderUpdateDtoResponse> UpdateAsync(OrderUpdateDtoRequest request)
    {
        return await UpdateAsync<OrderUpdateDtoRequest, OrderUpdateDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntity = data?.GetEntity(true) ?? new MOrderEntity();
                var resultEntity = await (Repository?.UpdateAsync(inputEntity) ?? Task.FromResult<MOrderEntity?>(new MOrderEntity()));
                return resultEntity?.GetDto();
            }
        );
    }

    public OrderUpdateRangeDtoResponse UpdateRange(OrderUpdateRangeDtoRequest request)
    {
        return UpdateRange<OrderUpdateRangeDtoRequest, OrderUpdateRangeDtoResponse>
        (
            request,
            (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MOrderEntity>();
                return Repository?.UpdateRange(inputEntities)?.Select(e => e.GetDto()).ToArray();

            }
        );
    }

    public async Task<OrderUpdateRangeDtoResponse> UpdateRangeAsync(OrderUpdateRangeDtoRequest request)
    {
        return await UpdateRangeAsync<OrderUpdateRangeDtoRequest, OrderUpdateRangeDtoResponse>
        (
            request,
            async (data) =>
            {
                var inputEntities = data?.Select(x => x.GetEntity(true)) ?? new List<MOrderEntity>();
                var resultEntities = await (Repository?.UpdateRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MOrderEntity>?>(Array.Empty<MOrderEntity>()));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
        );
    }

    public OrderDeleteDtoResponse Delete(OrderDeleteDtoRequest request)
    {
        return Delete<OrderDeleteDtoRequest, OrderDeleteDtoResponse, long>
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

    public async Task<OrderDeleteDtoResponse> DeleteAsync(OrderDeleteDtoRequest request)
    {
        return await DeleteAsync<OrderDeleteDtoRequest, OrderDeleteDtoResponse, long>
        (
             request,
             async (id) =>
             {
                 var inputEntity = await (Repository?.GetByIdAsync(id) ?? Task.FromResult<MOrderEntity?>(new MOrderEntity()));
                 var resultEntity = inputEntity != null ? await (Repository?.DeleteAsync(inputEntity) ?? Task.FromResult<MOrderEntity?>(null)) : null;
                 return resultEntity?.GetDto();
             }
        );
    }

    public OrderDeleteRangeDtoResponse DeleteRange(OrderDeleteRangeDtoRequest request)
    {
        return DeleteRange<OrderDeleteRangeDtoRequest, OrderDeleteRangeDtoResponse, int>
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

    public async Task<OrderDeleteRangeDtoResponse> DeleteRangeAsync(OrderDeleteRangeDtoRequest request)
    {
       return await DeleteRangeAsync<OrderDeleteRangeDtoRequest, OrderDeleteRangeDtoResponse, int>
       (
            request,
            async (ids) =>
            {
                var inputEntities = await (Repository?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<MOrderEntity>?>(null));
                var resultEntities = await (Repository?.DeleteRangeAsync(inputEntities) ?? Task.FromResult<IEnumerable<MOrderEntity>?>(null));
                return resultEntities?.Select(e => e.GetDto()).ToArray();
            }
       );
    }


    protected async Task<OrderSaveRangeDtoResponse> SaveRangeAsync(OrderSaveRangeDtoRequest request, Func<MSaveRangeParams<MOrderEntity>?, Task<MSaveRangeResults<MOrderEntity>?>> func)
    {
        var functionName = nameof(SaveRangeAsync);
        var createData = request?.CreateData;
        var updateData = request?.UpdateData;
        var deleteData = request?.DeleteIds;
        var canRun = (createData != null && createData.Any());
        canRun = canRun || (updateData != null && updateData.Any());
        canRun = canRun || (deleteData != null && deleteData.Any());

        if (!canRun) return new OrderSaveRangeDtoResponse()
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
                return new OrderSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = createMsg,
                }.GetResponse(functionName);
            }
            var updateMsg = GetSaveRequiredMessages(updateData);
            if (!string.IsNullOrWhiteSpace(updateMsg))
            {
                return new OrderSaveRangeDtoResponse()
                {
                    IsSuccess = false,
                    Message = updateMsg,
                }.GetResponse(functionName);
            }

            var inputCreateEntities = createData?.Select(x => x.GetEntity(false)) ?? new List<MOrderEntity>();
            var inputUpdateEntities = updateData?.Select(x => x.GetEntity(true)) ?? new List<MOrderEntity>();


            var inputDeleteEntities = await (Repository?.GetByIdsAsync(deleteData) ?? Task.FromResult<IEnumerable<MOrderEntity>?>(null));
            var resultEntities = await func(new MSaveRangeParams<MOrderEntity>()
            {
                CreateEntities = inputCreateEntities,
                UpdateEntities = inputUpdateEntities,
                DeleteEntities = inputDeleteEntities,

            });
            var resultCreateDtos = resultEntities?.CreateEntities?.Select(e => e.GetDto()).ToArray();
            var resultUpdateDtos = resultEntities?.UpdateEntities?.Select(e => e.GetDto()).ToArray();
            var resultDeleteDtos = resultEntities?.DeleteEntities?.Select(e => e.GetDto()).ToArray();
            var sb = new StringBuilder($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thành công!");

            return new OrderSaveRangeDtoResponse()
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
            return new OrderSaveRangeDtoResponse()
            {
                IsSuccess = false,
                Message = ex.GetMessages($"Lưu {createCount} / {updateCount} / {deleteCount} {ContextName} thất bại!", request),
            }.GetResponse(functionName);
        }
    }

    public async Task<OrderSaveRangeDtoResponse> SaveRangeAsync(OrderSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MOrderEntity>?>(null));
    }

    public async Task<OrderSaveRangeDtoResponse> SaveRangeTransactionAsync(OrderSaveRangeDtoRequest request)
    {
        return await SaveRangeAsync(request, (rq) => (Repository?.SaveRangeTransactionAsync(rq)) ?? Task.FromResult<MSaveRangeResults<MOrderEntity>?>(null));
    }
}

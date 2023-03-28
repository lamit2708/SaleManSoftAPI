using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.PRI.Priority.Business.Dto.Request;
using VSoft.Company.PRI.Priority.Business.Dto.Response;

namespace VSoft.Company.PRI.Priority.Client.Services;

public interface IPriorityClient: IApiDtoClientJSon<IPriorityClient>
{  

    Task<PriorityFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<PriorityFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<PriorityInsertDtoResponse> CreateAsync(PriorityInsertDtoRequest request);

    Task<PriorityInsertRangeDtoResponse> CreateRangeAsync(PriorityInsertRangeDtoRequest request);

    Task<PriorityUpdateDtoResponse> UpdateAsync(PriorityUpdateDtoRequest request);

    Task<PriorityUpdateRangeDtoResponse> UpdateRangeAsync(PriorityUpdateRangeDtoRequest request);

    Task<PriorityDeleteDtoResponse> DeleteAsync(PriorityDeleteDtoRequest request);

    Task<PriorityDeleteRangeDtoResponse> DeleteRangeAsync(PriorityDeleteRangeDtoRequest request);

    Task<PrioritySaveRangeDtoResponse> SaveRangeAsync(PrioritySaveRangeDtoRequest request);
   
}
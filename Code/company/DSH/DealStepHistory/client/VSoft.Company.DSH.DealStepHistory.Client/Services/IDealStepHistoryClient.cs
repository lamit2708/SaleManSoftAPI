using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.DSH.DealStepHistory.Business.Dto.Request;
using VSoft.Company.DSH.DealStepHistory.Business.Dto.Response;

namespace VSoft.Company.DSH.DealStepHistory.Client.Services;

public interface IDealStepHistoryClient: IApiDtoClientJSon<IDealStepHistoryClient>
{  

    Task<DealStepHistoryFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<DealStepHistoryFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<DealStepHistoryInsertDtoResponse> CreateAsync(DealStepHistoryInsertDtoRequest request);

    Task<DealStepHistoryInsertRangeDtoResponse> CreateRangeAsync(DealStepHistoryInsertRangeDtoRequest request);

    Task<DealStepHistoryUpdateDtoResponse> UpdateAsync(DealStepHistoryUpdateDtoRequest request);

    Task<DealStepHistoryUpdateRangeDtoResponse> UpdateRangeAsync(DealStepHistoryUpdateRangeDtoRequest request);

    Task<DealStepHistoryDeleteDtoResponse> DeleteAsync(DealStepHistoryDeleteDtoRequest request);

    Task<DealStepHistoryDeleteRangeDtoResponse> DeleteRangeAsync(DealStepHistoryDeleteRangeDtoRequest request);

    Task<DealStepHistorySaveRangeDtoResponse> SaveRangeAsync(DealStepHistorySaveRangeDtoRequest request);
   
}
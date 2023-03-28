using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.DST.DealStep.Business.Dto.Request;
using VSoft.Company.DST.DealStep.Business.Dto.Response;

namespace VSoft.Company.DST.DealStep.Client.Services;

public interface IDealStepClient: IApiDtoClientJSon<IDealStepClient>
{  

    Task<DealStepFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<DealStepFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<DealStepInsertDtoResponse> CreateAsync(DealStepInsertDtoRequest request);

    Task<DealStepInsertRangeDtoResponse> CreateRangeAsync(DealStepInsertRangeDtoRequest request);

    Task<DealStepUpdateDtoResponse> UpdateAsync(DealStepUpdateDtoRequest request);

    Task<DealStepUpdateRangeDtoResponse> UpdateRangeAsync(DealStepUpdateRangeDtoRequest request);

    Task<DealStepDeleteDtoResponse> DeleteAsync(DealStepDeleteDtoRequest request);

    Task<DealStepDeleteRangeDtoResponse> DeleteRangeAsync(DealStepDeleteRangeDtoRequest request);

    Task<DealStepSaveRangeDtoResponse> SaveRangeAsync(DealStepSaveRangeDtoRequest request);
   
}
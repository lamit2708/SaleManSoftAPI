using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.DST.DealStep.Business.Dto.Request;
using VSoft.Company.DST.DealStep.Business.Dto.Response;

namespace VSoft.Company.DST.DealStep.Business.Services;

public interface IDealStepMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByInt request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByInt request);

    DealStepFindDtoResponse Find(MDtoRequestFindByInt request);

    Task<DealStepFindDtoResponse> FindAsync(MDtoRequestFindByInt request);

    DealStepFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request);

    Task<DealStepFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request);

    DealStepInsertDtoResponse Create(DealStepInsertDtoRequest request);

    Task<DealStepInsertDtoResponse> CreateAsync(DealStepInsertDtoRequest request);

    DealStepInsertRangeDtoResponse CreateRange(DealStepInsertRangeDtoRequest request);

    Task<DealStepInsertRangeDtoResponse> CreateRangeAsync(DealStepInsertRangeDtoRequest request);

    DealStepUpdateDtoResponse Update(DealStepUpdateDtoRequest request);

    Task<DealStepUpdateDtoResponse> UpdateAsync(DealStepUpdateDtoRequest request);

    DealStepUpdateRangeDtoResponse UpdateRange(DealStepUpdateRangeDtoRequest request);

    Task<DealStepUpdateRangeDtoResponse> UpdateRangeAsync(DealStepUpdateRangeDtoRequest request);

    DealStepDeleteDtoResponse Delete(DealStepDeleteDtoRequest request);

    Task<DealStepDeleteDtoResponse> DeleteAsync(DealStepDeleteDtoRequest request);

    DealStepDeleteRangeDtoResponse DeleteRange(DealStepDeleteRangeDtoRequest request);

    Task<DealStepDeleteRangeDtoResponse> DeleteRangeAsync(DealStepDeleteRangeDtoRequest request);

    Task<DealStepSaveRangeDtoResponse> SaveRangeAsync(DealStepSaveRangeDtoRequest request);

    Task<DealStepSaveRangeDtoResponse> SaveRangeTransactionAsync(DealStepSaveRangeDtoRequest request);

    Task<DealStepFindRangeDtoResponse> GetAll();
}

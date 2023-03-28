using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.ANW.Anwser.Business.Dto.Request;
using VSoft.Company.ANW.Anwser.Business.Dto.Response;

namespace VSoft.Company.ANW.Anwser.Business.Services;

public interface IAnwserMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByLong request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByLong request);

    AnwserFindDtoResponse Find(MDtoRequestFindByLong request);

    Task<AnwserFindDtoResponse> FindAsync(MDtoRequestFindByLong request);

    AnwserFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request);

    Task<AnwserFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request);

    AnwserInsertDtoResponse Create(AnwserInsertDtoRequest request);

    Task<AnwserInsertDtoResponse> CreateAsync(AnwserInsertDtoRequest request);

    AnwserInsertRangeDtoResponse CreateRange(AnwserInsertRangeDtoRequest request);

    Task<AnwserInsertRangeDtoResponse> CreateRangeAsync(AnwserInsertRangeDtoRequest request);

    AnwserUpdateDtoResponse Update(AnwserUpdateDtoRequest request);

    Task<AnwserUpdateDtoResponse> UpdateAsync(AnwserUpdateDtoRequest request);

    AnwserUpdateRangeDtoResponse UpdateRange(AnwserUpdateRangeDtoRequest request);

    Task<AnwserUpdateRangeDtoResponse> UpdateRangeAsync(AnwserUpdateRangeDtoRequest request);

    AnwserDeleteDtoResponse Delete(AnwserDeleteDtoRequest request);

    Task<AnwserDeleteDtoResponse> DeleteAsync(AnwserDeleteDtoRequest request);

    AnwserDeleteRangeDtoResponse DeleteRange(AnwserDeleteRangeDtoRequest request);

    Task<AnwserDeleteRangeDtoResponse> DeleteRangeAsync(AnwserDeleteRangeDtoRequest request);

    Task<AnwserSaveRangeDtoResponse> SaveRangeAsync(AnwserSaveRangeDtoRequest request);

    Task<AnwserSaveRangeDtoResponse> SaveRangeTransactionAsync(AnwserSaveRangeDtoRequest request);
}

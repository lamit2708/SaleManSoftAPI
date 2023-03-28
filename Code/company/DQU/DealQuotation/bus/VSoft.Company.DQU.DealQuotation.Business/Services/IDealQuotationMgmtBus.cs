using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.DQU.DealQuotation.Business.Dto.Request;
using VSoft.Company.DQU.DealQuotation.Business.Dto.Response;

namespace VSoft.Company.DQU.DealQuotation.Business.Services;

public interface IDealQuotationMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByLong request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByLong request);

    DealQuotationFindDtoResponse Find(MDtoRequestFindByLong request);

    Task<DealQuotationFindDtoResponse> FindAsync(MDtoRequestFindByLong request);

    DealQuotationFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request);

    Task<DealQuotationFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request);

    DealQuotationInsertDtoResponse Create(DealQuotationInsertDtoRequest request);

    Task<DealQuotationInsertDtoResponse> CreateAsync(DealQuotationInsertDtoRequest request);

    DealQuotationInsertRangeDtoResponse CreateRange(DealQuotationInsertRangeDtoRequest request);

    Task<DealQuotationInsertRangeDtoResponse> CreateRangeAsync(DealQuotationInsertRangeDtoRequest request);

    DealQuotationUpdateDtoResponse Update(DealQuotationUpdateDtoRequest request);

    Task<DealQuotationUpdateDtoResponse> UpdateAsync(DealQuotationUpdateDtoRequest request);

    DealQuotationUpdateRangeDtoResponse UpdateRange(DealQuotationUpdateRangeDtoRequest request);

    Task<DealQuotationUpdateRangeDtoResponse> UpdateRangeAsync(DealQuotationUpdateRangeDtoRequest request);

    DealQuotationDeleteDtoResponse Delete(DealQuotationDeleteDtoRequest request);

    Task<DealQuotationDeleteDtoResponse> DeleteAsync(DealQuotationDeleteDtoRequest request);

    DealQuotationDeleteRangeDtoResponse DeleteRange(DealQuotationDeleteRangeDtoRequest request);

    Task<DealQuotationDeleteRangeDtoResponse> DeleteRangeAsync(DealQuotationDeleteRangeDtoRequest request);

    Task<DealQuotationSaveRangeDtoResponse> SaveRangeAsync(DealQuotationSaveRangeDtoRequest request);

    Task<DealQuotationSaveRangeDtoResponse> SaveRangeTransactionAsync(DealQuotationSaveRangeDtoRequest request);
}

using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.DQU.DealQuotation.Business.Dto.Request;
using VSoft.Company.DQU.DealQuotation.Business.Dto.Response;

namespace VSoft.Company.DQU.DealQuotation.Client.Services;

public interface IDealQuotationClient: IApiDtoClientJSon<IDealQuotationClient>
{  

    Task<DealQuotationFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<DealQuotationFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<DealQuotationInsertDtoResponse> CreateAsync(DealQuotationInsertDtoRequest request);

    Task<DealQuotationInsertRangeDtoResponse> CreateRangeAsync(DealQuotationInsertRangeDtoRequest request);

    Task<DealQuotationUpdateDtoResponse> UpdateAsync(DealQuotationUpdateDtoRequest request);

    Task<DealQuotationUpdateRangeDtoResponse> UpdateRangeAsync(DealQuotationUpdateRangeDtoRequest request);

    Task<DealQuotationDeleteDtoResponse> DeleteAsync(DealQuotationDeleteDtoRequest request);

    Task<DealQuotationDeleteRangeDtoResponse> DeleteRangeAsync(DealQuotationDeleteRangeDtoRequest request);

    Task<DealQuotationSaveRangeDtoResponse> SaveRangeAsync(DealQuotationSaveRangeDtoRequest request);
   
}
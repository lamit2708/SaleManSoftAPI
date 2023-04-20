using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.CTM.Customer.Business.Dto.Request;
using VSoft.Company.CTM.Customer.Business.Dto.Response;

namespace VSoft.Company.CTM.Customer.Business.Services;

public interface ICustomerMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByLong request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByLong request);

    CustomerFindDtoResponse Find(MDtoRequestFindByLong request);

    Task<CustomerFindDtoResponse> FindAsync(MDtoRequestFindByLong request);

    CustomerFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request);

    Task<CustomerFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request);

    CustomerInsertDtoResponse Create(CustomerInsertDtoRequest request);

    Task<CustomerInsertDtoResponse> CreateAsync(CustomerInsertDtoRequest request);

    CustomerInsertRangeDtoResponse CreateRange(CustomerInsertRangeDtoRequest request);

    Task<CustomerInsertRangeDtoResponse> CreateRangeAsync(CustomerInsertRangeDtoRequest request);

    CustomerUpdateDtoResponse Update(CustomerUpdateDtoRequest request);

    Task<CustomerUpdateDtoResponse> UpdateAsync(CustomerUpdateDtoRequest request);

    CustomerUpdateRangeDtoResponse UpdateRange(CustomerUpdateRangeDtoRequest request);

    Task<CustomerUpdateRangeDtoResponse> UpdateRangeAsync(CustomerUpdateRangeDtoRequest request);

    CustomerDeleteDtoResponse Delete(CustomerDeleteDtoRequest request);

    Task<CustomerDeleteDtoResponse> DeleteAsync(CustomerDeleteDtoRequest request);

    CustomerDeleteRangeDtoResponse DeleteRange(CustomerDeleteRangeDtoRequest request);

    Task<CustomerDeleteRangeDtoResponse> DeleteRangeAsync(CustomerDeleteRangeDtoRequest request);

    Task<CustomerSaveRangeDtoResponse> SaveRangeAsync(CustomerSaveRangeDtoRequest request);

    Task<CustomerSaveRangeDtoResponse> SaveRangeTransactionAsync(CustomerSaveRangeDtoRequest request);
    Task<CustomerTableKeySearchDtoResponse> GetTableByKeySearch(CustomerTableKeySearchDtoRequest request);
	
	Task<CustomerFindRangeDtoResponse> GetAll();
}

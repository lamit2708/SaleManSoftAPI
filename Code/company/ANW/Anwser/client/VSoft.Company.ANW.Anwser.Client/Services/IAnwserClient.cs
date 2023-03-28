using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.ANW.Anwser.Business.Dto.Request;
using VSoft.Company.ANW.Anwser.Business.Dto.Response;

namespace VSoft.Company.ANW.Anwser.Client.Services;

public interface IAnwserClient: IApiDtoClientJSon<IAnwserClient>
{  

    Task<AnwserFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<AnwserFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<AnwserInsertDtoResponse> CreateAsync(AnwserInsertDtoRequest request);

    Task<AnwserInsertRangeDtoResponse> CreateRangeAsync(AnwserInsertRangeDtoRequest request);

    Task<AnwserUpdateDtoResponse> UpdateAsync(AnwserUpdateDtoRequest request);

    Task<AnwserUpdateRangeDtoResponse> UpdateRangeAsync(AnwserUpdateRangeDtoRequest request);

    Task<AnwserDeleteDtoResponse> DeleteAsync(AnwserDeleteDtoRequest request);

    Task<AnwserDeleteRangeDtoResponse> DeleteRangeAsync(AnwserDeleteRangeDtoRequest request);

    Task<AnwserSaveRangeDtoResponse> SaveRangeAsync(AnwserSaveRangeDtoRequest request);
   
}
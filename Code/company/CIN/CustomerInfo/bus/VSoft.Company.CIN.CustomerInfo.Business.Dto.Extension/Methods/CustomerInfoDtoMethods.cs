using VSoft.Company.CIN.CustomerInfo.Business.Dto.Data;
using VSoft.Company.CIN.CustomerInfo.Data.Entity.Models;

namespace VSoft.Company.CIN.CustomerInfo.Business.Dto.Extension.Methods;

public static class CustomerInfoDtoMethods
{
    public static MCustomerInfoEntity GetEntity(this CustomerInfoDto src, bool isForUpdate)
    {
        return new MCustomerInfoEntity()
        {
            Id = src.Id,
            CustomerSourceId = src.CustomerSourceId,
            Hobby = src.Hobby,
            Job = src.Job,
            BirthDate = src.BirthDate,
            IsMarrage = src.IsMarrage,
        };
    }
}

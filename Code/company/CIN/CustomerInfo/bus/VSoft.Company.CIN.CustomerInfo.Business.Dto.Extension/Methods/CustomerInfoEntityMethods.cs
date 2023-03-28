using VSoft.Company.CIN.CustomerInfo.Business.Dto.Data;
using VSoft.Company.CIN.CustomerInfo.Data.Entity.Models;

namespace VSoft.Company.CIN.CustomerInfo.Business.entity.Extension.Methods;

public static class CustomerInfoEntityMethods
{
    public static CustomerInfoDto GetDto(this MCustomerInfoEntity src)
    {
        return new CustomerInfoDto()
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

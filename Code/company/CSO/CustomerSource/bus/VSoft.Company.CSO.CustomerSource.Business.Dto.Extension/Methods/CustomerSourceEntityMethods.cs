using VSoft.Company.CSO.CustomerSource.Business.Dto.Data;
using VSoft.Company.CSO.CustomerSource.Data.Entity.Models;

namespace VSoft.Company.CSO.CustomerSource.Business.entity.Extension.Methods;

public static class CustomerSourceEntityMethods
{
    public static CustomerSourceDto GetDto(this MCustomerSourceEntity src)
    {
        return new CustomerSourceDto()
        {
            Id = src.Id,
            Name = src.Name,
            Description = src.Description,
        };
    }
}

using VSoft.Company.CSO.CustomerSource.Business.Dto.Data;
using VSoft.Company.CSO.CustomerSource.Data.Entity.Models;

namespace VSoft.Company.CSO.CustomerSource.Business.Dto.Extension.Methods;

public static class CustomerSourceDtoMethods
{
    public static MCustomerSourceEntity GetEntity(this CustomerSourceDto src, bool isForUpdate)
    {
        return new MCustomerSourceEntity()
        {
            Id = src.Id,
            Name = src.Name,
            Description = src.Description,
        };
    }
}

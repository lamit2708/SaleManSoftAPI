using VSoft.Company.UCU.UserCustomer.Business.Dto.Data;
using VSoft.Company.UCU.UserCustomer.Data.Entity.Models;

namespace VSoft.Company.UCU.UserCustomer.Business.Dto.Extension.Methods;

public static class UserCustomerDtoMethods
{
    public static MUserCustomerEntity GetEntity(this UserCustomerDto src, bool isForUpdate)
    {
        return new MUserCustomerEntity()
        {
            Id = src.Id,
            CustomerId = src.CustomerId,
            UserId = src.UserId,
            TeamId = src.TeamId,
            CreatedDateTeam = src.CreatedDateTeam,
            CreatedDateUser = src.CreatedDateUser,

        };
    }


}

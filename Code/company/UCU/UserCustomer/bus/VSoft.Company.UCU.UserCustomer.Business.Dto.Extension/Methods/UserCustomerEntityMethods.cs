using VSoft.Company.UCU.UserCustomer.Business.Dto.Data;
using VSoft.Company.UCU.UserCustomer.Data.Entity.Models;

namespace VSoft.Company.UCU.UserCustomer.Business.entity.Extension.Methods;

public static class UserCustomerEntityMethods
{
    public static UserCustomerDto GetDto(this MUserCustomerEntity src)
    {
        return new UserCustomerDto()
        {
            Id = src.Id,
            CustomerId = src.CustomerId,
            UserId = src.UserId,
            TeamId = src.TeamId,
            CreatedDateTeam = src.CreatedDateTeam,
            CreatedDateUser = src.CreatedDateUser,
        };
    }

    public static UserCustomerDto GetDto(this MUserCustomerViewEntity src)
    {
        return new UserCustomerDto()
        {
            Id = src.Id,
            CustomerId = src.CustomerId,
            UserId = src.UserId,
            TeamId = src.TeamId,
            CreatedDateTeam = src.CreatedDateTeam,
            CreatedDateUser = src.CreatedDateUser,
            CustomerFullName = src.CustomerFullName,
            UserFullName = src.UserFullName,
            TeamName = src.TeamName,
        };
    }

    public static List<UserCustomerDto> GetDto(this List<MUserCustomerViewEntity> srcs)
    {
        var rs = new List<UserCustomerDto>();
        if (srcs == null)
            return rs;
        srcs.ForEach(src => rs.Add(src.GetDto()));
        return rs;
    }
}

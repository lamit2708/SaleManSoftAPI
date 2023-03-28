using VSoft.Company.ORD.Order.Business.Dto.Data;
using VSoft.Company.ORD.Order.Data.Entity.Models;

namespace VSoft.Company.ORD.Order.Business.entity.Extension.Methods;

public static class OrderEntityMethods
{
    public static OrderDto GetDto(this MOrderEntity src)
    {
        return new OrderDto()
        {
            Id = src.Id,
            CustomerId = src.CustomerId,
            UserId = src.UserId,
            CreatedDate = src.CreatedDate
        };
    }
}

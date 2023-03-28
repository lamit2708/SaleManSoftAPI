using VSoft.Company.ORD.Order.Business.Dto.Data;
using VSoft.Company.ORD.Order.Data.Entity.Models;

namespace VSoft.Company.ORD.Order.Business.Dto.Extension.Methods;

public static class OrderDtoMethods
{
    public static MOrderEntity GetEntity(this OrderDto src, bool isForUpdate)
    {
        return new MOrderEntity()
        {
            Id = src.Id,
            CustomerId = src.CustomerId,
            UserId = src.UserId,
            CreatedDate = src.CreatedDate
        };
    }
}

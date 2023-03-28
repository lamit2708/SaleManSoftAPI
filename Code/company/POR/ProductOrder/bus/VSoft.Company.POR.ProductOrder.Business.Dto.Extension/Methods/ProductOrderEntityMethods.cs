using VSoft.Company.POR.ProductOrder.Business.Dto.Data;
using VSoft.Company.POR.ProductOrder.Data.Entity.Models;

namespace VSoft.Company.POR.ProductOrder.Business.entity.Extension.Methods;

public static class ProductOrderEntityMethods
{
    public static ProductOrderDto GetDto(this MProductOrderEntity src)
    {
        return new ProductOrderDto()
        {
            Id = src.Id,
            OrderId = src.OrderId,
            ProductId = src.ProductId,
            Quatity = src.Quatity,
            UnitPrice = src.UnitPrice,
        };
    }
}

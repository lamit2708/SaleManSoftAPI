using VSoft.Company.POR.ProductOrder.Business.Dto.Data;
using VSoft.Company.POR.ProductOrder.Data.Entity.Models;

namespace VSoft.Company.POR.ProductOrder.Business.Dto.Extension.Methods;

public static class ProductOrderDtoMethods
{
    public static MProductOrderEntity GetEntity(this ProductOrderDto src, bool isForUpdate)
    {
        return new MProductOrderEntity()
        {
            Id = src.Id,
            OrderId = src.OrderId,
            ProductId = src.ProductId,
            Quatity = src.Quatity,
            UnitPrice = src.UnitPrice,
        };
    }
}

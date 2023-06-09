﻿using VSoft.Company.PRC.ProductCategory.Business.Dto.Data;
using VSoft.Company.PRC.ProductCategory.Data.Entity.Models;

namespace VSoft.Company.PRC.ProductCategory.Business.entity.Extension.Methods;

public static class ProductCategoryEntityMethods
{
    public static ProductCategoryDto GetDto(this MProductCategoryEntity src)
    {
        return new ProductCategoryDto()
        {
            Id = src.Id,
            Name = src.Name,
           
        };
    }

    public static List<ProductCategoryDto> GetDto(this List<MProductCategoryEntity> srcs)
    {
        var rs = new List<ProductCategoryDto>();
        if (srcs == null)
            return rs;
        srcs.ForEach(src => rs.Add(src.GetDto()));
        return rs;
    }
}

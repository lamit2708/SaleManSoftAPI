﻿using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.PRC.ProductCategory.Api.Cfg.Routes
{
    public interface IProductCategoryControllerPath : IApiControllerPath
    {
        string? ProductCategory { get; set; }
    }
}

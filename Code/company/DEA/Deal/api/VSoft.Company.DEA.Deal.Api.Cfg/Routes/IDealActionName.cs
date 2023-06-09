﻿using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.DEA.Deal.Api.Cfg.Routes
{
    public interface IDealActionName: IApiActionName
    {
        string? FindTable { get; set; }

        string? UpdateStep { get; set; }
    }
}

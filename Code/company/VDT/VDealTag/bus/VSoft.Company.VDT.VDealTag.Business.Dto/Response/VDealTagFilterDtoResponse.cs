﻿using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.VDT.VDealTag.Business.Dto.Data;

namespace VSoft.Company.VDT.VDealTag.Business.Dto.Response
{
    public class VDealTagFilterDtoResponse : MDtoResponseRange<VDealTagDto>
    {
       public VDealTagFilterDto Filter { get; set; }
    }
}

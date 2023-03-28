﻿using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.POR.ProductOrder.Business.Dto.Request
{
    public class ProductOrderRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? PORName { get; set; }
       
    }
}

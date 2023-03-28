﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSoft.Company.PRC.ProductCategory.Business.Dto.Data
{
    public class ProductCategoryDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;


        public override string ToString()
        {
            return $"{Id} / {Name}";
        }
    }
}

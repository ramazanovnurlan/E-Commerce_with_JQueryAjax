﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_API.Models.Admin.AllMenu
{
    public class Product_and_ProductFilter
    {
        public List<Product> Products { get; set; }
        public ProductFilter ProductFilter { get; set; }
    }
}

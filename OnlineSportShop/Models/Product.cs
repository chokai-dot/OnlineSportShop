﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSportShop.Pages.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string NameOfProduct { get; set; }
        public string Photo { get; set; }
        public float Price { get; set; }
    }
}

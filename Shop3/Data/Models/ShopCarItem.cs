﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop3.Data.Models
{
    public class ShopCarItem
    {
        public int id { get; set; }
        public Car car {get; set;}

        public int price { get; set; }
        public string ShopCarId { get; set;  }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationFlower.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Entities
{
    class ProductComparison { 
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductComparison(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + " " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
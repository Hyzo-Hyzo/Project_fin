using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_fin
{
    
        public class Products
        {
            public string Name { get; set; }
            public decimal Price { get; set; }

            public Products(string name, decimal price)
            {
                Name = name;
                Price = price;
            }
        }
    
}

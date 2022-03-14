using System;
using System.Collections.Generic;
using System.Text;

namespace LINQU
{
    class ProductInfo
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int NumberInStock { get; set; } = 0;
        public override string ToString()
        {
            return string.Format($"Product name = {Name}, description = {Description}, number in stock = {NumberInStock} ");
        }
    }
}

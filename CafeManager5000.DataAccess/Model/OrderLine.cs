using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager5000.DataAccess.Model
{
    public class OrderLine
    {
        public OrderLine(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal => Product.Price * Quantity;
    }
}

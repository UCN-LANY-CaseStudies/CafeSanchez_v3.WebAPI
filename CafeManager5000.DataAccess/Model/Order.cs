using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager5000.DataAccess.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int Discount { get; set; }
        public States State { get; set; }
        public IList<OrderLine> OrderLines { get; set; } = new List<OrderLine>();

        public enum States
        {
            New, 
            Active, 
            Ready, 
            Finished
        }
    }
}

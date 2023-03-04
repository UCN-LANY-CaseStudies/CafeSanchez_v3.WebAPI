using CafeManager5000.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager5000.DataAccess.DaoFake
{
    internal class OrderDao : IDao<Order>
    {
        private static int id = 0;
        private static IList<Order> orders = new List<Order>();

        public Order Create(Order order)
        {
            order.Id = id++;

            orders.Add(order);

            return order;
        }

        public bool Delete(Order entity)
        {
            if(orders.Contains(entity))
            {
                orders.Remove(entity);
                return true;
            }
            return false;
        }

        public IEnumerable<Order> ReadAll()
        {
            return orders;
        }

        public bool Update(Order entity)
        {
            return true;
        }
    }
}

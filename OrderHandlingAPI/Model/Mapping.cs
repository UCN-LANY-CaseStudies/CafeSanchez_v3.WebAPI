using CafeManager5000.DataAccess.Model;
using System.Runtime.CompilerServices;

namespace OrderHandlingAPI.Model
{
    internal static class Mapping
    {
        #region Product

        public static IEnumerable<ProductResponse> Map(this IEnumerable<Product> products)
        {
            foreach (var product in products)
            {
                yield return product.Map();
            }
        }

        public static ProductResponse Map(this Product product)
        {
            return new ProductResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
            };
        }
        #endregion

        #region Order

        public static IEnumerable<OrderResponse> Map(this IEnumerable<Order> orders)
        {
            foreach (var order in orders)
            {
                yield return order.Map();
            }
        }

        public static OrderResponse Map(this Order order)
        {
            return new OrderResponse
            {
                CustomerName = order.CustomerName,
                Id = order.Id,
                TotalPrice = order.OrderLines.Sum(ol => ol.SubTotal),
            };
        }

        #endregion
    }
}
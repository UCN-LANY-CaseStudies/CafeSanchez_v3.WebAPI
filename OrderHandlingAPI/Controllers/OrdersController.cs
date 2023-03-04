using CafeManager5000.DataAccess;
using CafeManager5000.DataAccess.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderHandlingAPI.Model;

namespace OrderHandlingAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IDao<Order> _orderDao;

        public OrdersController(IDao<Order> orderDao)
        {
            _orderDao = orderDao ?? throw new ArgumentNullException(nameof(orderDao));
        }

        [HttpGet]
        public IActionResult GetUnfinishedOrders()
        {
            IEnumerable<Order> orders = _orderDao.ReadAll().Where(o => o.State != Order.States.Finished);

            return Ok(orders);
        }

        [HttpPost]
        public IActionResult CreateNewOrder(CreateOrderRequest req)
        {


            Order order = new()
            {
                CustomerName = req.CustomerName,
                Discount = req.Discount,
                State = Order.States.New,
            };

            order = _orderDao.Create(order);

            return CreatedAtRoute(null, order);
        }

        [HttpPut]
        public IActionResult ChangeOrderState(int orderId)
        {
            Order? order = _orderDao.ReadAll().SingleOrDefault(o => o.Id == orderId);

            if (order == null)
            {
                return NotFound();
            }
            switch (order.State)
            {
                case Order.States.New:
                    order.State = Order.States.Active; 
                    break;
                case Order.States.Active:
                    order.State = Order.States.Ready;
                    break;
                case Order.States.Ready:
                    order.State = Order.States.Finished;
                    break;
                default:
                    return BadRequest();
            }
            _orderDao.Update(order);
            return Ok();
        }
    }
}

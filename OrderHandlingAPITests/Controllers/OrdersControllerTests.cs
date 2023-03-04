using Xunit;
using OrderHandlingAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderHandlingAPITests;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using OrderHandlingAPI.Model;

namespace OrderHandlingAPI.Controllers.Tests
{
    public class OrdersControllerTests : IClassFixture<OrderDaoFixture>
    {
        private readonly OrderDaoFixture _orderDao;

        public OrdersControllerTests(OrderDaoFixture orderDao)
        {
            _orderDao = orderDao;
        }

        [Fact]
        public void CreateOrdersControllerWithNullParametersTest()
        {
            Assert.Throws<ArgumentNullException>(() => { new OrdersController(null); });
        }

        [Fact]
        public void GetUnfinishedOrdersTest()
        {
            // Arrange
            OrdersController ctrl = new(_orderDao);

            // Act
            var response = ctrl.GetUnfinishedOrders();
            var result = response as ObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.True(result?.StatusCode == 200);
            Assert.IsAssignableFrom<IEnumerable>(result?.Value);
        }

        [Fact()]
        public void CreateNewOrderTest()
        {
            // Arrange
            OrdersController ctrl = new(_orderDao);
            CreateOrderRequest order = new()
            {
                CustomerName = "Hans", 
                Discount = 0,
            };

            // Act
            var response = ctrl.CreateNewOrder(order);
            var result = response as ObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.True(result?.StatusCode == 201);
        }

        [Fact()]
        public void ChangeOrderStateTest()
        {
            // Arrange
            OrdersController ctrl = new(_orderDao);

            Assert.True(false, "This test needs an implementation");
        }
    }
}
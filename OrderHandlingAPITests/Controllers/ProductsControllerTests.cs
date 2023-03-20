using Xunit;
using OrderHandlingAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderHandlingAPITests;
using CafeManager5000.DataAccess;
using CafeManager5000.DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using OrderHandlingAPI.Model;

namespace OrderHandlingAPI.Controllers.Tests
{
    public class ProductsControllerTests : IClassFixture<ProductDaoFixture>
    {
        private readonly IDao<Product> _productDao;

        public ProductsControllerTests(ProductDaoFixture productDao)
        {
            _productDao = productDao;
        }

        [Fact()]
        public void GetAllTest()
        {
            // Arrange
            ProductsController ctrl = new(_productDao);

            // Act
            var response = ctrl.GetAll();
            var result = response as ObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.True(result?.StatusCode == 200);
            Assert.IsAssignableFrom<IEnumerable<ProductResponse>>(result?.Value);          
        }
    }
}
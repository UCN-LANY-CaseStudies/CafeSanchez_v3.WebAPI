using CafeManager5000.DataAccess;
using CafeManager5000.DataAccess.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderHandlingAPI.Model;

namespace OrderHandlingAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IDao<Product> _productDao;

        public ProductsController(IDao<Product> productDao)
        {
            _productDao = productDao;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productDao.ReadAll().Map());
        }
    }
}

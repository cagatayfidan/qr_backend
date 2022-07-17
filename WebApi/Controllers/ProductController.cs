using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.BLL.Logics.Interfaces;
using WebApi.Model.ViewModels.ProductController;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {
        private readonly ILogger<ValuesController> _logger;
        private readonly IProductLogic _productsLogic;

        public ProductController(IProductLogic productsLogic, ILogger<ValuesController> logger, IUserLogic userLogic) : base(userLogic)
        {
            _productsLogic = productsLogic;
            _logger = logger;
        }

        [Authorize]
        [HttpGet("GetAll")]
        public List<ProductGetOutputViewModel> Get()
        {
            return _productsLogic.Get(this.User);
        }

        [Authorize]
        [HttpPost("Register")]
        public IActionResult Register([FromBody] ProductPostInputViewModel product)
        {
            return Ok(_productsLogic.Register(product, this.User));
        }

        [Authorize]
        [HttpPut("Update")]
        public ProductPutOutputViewModel Update(ProductPutInputViewModel product)
        {
            return _productsLogic.Update(product);
        }

        [Authorize]
        [HttpDelete("Delete")]
        public ProductDeleteOutputViewModel Delete(ProductDeleteInputViewModel product)
        {
            return _productsLogic.Delete(product);
        }

    }
}

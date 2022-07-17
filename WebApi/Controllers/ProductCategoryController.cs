using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.BLL.Logics.Interfaces;
using WebApi.Model.ViewModels.ProductCategoryController;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : BaseController
    {
        private readonly ILogger<ValuesController> _logger;
        private readonly IProductCategoryLogic _productCategoryLogic;

        public ProductCategoryController(IProductCategoryLogic productCategorLogic, ILogger<ValuesController> logger, IUserLogic userLogic) : base(userLogic)
        {
            _productCategoryLogic = productCategorLogic;
            _logger = logger;
        }

        [Authorize]
        [HttpPost("Add")]
        public IActionResult Add([FromBody] ProductCategoryPostInputViewModel productCategory)
        {
            return Ok(_productCategoryLogic.Add(productCategory, this.User));
        }

    }
}

using Inv.Models.ModelsDB;
using Inv.Services.ProductsService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inv.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private ProductsProvider _productsProvider;

        public ProductsController(ProductsProvider productsProvider)
        {
            _productsProvider = productsProvider;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Products>> Get()
        {
            return _productsProvider.GetProducts().ToList();
        }
        [HttpPost]
        public ActionResult<string> Add(Products product)
        {
            return _productsProvider.AddProduct(product);
        }
        [HttpPut]
        public ActionResult<string> Edit(Products product)
        {
            return _productsProvider.EditProduct(product);
        }
        [HttpDelete]
        public ActionResult<string> Delete(Products product)
        {
            return _productsProvider.DeleteProduct(product);
        }

    }
}

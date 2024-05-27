using Inv.Models.ModelsDB;
using Inv.Services.CategoriesService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inv.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private CategoriesProvider _categoriesProvider;

        public CategoriesController(CategoriesProvider categorysProvider)
        {
            _categoriesProvider = categorysProvider;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Categories>> Get()
        {
            return _categoriesProvider.GetCategories().ToList();
        }
        [HttpPost]
        public ActionResult<string> Add(Categories category)
        {
            return _categoriesProvider.AddCategory(category);
        }
        [HttpPut]
        public ActionResult<string> Edit(Categories category)
        {
            return _categoriesProvider.EditCategory(category);
        }
        [HttpDelete]
        public ActionResult<string> Delete(Categories category)
        {
            return _categoriesProvider.DeleteCategory(category);
        }
    }
}

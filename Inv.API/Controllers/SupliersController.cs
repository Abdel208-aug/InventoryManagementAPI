using Inv.Models.ModelsDB;
using Inv.Services.SupliersService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inv.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupliersController : ControllerBase
    {
        private SupliersProvider _supliersProvider;

        public SupliersController(SupliersProvider supliersProvider)
        {
            _supliersProvider = supliersProvider;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Supliers>> Get()
        {
            return _supliersProvider.GetSupliers().ToList();
        }
        [HttpPost]
        public ActionResult<string> Add(Supliers suplier)
        {
            return _supliersProvider.AddSuplier(suplier);
        }
        [HttpPut]
        public ActionResult<string> Edit(Supliers suplier)
        {
            return _supliersProvider.EditSuplier(suplier);
        }
        [HttpDelete]
        public ActionResult<string> Delete(Supliers suplier)
        {
            return _supliersProvider.DeleteSuplier(suplier);
        }
    }
}

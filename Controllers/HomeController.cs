using Microsoft.AspNetCore.Mvc;

namespace FCode_CRUD.Controllers
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {

            return Ok("vardhan");
        }
    }
}

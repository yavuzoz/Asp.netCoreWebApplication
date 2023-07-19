using Microsoft.AspNetCore.Mvc;

namespace Asp.netCoreWebApplication.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}

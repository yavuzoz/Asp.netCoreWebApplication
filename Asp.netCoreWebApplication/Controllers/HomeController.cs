using Microsoft.AspNetCore.Mvc;

namespace Asp.netCoreWebApplication.Controllers
{
    //Home -> HomeController
    public class HomeController : Controller
    {
        public IActionResult Index() 
        {
            return View(); 
        } 
    }
}

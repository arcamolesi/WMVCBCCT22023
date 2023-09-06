using Microsoft.AspNetCore.Mvc;

namespace WMVCBCCT22023.Controllers
{
    public class FemaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BCC ()
        {
            return View();
        }
    }
}

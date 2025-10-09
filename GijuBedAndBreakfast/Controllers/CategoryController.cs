using Microsoft.AspNetCore.Mvc;

namespace GijuBedAndBreakfast.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

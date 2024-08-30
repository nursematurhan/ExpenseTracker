using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.WebProject.Controllers.PreLogin
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

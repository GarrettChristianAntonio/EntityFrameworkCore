using Microsoft.AspNetCore.Mvc;

namespace EFRepositoryMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

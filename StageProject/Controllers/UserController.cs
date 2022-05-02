using Microsoft.AspNetCore.Mvc;
using StageProject.ViewModels;

namespace StageProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            UserVM userVM = new UserVM();
            return View(userVM);
        }

        [HttpPost]
        public IActionResult Index(string option)
        {
            return View();
        }
    }
}

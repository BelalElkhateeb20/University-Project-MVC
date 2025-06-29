using Microsoft.AspNetCore.Mvc;

namespace School_Project_MVC.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

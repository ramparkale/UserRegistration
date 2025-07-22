using Microsoft.AspNetCore.Mvc;

namespace UserRegistration.Controllers
{
    public class EmployeeController : Controller
    {
        public string Index()
        {
            return "Welcome to User Registration";
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}

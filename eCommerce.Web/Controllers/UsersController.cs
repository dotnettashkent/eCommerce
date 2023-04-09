using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Web.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

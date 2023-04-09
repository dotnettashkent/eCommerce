using eCommerce.Service.DTOs.Users;
using eCommerce.Service.Interfaces;
using eCommerce.Service.Service;
using eCommerce.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Web.Controllers
{
    public class AccountController : Controller
    {

        IUserService userService = new UserService();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userService.GetServiceAsync(u => u.Email == model.Email && u.Password == model.Password);


            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View(model);
            }

            //

            if (true)
            {
                return RedirectToAction("Index", "Home");
            }
        }


        // registering

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserCreationDto model)
        {
            if (ModelState.IsValid)
            {

                var result = await userService.CreateServiceAsync(model);

                if (result != null)
                {
                    return RedirectToAction("Login");
                }

            }

            return View(model);
        }

    }


}

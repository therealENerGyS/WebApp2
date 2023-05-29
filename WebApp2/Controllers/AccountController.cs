using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp2.Services;
using WebApp2.ViewModels;

namespace WebApp2.Controllers
{
    public class AccountController : Controller
    {
        private readonly AuthService _auth;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(AuthService auth, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _auth = auth;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (await _auth.RegisterAsync(model))
                    return RedirectToAction("Login");

                ModelState.AddModelError("", "An user with the same email already exists");
            }

            return View(model);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (await _auth.LoginAsync(model))
                {
                    var user = await _userManager.FindByNameAsync(model.Email);
                    if(user != null)
                    {
                        var role = await _userManager.GetRolesAsync(user);
                        if(role != null)
                        {
                            if (role.Contains("admin"))
                                return RedirectToAction("Index", "Admin");
                            else
                                return RedirectToAction("Index", "Account");
                        }
                    }
                }

                ModelState.AddModelError("", "Incorrect email or password");

            }

            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> LogOut()
        {
            if (await _auth.LogOutAsync(User))
                return LocalRedirect("/");

            return RedirectToAction("Index");
        }
    }
}

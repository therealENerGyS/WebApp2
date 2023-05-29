using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp2.Services;

namespace WebApp2.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly UserRoleService _userRole;

        public AdminController(UserRoleService userRole)
        {
            _userRole = userRole;
        }

        public async Task<IActionResult> Index()
        {
            var userList = await _userRole.GetAllUsersAsync();
            return View(userList);
        }
    }
}

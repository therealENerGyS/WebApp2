using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApp2.ViewModels;

namespace WebApp2.Services
{
    public class UserRoleService
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UserRoleService(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        //Get users and their roles
        public async Task<List<UserViewModel>> GetAllUsersAsync()
        {
            var users = await _userManager.Users.ToListAsync();
            var userRoleList = users.Select(async user =>
            {
                var roles = await _userManager.GetRolesAsync(user);
                return new UserViewModel
                {
                    IdentityUser = user.UserName,
                    IdentityRole = roles.FirstOrDefault()
                };
            });

            return (await Task.WhenAll(userRoleList)).ToList();
        }
    }
}

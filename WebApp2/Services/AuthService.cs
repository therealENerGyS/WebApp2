using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using WebApp2.Context;
using WebApp2.Models.Entities;
using WebApp2.ViewModels;

namespace WebApp2.Services
{
    public class AuthService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IdentityContext _identityContext;
        private readonly SeedService _seedService;

        public AuthService(SeedService seedService, IdentityContext identityContext, RoleManager<IdentityRole> roleManager, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _seedService = seedService;
            _identityContext = identityContext;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<bool> RegisterAsync(RegisterViewModel viewModel)
        {
            try
            {
                await _seedService.SeedRoles();
                var roleName = "User";

                if (!await _userManager.Users.AnyAsync())
                    roleName = "Admin";

                IdentityUser identityUser = viewModel;
                await _userManager.CreateAsync(identityUser, viewModel.Password);

                await _userManager.AddToRoleAsync(identityUser, roleName);

                UserProfileEntity userprofileEntity = viewModel;
                userprofileEntity.UserId = identityUser.Id;

                _identityContext.UserProfiles.Add(userprofileEntity);
                await _identityContext.SaveChangesAsync();

                return true;

            }
            catch { return false; }
        }

        public async Task<bool> LoginAsync(LoginViewModel viewModel)
        {
            try
            {
                var res = await _signInManager.PasswordSignInAsync(viewModel.Email, viewModel.Password, viewModel.RememberMe, false);
                return res.Succeeded;
            }
            catch { return false; }
        }

        public async Task<bool> LogOutAsync(ClaimsPrincipal user)
        {
            await _signInManager.SignOutAsync();
            return _signInManager.IsSignedIn(user);
        }
    }
}

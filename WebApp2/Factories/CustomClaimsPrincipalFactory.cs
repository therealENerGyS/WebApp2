using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using WebApp2.Services;

namespace WebApp.Factories;

public class CustomClaimsPrincipalFactory : UserClaimsPrincipalFactory<IdentityUser>
{
    private readonly UserService _user;
    public CustomClaimsPrincipalFactory(UserManager<IdentityUser> userManager, IOptions<IdentityOptions> optionsAccessor, UserService user) : base(userManager, optionsAccessor)
    {
        _user = user;
    }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(IdentityUser user)
    {
        var claims = await base.GenerateClaimsAsync(user);
        var userProfile = await _user.GetUserProfileAsync(user.Id);

        claims.AddClaim(new Claim("DisplayName", $"{userProfile.FirstName} {userProfile.LastName}"));

        var roles = await UserManager.GetRolesAsync(user);
        foreach (var role in roles)
        {
            claims.AddClaim(new Claim(ClaimTypes.Role, role));
        }

        return claims;
    }
}

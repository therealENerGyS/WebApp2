using Microsoft.EntityFrameworkCore;
using WebApp2.Context;
using WebApp2.Models.Entities;

namespace WebApp2.Services
{
    public class UserService
    {
        private readonly IdentityContext _identityContext;

        public UserService(IdentityContext identityContext)
        {
            _identityContext = identityContext;
        }

        public async Task<UserProfileEntity> GetUserProfileAsync(string userId)
        {
            var userProfile = await _identityContext.UserProfiles.Include(x => x.User).FirstOrDefaultAsync(x => x.UserId == userId);

            return userProfile!;
        }
    }
}

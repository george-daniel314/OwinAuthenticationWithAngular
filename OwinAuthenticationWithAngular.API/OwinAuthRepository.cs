using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using OwinAuthenticationWithAngular.API.Models;
using System;
using System.Threading.Tasks;

namespace OwinAuthenticationWithAngular.API
{
    public class OwinAuthRepository : IDisposable
    {
        private OwinAuthContext context;

        private UserManager<IdentityUser> userManager;

        public OwinAuthRepository()
        {
            context = new OwinAuthContext();
            userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(context));
        }

        public async Task<IdentityResult> CreateUserAsync(UserModel userModel)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = userModel.UserName
            };

            var result = await userManager.CreateAsync(user, userModel.Password);

            return result;
        }

        public async Task<IdentityUser> FindUserAsync(string userName, string password)
        {
            IdentityUser user = await userManager.FindAsync(userName, password);

            return user;
        }

        public void Dispose()
        {
            context.Dispose();
            userManager.Dispose();

        }
    }
}
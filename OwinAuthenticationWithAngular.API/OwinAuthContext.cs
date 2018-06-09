using Microsoft.AspNet.Identity.EntityFramework;

namespace OwinAuthenticationWithAngular.API
{
    public class OwinAuthContext : IdentityDbContext<IdentityUser>
    {
        public OwinAuthContext()
            : base("OwinAuthContext")
        {

        }
    }
}
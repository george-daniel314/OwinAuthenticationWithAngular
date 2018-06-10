using Microsoft.AspNet.Identity;
using OwinAuthenticationWithAngular.API.Models;
using System.Threading.Tasks;
using System.Web.Http;

namespace OwinAuthenticationWithAngular.API.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        private OwinAuthRepository repository = null;

        public AccountController()
        {
            repository = new OwinAuthRepository();
        }

        // POST api/Account/Register
        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(UserModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityResult identityResult = await repository.CreateUserAsync(userModel);

            IHttpActionResult errorResult = GetErrorResult(identityResult);

            if (errorResult != null)
            {
                return errorResult;
            }

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repository.Dispose();
            }

            base.Dispose(disposing);
        }

        private IHttpActionResult GetErrorResult(IdentityResult identityResult)
        {
            if (identityResult == null)
            {
                return InternalServerError();
            }

            if (!identityResult.Succeeded)
            {
                if (identityResult.Errors != null)
                {
                    foreach (string error in identityResult.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }
    }
}
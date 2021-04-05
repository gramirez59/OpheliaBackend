using Microsoft.AspNetCore.Antiforgery;
using Ophelia.Controllers;

namespace Ophelia.Web.Host.Controllers
{
    public class AntiForgeryController : OpheliaControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}

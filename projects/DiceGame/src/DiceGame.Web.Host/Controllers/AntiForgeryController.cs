using Microsoft.AspNetCore.Antiforgery;
using DiceGame.Controllers;

namespace DiceGame.Web.Host.Controllers
{
    public class AntiForgeryController : DiceGameControllerBase
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

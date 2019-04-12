using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using DiceGame.Controllers;

namespace DiceGame.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : DiceGameControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}

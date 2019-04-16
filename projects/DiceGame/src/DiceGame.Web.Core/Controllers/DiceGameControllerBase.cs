using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DiceGame.Controllers
{
    public abstract class DiceGameControllerBase: AbpController
    {
        protected DiceGameControllerBase()
        {
            LocalizationSourceName = DiceGameConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

using Abp.AspNetCore.Mvc.ViewComponents;

namespace DiceGame.Web.Views
{
    public abstract class DiceGameViewComponent : AbpViewComponent
    {
        protected DiceGameViewComponent()
        {
            LocalizationSourceName = DiceGameConsts.LocalizationSourceName;
        }
    }
}

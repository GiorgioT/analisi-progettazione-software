using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DiceGame.Configuration.Dto;

namespace DiceGame.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DiceGameAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

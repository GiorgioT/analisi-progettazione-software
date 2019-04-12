using System.Threading.Tasks;
using DiceGame.Configuration.Dto;

namespace DiceGame.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

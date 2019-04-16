using System.Threading.Tasks;
using Abp.Application.Services;
using DiceGame.Authorization.Accounts.Dto;

namespace DiceGame.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

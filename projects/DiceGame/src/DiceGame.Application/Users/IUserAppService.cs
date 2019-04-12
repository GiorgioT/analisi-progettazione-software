using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DiceGame.Roles.Dto;
using DiceGame.Users.Dto;

namespace DiceGame.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}

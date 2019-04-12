using System.Collections.Generic;
using DiceGame.Roles.Dto;
using DiceGame.Users.Dto;

namespace DiceGame.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}

using System.Collections.Generic;
using DiceGame.Roles.Dto;

namespace DiceGame.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}
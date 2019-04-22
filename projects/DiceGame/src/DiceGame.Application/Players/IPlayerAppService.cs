using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Services;
using DiceGame.Players.DTO;

namespace DiceGame.Players
{
    public interface IPlayerAppService : IDomainService, ICrudAppService<PlayerDTO>
    {
        IEnumerable<PlayerDTO> ListAll();
    }
}

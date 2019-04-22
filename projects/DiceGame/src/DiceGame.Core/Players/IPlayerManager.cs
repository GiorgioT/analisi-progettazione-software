using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace DiceGame.Players
{
    public interface IPlayerManager: IDomainService
    {
        IQueryable<Player> ListAll();
    }
}

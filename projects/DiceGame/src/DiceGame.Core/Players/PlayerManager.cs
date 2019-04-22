using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace DiceGame.Players
{
    public class PlayerManager : DomainService, IPlayerManager
    {
        private readonly IRepository _repository;
        public PlayerManager(IRepository repository)
        {
            _repository = repository;
        }
        public IQueryable<Player> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using DiceGame.Players;
using DiceGame.Players.DTO;
using Abp.Application.Services;

namespace DiceGame
{
    public class PlayerAppService: CrudAppService<Player, PlayerDTO>, IPlayerAppService
    {
        private readonly IRepository<Player> _repository;

        public PlayerAppService(IRepository<Player> repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<PlayerDTO> ListAll()
        {
            var p = _repository.GetAll();
            return ObjectMapper.Map<List<PlayerDTO>>(p);
        }

    }
}

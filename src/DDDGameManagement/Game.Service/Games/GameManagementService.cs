using Game.Domain.Entities;
using Game.Service.Repositories;

namespace Game.Service.Games
{
    public class GameManagementService
    {
        public readonly GameRepository _gameRepository;

        public GameManagementService(GameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public VideogameCartridge FindGameById(int id)
        {
            return _gameRepository.Find(id);
        }

        public void AddNewGame(VideogameCartridge game)
        {
            _gameRepository.Add(game);
        }

        public VideogameCartridge FindGameByName(string name)
        {
            return _gameRepository.FindByName(name);
        }

        //...
    }
}

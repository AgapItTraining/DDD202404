using Game.Domain.Dto;
using Game.Domain.Mapping;
using Game.Service.Games;
using Microsoft.AspNetCore.Mvc;

namespace Game.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly GameManagementService _gameService;

        public GameController(GameManagementService gameService)
        {
            this._gameService = gameService;
        }

        [HttpGet]
        public GameDto GetGameById(int id)
        {
            var temp = _gameService.FindGameById(id);
            var game = GameDtoToGame.Map(temp);
            return game;
        }

        [HttpGet]
        [Route("GetByName")]
        public GameDto GetGameByName(string name)
        {
            var temp = _gameService.FindGameByName(name);
            var game = GameDtoToGame.Map(temp);
            return game;
        }


        [HttpPost]
        public void CreateANewGame(GameDto gameDto)
        {
            var game = GameDtoToGame.Map(gameDto);
            _gameService.AddNewGame(game);
        }
    }
}

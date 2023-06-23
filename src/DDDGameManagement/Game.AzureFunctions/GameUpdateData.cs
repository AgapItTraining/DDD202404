using System;
using Game.Domain.Dto;
using Game.Domain.Mapping;
using Game.Service.Games;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Game.AzureFunctions
{
    public class GameUpdateData
    {
        private readonly ILogger _logger;
        private readonly GameManagementService _gameService;

        public GameUpdateData(ILoggerFactory loggerFactory, GameManagementService gameService)
        {
            _logger = loggerFactory.CreateLogger<GameUpdateData>();
            _gameService = gameService;
        }

        [Function("GameUpdateData")]
        public void Run([QueueTrigger("sbq-updatedata", Connection = "MyConnectionString")] string myQueueItem)
        {
            _logger.LogInformation($"C# Queue trigger function processed: {myQueueItem}");

            var gameDto = new GameDto
            {
                ConsoleName = "SNES",
                GameName = "Donkey Kong",
                DateOfPurchase = DateTime.Now,
            };

            var game = GameDtoToGame.Map(gameDto);
            _gameService.AddNewGame(game);
        }
    }
}

using Game.Domain.Dto;
using Game.Domain.Entities;

namespace Game.Domain.Mapping
{
    public class GameDtoToGame
    {
        public static VideogameCartridge Map (GameDto gameDto)
        {
            var newobject = new VideogameCartridge
            {
                Name = gameDto.GameName,
            };


            return newobject;
        }

        public static GameDto Map(VideogameCartridge game)
        {
            var newobject = new GameDto
            {
                GameName = game.Name
            };

            return newobject;
        }
    }
}

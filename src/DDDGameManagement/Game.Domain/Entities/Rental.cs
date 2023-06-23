namespace Game.Domain.Entities
{
    public class Rental : GenericEntity
    {
        public Friend? Friend { get; set; }
        public VideogameCartridge VideogameCartridge { get; set; }
    }

}

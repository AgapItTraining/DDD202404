namespace Game.Domain.Entities;

public class VideogameCartridge : GenericEntity
{
    public string? Name { get; set; }
    public DateTime? DateOfPurchase { get; set; }
    public string? Category { get; set; }
}
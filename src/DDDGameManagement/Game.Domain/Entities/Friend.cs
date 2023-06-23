namespace Game.Domain.Entities;

public class Friend : GenericEntity
{
    public string? Name { get; set; }
    public Address? Address { get; set; }
}
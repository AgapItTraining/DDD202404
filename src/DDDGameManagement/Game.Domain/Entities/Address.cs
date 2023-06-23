using System.ComponentModel.DataAnnotations;

namespace Game.Domain.Entities;


public class Address : GenericEntity
{
    [Required]
    [MaxLength(50)]
    public string? Name { get; set; }
}






using System.ComponentModel.DataAnnotations.Schema;

namespace Game.Domain.Entities;

public abstract class GenericEntity
{
    [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
}






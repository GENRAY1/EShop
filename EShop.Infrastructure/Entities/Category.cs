using System.ComponentModel.DataAnnotations;

namespace EShop.Infrastructure.Entities;

public class Category
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    
    public string Name { get; set; }
}
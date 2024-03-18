using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Infrastructure.Entities;

public class Product
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    
    public string Name { get; set; }
    
    public decimal Cost { get; set; }
    
    public int Count { get; set; }
    
    [ForeignKey("Category")]
    public Guid CategoryId { get; set; }
    
    public virtual Category Category { get; set; }
    public virtual ICollection<ProductOrder> ProductOrders { get; set; }
}
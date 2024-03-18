namespace EShop.Infrastructure.Entities;

public class Order
{
    public Guid Id { get; set; }
    public decimal TotalCost { get; set; }
    public DateTime CreationTime { get; set; } 
    public bool IsComplited { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string? Street { get; set; }
    public string? Building { get; set; }
    public string? Apartment { get; set; }
    public string? Comment { get; set; }
    public virtual ICollection<ProductOrder> ProductOrders { get; set; } = new List<ProductOrder>();
}
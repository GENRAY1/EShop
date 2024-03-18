namespace EShop.Infrastructure.Entities;

public class ProductOrder
{
    public Guid ProductId { get; set; }
    public virtual Product Product { get; set; }
    public Guid OrderId { get; set; }
    public virtual Order Order { get; set; }
    public int Count { get; set; }
}
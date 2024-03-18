using EShop.Domain.OrderAggregate.Exceptions;
using EShop.Domain.OrderAggregate.ValueObjects;
using EShop.Domain.ProductAggregate;

namespace EShop.Domain.OrderAggregate;

public class Order: BaseAggregate
{
    public required IReadOnlyCollection<Product> Products
    {
        init
        {
            if(value.Count == 0) throw new NoProductsInOrderException();
            TotalCost = value.Sum(p => p.Cost * p.Count);
            
            OrderItems = value.Select(p => new ProductInfo
            {
                Id = p.Id, 
                Count = p.Count
            }).ToArray();
        }
    }

    public required CustomerInfo CustomerInfo { get; init; }
    public required DeliveryInfo? DeliveryInfo { get; init; }
    public decimal TotalCost { get; private init; }
    public DateTime CreationTime { get; } = DateTime.UtcNow;
    public bool IsComplited { get; private set; }
    public IReadOnlyCollection<ProductInfo> OrderItems { get; private init; }
    
    public void Complite() 
    {
        IsComplited = true;
    }
     
}
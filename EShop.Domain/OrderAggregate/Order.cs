using EShop.Domain.OrderAggregate.Exceptions;
using EShop.Domain.OrderAggregate.ValueObjects;
using EShop.Domain.ProductAggregate;

namespace EShop.Domain.OrderAggregate;

public class Order: BaseAggregate
{

    public Order(IReadOnlyCollection<Product> products)
    {
        if (products.Count == 0) throw new NoProductsInOrderException();
        
        TotalCost = products.Sum(p => p.Cost);
        _orderItems = products.Select(p => new ProductInfo
        {
            Id = p.Id, 
            Count = p.Count
        }).ToArray();
    }
    public decimal TotalCost { get; }
    public DateTime CreationTime { get; } = DateTime.UtcNow;
    public bool IsComplited { get; private set; }

    public required CustomerInfo CustomerInfo { get; init; }
    public required DeliveryInfo? DeliveryInfo { get; init; }
    
    public void Complite() 
    {
        IsComplited = true;
    }
    
    private readonly ProductInfo[] _orderItems;
    
    public IReadOnlyCollection<ProductInfo> OrderItems => _orderItems;
    
}
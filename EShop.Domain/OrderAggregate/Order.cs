using EShop.Domain.OrderAggregate.Exceptions;
using EShop.Domain.ProductAggregate;

namespace EShop.Domain.OrderAggregate;

public class Order: BaseAggregate
{
    public Order(Guid id, IReadOnlyCollection<Product> products): base(id)
    {
        if (products.Count == 0) throw new NoProductsInOrderException();
        
        TotalCost = products.Sum(p => p.Cost);
        _orderItems = products.Select(p => p.Id).ToArray();
    }
    public decimal TotalCost { get; }
    public DateTime CreationTime { get; } = DateTime.UtcNow;
    public bool IsComplited { get; private set; }

    public void Complite() 
    {
        IsComplited = true;
    }
    
    private readonly Guid[] _orderItems;
    
    public IReadOnlyCollection<Guid> OrderItems => _orderItems;
    
}
namespace EShop.Domain.OrderAggregate.ValueObjects;

public class ProductInfo(Guid id, int count)
{
    private Guid Id { get; } = id;
    private int Count { get; } = count;
}


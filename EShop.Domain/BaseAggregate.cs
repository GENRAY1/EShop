namespace EShop.Domain;

public abstract class BaseAggregate(Guid id)
{
    public Guid Id { get; } = id;
    
}

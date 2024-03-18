namespace EShop.Domain;

public abstract class BaseAggregate()
{
    public Guid Id { get; } = Guid.NewGuid();
}

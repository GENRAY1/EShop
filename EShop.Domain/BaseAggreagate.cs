namespace EShop.Domain;

public abstract class BaseAggreagate(Guid id)
{
    public Guid Id { get; } = id;
    
}
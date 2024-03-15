using EShop.Domain.CategoryAggregate.Exeptions;

namespace EShop.Domain.CategoryAggregate;

public class Category: BaseAggregate
{
    public Category(Guid id, string name, IReadOnlyCollection<string> requiredAttributes) : base(id)
    {

        if (string.IsNullOrEmpty(name)) throw new NoCategoryName();
        if (requiredAttributes.Count == 0) throw new NoCategoryRequiredAttributes();
        
        Name = name;
        RequiredAttributes = requiredAttributes;
    }
    public string Name { get; }
    public IReadOnlyCollection<string> RequiredAttributes { get; }
}
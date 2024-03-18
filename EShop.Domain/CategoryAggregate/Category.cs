using EShop.Domain.CategoryAggregate.Exeptions;

namespace EShop.Domain.CategoryAggregate;

public class Category : BaseAggregate
{
    private string _name;
    private IReadOnlyCollection<string> _requiredAttributes;
    public required string Name
    {
        get => _name;
        init
        {
            if (string.IsNullOrEmpty(value)) throw new NoCategoryNameException();
            _name = value;
        }
    }
    public required IReadOnlyCollection<string> RequiredAttributes
    {
        get => _requiredAttributes;
        init
        {
            if (value.Count == 0) throw new NoCategoryRequiredAttributesException();
            _requiredAttributes = value;
        }
    }
    /*
    private IReadOnlyDictionary<string, AttributeValues> _requiredAttributes;
    
    public required IReadOnlyDictionary<string, AttributeValues> RequiredAttributes
    {
        get => _requiredAttributes;
        init
        {
            if (value.Count == 0) throw new NoCategoryRequiredAttributesException();
            _requiredAttributes = value;
        }
    }*/
}

/*ValueObject
public class AttributeValues
{
    public required IReadOnlyDictionary<string, int> Values { get; init; }
}*/
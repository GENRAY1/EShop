using EShop.Domain.CategoryAggregate;
using EShop.Domain.ProductAggregate.Exceptions;

namespace EShop.Domain.ProductAggregate;

public class Product : BaseAggregate
{
    private const int MAX_NAME_LENGTH = 30; 
    private const int MIN_NAME_LENGTH = 30; 
    
    
    private string _name;
    private decimal _cost;
    private int _count;
    private Guid _categoryId;
    
    public Product(Category category, IReadOnlyDictionary<string, string> attributes) 
    {
        if (category.RequiredAttributes.Any(c => !attributes.ContainsKey(c))) throw new NoProductRequiredAttributesException();
        
        _categoryId = category.Id;
        ProductAttributes = attributes;
    }
    
    public required string Name
    {
        get=>_name;
        set
        {
            if(value.Length > MAX_NAME_LENGTH || value.Length > MIN_NAME_LENGTH) throw new NoProductNameException();
            _name = value;
        }
    }

    public required decimal Cost
    {
        get => _cost;
        set
        {
            if(value <= 0) throw new IncorrectProductCostException();
            _cost = value;
        }
    }

    public required int Count
    {
        get => _count;
        set
        {
            if(value <= 0) throw new IncorrectProductCountException();
            _count = value;
        }
    }


    public Guid CategoryId => _categoryId;
    public IReadOnlyDictionary<string, string> ProductAttributes { get; }
}

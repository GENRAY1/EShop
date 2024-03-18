using EShop.Domain.CategoryAggregate;
using EShop.Domain.ProductAggregate.Exceptions;

namespace EShop.Domain.ProductAggregate;

public class Product : BaseAggregate
{
    private const int MAX_NAME_LENGTH = 30; 
    private const int MIN_NAME_LENGTH = 6; 
    
    
    private string _name;
    private decimal _cost;
    private int _count;
    private Guid _categoryId;
    private IReadOnlyDictionary<string, string> _productAttributes;
    
    
    public required IReadOnlyDictionary<string, string> ProductAttributes
    {
        get => _productAttributes;
        init
        {
            if (value.Count == 0) throw new NoProductsAttributesException();
            _productAttributes = value;
        }
    }

    public required Category Category
    {
        init
        {
            if (value.RequiredAttributes.Any(c => !ProductAttributes.ContainsKey(c))) throw new NoProductRequiredAttributesException();
            _categoryId = value.Id;
        }
    }
    public Guid CategoryId => _categoryId; 
    public required string Name
    {
        get=>_name;
        set
        {
            if(value.Length > MAX_NAME_LENGTH || value.Length < MIN_NAME_LENGTH) throw new IncorrectProductNameException(MIN_NAME_LENGTH, MAX_NAME_LENGTH);
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
}

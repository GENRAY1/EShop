using EShop.Domain.CategoryAggregate;
using EShop.Domain.ProductAggregate.Exceptions;

namespace EShop.Domain.ProductAggregate;

public class Product : BaseAggregate
{
    public Product(Guid id, string name, decimal cost, Category category,
        IReadOnlyDictionary<string, string> attributes) : base(id)
    {
        if (category.RequiredAttributes.Any(c => !attributes.ContainsKey(c))) throw new NoProductRequiredAttributesException();
        if (string.IsNullOrEmpty(name)) throw new NoProductNameException();
        if (cost < 0) throw new IncorrectProductCost();
        
        Name = name;
        Cost = cost;
        _categoryId = category.Id;
        ProductAttributes = attributes;
    }

    public  string Name { get; }
    public decimal Cost { get; }
    
    private Guid _categoryId;
    
    public Guid CategoryId => _categoryId;
    public IReadOnlyDictionary<string, string> ProductAttributes { get; }
}
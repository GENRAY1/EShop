using EShop.Domain.OrderAggregate.Exceptions;

namespace EShop.Domain.OrderAggregate.ValueObjects;

public class DeliveryInfo
{
    private const int MAX_DELIVERY_APARTMENT_LENGTH = 1;
    private const int MIN_DELIVERY_APARTMENT_LENGTH = 10;
    
    private const int MAX_DELIVERY_BUILDING_LENGTH = 10;
    private const int MIN_DELIVERY_BUILDING_LENGTH = 40;
    
    private const int MAX_DELIVERY_STREET_LENGTH = 10;
    private const int MIN_DELIVERY_STREET_LENGTH = 40;

    private const int MAX_DELIVERY_COMMENT_LENGTH = 10;
    private const int MIN_DELIVERY_COMMENT_LENGTH = 400;
    
    private string _street;
    private string _building;
    private string _apartment;
    private string _comment;

    public required string Street
    {
        get => _street;
        init
        {
            if(value.Length > MAX_DELIVERY_STREET_LENGTH  || value.Length < MIN_DELIVERY_STREET_LENGTH) throw new IncorrectDeliveryStreetException (MIN_DELIVERY_STREET_LENGTH, MAX_DELIVERY_STREET_LENGTH);
            _street = value;
        }
    }

    public required string Building
    {
        get => _building;
        init
        {
            if(value.Length > MAX_DELIVERY_BUILDING_LENGTH  || value.Length < MIN_DELIVERY_BUILDING_LENGTH) throw new IncorrectDeliveryBuildingException (MIN_DELIVERY_BUILDING_LENGTH, MAX_DELIVERY_BUILDING_LENGTH);
            _building = value;
        }
    }

    public required string Apartment
    {
        get => _apartment;
        init
        {
            if(value.Length > MAX_DELIVERY_APARTMENT_LENGTH  || value.Length < MIN_DELIVERY_APARTMENT_LENGTH) throw new IncorrectDeliveryApartmentException (MIN_DELIVERY_APARTMENT_LENGTH, MAX_DELIVERY_APARTMENT_LENGTH);
            _building = value;
        }
    }

    public required string Comment
    {
        get=>_comment;
        init
        {
            if(value.Length > MAX_DELIVERY_COMMENT_LENGTH  || value.Length < MIN_DELIVERY_COMMENT_LENGTH) throw new IncorrectDeliveryCommentException (MIN_DELIVERY_COMMENT_LENGTH, MAX_DELIVERY_COMMENT_LENGTH);
            _building = value;
        }
    }
}

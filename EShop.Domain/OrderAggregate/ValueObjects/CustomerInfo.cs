using EShop.Domain.OrderAggregate.Exceptions;

namespace EShop.Domain.OrderAggregate.ValueObjects;

public class CustomerInfo
{
    private const int MAX_CUSTOMER_NAME_LENGTH = 26;
    private const int MIN_CUSTOMER_NAME_LENGTH = 2;
    private const int CORRECT_CUSTOMER_PHONE_LENGTH = 11;
    
    private string _name;
    private string _phone;

    public required string Name
    {
        get => _name;
        init
        {
            if(value.Length > MAX_CUSTOMER_NAME_LENGTH  || value.Length < MIN_CUSTOMER_NAME_LENGTH) throw new IncorrectCustomerNameException(MIN_CUSTOMER_NAME_LENGTH, MAX_CUSTOMER_NAME_LENGTH);
            _name = value;
        }
    }

    public required string Phone
    {
        get => _phone;
        init
        {
            if(value.Length != CORRECT_CUSTOMER_PHONE_LENGTH) throw new IncorrectCustomerPhoneException(CORRECT_CUSTOMER_PHONE_LENGTH);
            _phone = value;
        }
    }
}
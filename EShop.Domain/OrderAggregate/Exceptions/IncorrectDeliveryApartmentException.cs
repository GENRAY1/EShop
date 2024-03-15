namespace EShop.Domain.OrderAggregate.Exceptions;

public class IncorrectDeliveryApartmentException(int minLength , int maxLength):Exception($"The minimum number of characters should be {minLength} and maximum {maxLength};");

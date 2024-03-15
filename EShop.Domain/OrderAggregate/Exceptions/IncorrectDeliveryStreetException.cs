namespace EShop.Domain.OrderAggregate.Exceptions;

public class IncorrectDeliveryStreetException(int minLength , int maxLength):Exception($"The minimum number of characters should be {minLength} and maximum {maxLength};");

using EShop.Domain.OrderAggregate.ValueObjects;

namespace EShop.Domain.OrderAggregate.Exceptions;

public class IncorrectCustomerNameException(int minNameLength , int maxNameLength):Exception($"The minimum number of characters should be {minNameLength} and maximum {maxNameLength};");
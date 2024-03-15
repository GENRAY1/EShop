using EShop.Domain.OrderAggregate.ValueObjects;

namespace EShop.Domain.OrderAggregate.Exceptions;

public class IncorrectCustomerPhoneException(int correctPhoneLength) : Exception($"The phone number must have {correctPhoneLength} digits");
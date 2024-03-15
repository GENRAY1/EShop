namespace EShop.Domain.OrderAggregate.Exceptions;

public class NoProductsInOrderException() : Exception("The order cannot be without products");

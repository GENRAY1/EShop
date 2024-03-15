namespace EShop.Domain.ProductAggregate.Exceptions;

public class IncorrectProductCost() : Exception("The Cost of the product cannot be less than zero");

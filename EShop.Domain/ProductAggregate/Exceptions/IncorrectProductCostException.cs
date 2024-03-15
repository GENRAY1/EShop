namespace EShop.Domain.ProductAggregate.Exceptions;

public class IncorrectProductCostException() : Exception("The Cost of the product cannot be less than zero");

namespace EShop.Domain.CategoryAggregate.Exeptions;

public class NoCategoryNameException() : Exception("Category name cannot be empty or null");

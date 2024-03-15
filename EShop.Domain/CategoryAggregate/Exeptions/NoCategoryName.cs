namespace EShop.Domain.CategoryAggregate.Exeptions;

public class NoCategoryName() : Exception("Category name cannot be empty or null");

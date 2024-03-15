namespace EShop.Domain.CategoryAggregate.Exeptions;

public class NoCategoryRequiredAttributes() : Exception("Category required attributes cannot be empty");

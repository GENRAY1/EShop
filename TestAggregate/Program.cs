using EShop.Domain.CategoryAggregate;
using EShop.Domain.OrderAggregate;
using EShop.Domain.OrderAggregate.ValueObjects;
using EShop.Domain.ProductAggregate;


Category categorySmartphones = new Category()
{
    Name = "Smartphones",
    RequiredAttributes = new string[]
    {
        "ОЗУ",
        "Процессор",
        "Диагональ экрана",
        "Аккумулятор"
    }
};

Product iphone = new Product
{
    ProductAttributes = new Dictionary<string, string>
    {
        ["ОЗУ"] = "6 ГБ",
        ["Процессор"] = "4-ядерный",
        ["Диагональ экрана"] = "5.5",
        ["Аккумулятор"] = "3000 мАч"
    },
    Name = "Iphone 11",
    Cost = 10000,
    Count = 10,
    Category = categorySmartphones
};

Product xiaomi = new Product()
{
    ProductAttributes = new Dictionary<string, string>
    {
        ["ОЗУ"] = "8 ГБ",
        ["Процессор"] = "8-ядерный",
        ["Диагональ экрана"] = "6.5",
        ["Аккумулятор"] = "5000 мАч"
    },
    Name = "xiaomi 11",
    Cost = 10000,
    Count = 5,
    Category = categorySmartphones
};

Order order = new Order()
{
    CustomerInfo = new CustomerInfo{Name = "nn", Phone = "79271111111"},
    DeliveryInfo = null,
    Products = new[] {iphone, xiaomi}
};

order.Complite();
var readOnlyCollection = order.OrderItems;
Console.WriteLine($"Заказ {order.Id} собран, на сумму {order.TotalCost}, дата создания {order.CreationTime}\n" +
                  $"Заказчик {order.CustomerInfo.Name}, телефон {order.CustomerInfo.Phone}\n");
foreach (var product in readOnlyCollection)
{
    Console.WriteLine($"Id: {product.Id} {product.Count} шт.");
}
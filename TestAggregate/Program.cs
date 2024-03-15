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

Product iphone = new Product(
    categorySmartphones,
    new Dictionary<string, string>
    {
        ["ОЗУ"] = "8 ГБ",
        ["Процессор"] = "6-ядерный",
        ["Диагональ экрана"] = "5.5",
        ["Аккумулятор"] = "3000 мАч"
    }
) { Name = "Iphone 13", Cost = 10000, Count = 10 };

Product xiaomi = new Product(
    categorySmartphones,
    new Dictionary<string, string>
    {
        ["ОЗУ"] = "12 ГБ",
        ["Процессор"] = "8-ядерный",
        ["Диагональ экрана"] = "6.5",
        ["Аккумулятор"] = "5000 мАч"
    }
) { Name = "Xiaomi 13T", Cost = 10000, Count = 10 };


Order order = new Order(
    new Product[]
    {
        iphone,
        xiaomi
    }
)
{
    CustomerInfo = new CustomerInfo{Name = "nn", Phone = "79271111111"},
    DeliveryInfo = null
};

order.Complite();
Console.WriteLine($"Заказ {order.Id} собран, на сумму {order.TotalCost}, дата создания {order.CreationTime}\n" +
                  $"Заказчик {order.CustomerInfo.Name}, телефон {order.CustomerInfo.Phone}\n");


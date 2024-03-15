using EShop.Domain.CategoryAggregate;
using EShop.Domain.OrderAggregate;
using EShop.Domain.ProductAggregate;

Category categorySmartphones = new Category(
    Guid.NewGuid(),
    "Smartphones",
    new string[]
    {
        "ОЗУ",
        "Процессор",
        "Диагональ экрана",
        "Аккумулятор"
    }
);

Product iphone = new Product(
    Guid.NewGuid(),
    "Iphone 13",
    1000,
    categorySmartphones,
    new Dictionary<string, string>
    {
        { "ОЗУ", "6 ГБ" },
        { "Процессор", "6-ядерный" },
        { "Диагональ экрана", "6.1" },
        { "Аккумулятор", "3000 мАч" }
    }
);

Product xiaomi = new Product(
    Guid.NewGuid(),
    "Xiaomi Redmi 10",
    1000,
    categorySmartphones,
    new Dictionary<string, string>
    {
        { "ОЗУ", "6 ГБ" },
        { "Процессор", "6-ядерный" },
        { "Диагональ экрана", "6.1" },
        { "Аккумулятор", "3000 мАч" }
    }
);

Order order = new Order(
    Guid.NewGuid(),
    new Product[]
    {
        iphone,
        xiaomi
    }
);

order.Complite();
Console.WriteLine($"Заказ{order.Id} собран, на сумму {order.TotalCost}, дата создания {order.CreationTime}");


Order order2 = new Order(
    
    Guid.NewGuid(),
    new Product[]
    {}
);
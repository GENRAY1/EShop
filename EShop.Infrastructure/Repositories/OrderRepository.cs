using EShop.Domain.Abstractions.Repositories;
using EShop.Domain.OrderAggregate;

namespace EShop.Infrastructure.Repositories;

public class OrderRepository : IRepository<Order>
{
    public Task AddAsync(Order entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Order entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Order> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
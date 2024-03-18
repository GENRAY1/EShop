using EShop.Domain.OrderAggregate;

namespace EShop.Domain.Abstractions.Repositories;

public interface IRepository<T> 
where T : class
{ 
    Task AddAsync(T entity); 
    Task UpdateAsync(T entity); 
    Task DeleteAsync(Guid id); 
    Task<Order> GetAsync(Guid id);
}
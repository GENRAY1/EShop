using EShop.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
namespace EShop.Infrastructure.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ProductOrder>()
            .HasKey(po => new { po.ProductId, po.OrderId });

        modelBuilder.Entity<ProductOrder>()
            .HasOne(po => po.Product)
            .WithMany(p => p.ProductOrders)
            .HasForeignKey(po => po.ProductId);

        modelBuilder.Entity<ProductOrder>()
            .HasOne(po => po.Order)
            .WithMany(o => o.ProductOrders)
            .HasForeignKey(po => po.OrderId);
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<ProductOrder> ProductOrders { get; set; }
    
}
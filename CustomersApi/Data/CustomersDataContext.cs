

using CustomersApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomersApi.Data;


public class CustomersDataContext: DbContext
{
    public CustomersDataContext(DbContextOptions<CustomersDataContext> options): base(options) { }

    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
                .HasOne(e => e.Address)
                .WithOne(e => e.Customer)
                .HasForeignKey<Customer>(e => e.AddressId)
                .IsRequired();                
        
        modelBuilder.Entity<Customer>()
                .HasOne(e => e.ShoppingCart)
                .WithOne(e => e.Customer)
                .HasForeignKey<Customer>(e => e.ShoppingCartId)
                .IsRequired();

    }

}

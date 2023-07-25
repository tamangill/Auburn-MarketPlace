using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using AuburnMarketPlace.Models;

namespace AuburnMarketPlace.Data;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
    public DbSet<User> User { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<Cart> Cart { get; set; } = default!;
    public DbSet<CartItem> CartItem { get; set; } = default!;
    public DbSet<AuburnMarketPlace.Models.Order> Order { get; set; } = default!;
     public DbSet<OrderDetail> OrderDetails { get; set; }
}

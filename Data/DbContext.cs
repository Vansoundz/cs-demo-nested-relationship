using Microsoft.EntityFrameworkCore;
using Shopr.Models;

namespace ShopR.Models;

public class ShoprContext : DbContext
{
    public ShoprContext(DbContextOptions<ShoprContext> options)
        : base(options)
    {
    }

    public DbSet<Cart> Cart { get; set; }
}

using Microsoft.EntityFrameworkCore;
using Shopr.Models;
using ShopR.Models;

namespace Shopr.Services
{
    public class CartService : ICartService
    {
        private readonly ShoprContext db;

        public CartService(ShoprContext _dbContext)
        {
            db = _dbContext;
        }
        public async Task<List<Cart>> GetCart()
        {
            var cart = await db.Cart.Include(c => c.Products).ThenInclude(p => p.Product).ToListAsync();
            return cart;
        }
    }
}
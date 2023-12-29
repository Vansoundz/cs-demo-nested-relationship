
using Shopr.Models;

namespace Shopr.Services
{
    public interface ICartService
    {
        Task<List<Cart>> GetCart();
    }
}
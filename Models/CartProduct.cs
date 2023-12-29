namespace Shopr.Models;

public class CartProduct
{
    public long Id { get; set; }
    public long ProductId { get; set; }
    public long CartId { get; set; }
    public int Quantity { get; set; }
    public Product? Product { get; set; }
}
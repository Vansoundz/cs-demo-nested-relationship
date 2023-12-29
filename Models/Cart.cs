namespace Shopr.Models;

public class Cart
{
    public long Id { get; set; }
    public DateTime Date { get; set; }
    public List<CartProduct> Products { get; set; }

}
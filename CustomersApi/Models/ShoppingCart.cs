namespace CustomersApi.Models;

public class ShoppingCart
{
    public int Id { get; set; }
    public decimal Total { get; set; } = decimal.Zero;
    
    public List<int> Products { get; set;}

    public Customer Customer { get; set; }
}

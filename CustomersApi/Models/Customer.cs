namespace CustomersApi.Models;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public int AddressId { get; set; }
    public Address Address { get; set; } = null!;
    
    public string Phone { get; set; }

    public int ShoppingCartId { get; set; }
    public ShoppingCart ShoppingCart { get; set; } = null!;

}

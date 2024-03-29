using ProductsApi.Modelsl;

namespace ProductsApi.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; } = decimal.Zero;
    
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public int VendorId { get; set; }
    public Vendor Vendor { get; set; }



}

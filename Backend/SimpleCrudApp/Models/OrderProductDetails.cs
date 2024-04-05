
namespace SimpleCrudApp.Models;


public class OrderDetails
{
    public int Id { get; set; }

    public string ClientName { get; set; }
    
    public string ClientEmail { get; set; }
    
    public bool Paid { get; set; }
    
    public decimal TotalValue { get; set; }
    
    public IEnumerable<ProductDetails> OrderProduct { get; set; }

}

public class ProductDetails
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
}


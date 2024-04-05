
namespace SimpleCrudApp.Models;

public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public decimal Value { get; set; }

    public List<OrderProduct>? OrderProducts { get; set; }
}
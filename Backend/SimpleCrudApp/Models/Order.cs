
namespace SimpleCrudApp.Models;

public class Order
{
    public int Id { get; set; }
    public string ClientName { get; set; }
    public string ClientEmail { get; set; }
    
    public DateTime CreationDate { get; set; }
    public bool Paid { get; set; }

    public List<OrderProduct>? OrderProducts { get; set; }
}

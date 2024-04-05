using Microsoft.EntityFrameworkCore;
using SimpleCrudApp.Models;

namespace SimpleCrudApp.Services;

public class OrderDetailsService
{
    private readonly AppDbContext _dbContext;

    public OrderDetailsService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<OrderDetails> GetOrderDetailsByIdAsync(int id)
    {
        var order = await _dbContext.Orders
            .Include(o => o.OrderProducts)
            .ThenInclude(op => op.Product)
            .FirstOrDefaultAsync(o => o.Id == id);        
        if (order == null)
        {
            return null;
        } 
        
        var totalValue = order.OrderProducts?.Sum(op => op.Quantity * op.Product.Value) ?? 0;

        
        var orderProductDetails = new OrderDetails
        {
            Id = order.Id,
            ClientName = order.ClientName,
            ClientEmail = order.ClientEmail,
            Paid = order.Paid,
    
            TotalValue = order.OrderProducts?.Sum(op => op.Quantity * op.Product.Value) ?? 0,
            OrderProduct = order.OrderProducts?.Select(op => new ProductDetails
            {
                Id = op.Id,
                ProductId = op.ProductId,
                ProductName = op.Product?.ProductName,
                UnitPrice = op.Product?.Value ?? 0,
                Quantity = op.Quantity
            }).ToList() ?? new List<ProductDetails>()
        };

        return orderProductDetails;
    }
}
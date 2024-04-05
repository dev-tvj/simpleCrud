using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleCrudApp.Models;
using SimpleCrudApp.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrudApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderProductsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public OrderProductsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/OrderProducts
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<OrderProduct>>> GetOrderProducts()
        // {
        //     return await _dbContext.OrdersProducts.ToListAsync();
        // }
        //
        // // GET: api/OrderProducts/5
        // [HttpGet("{id}")]
        // public async Task<ActionResult<OrderProduct>> GetOrderProduct(int id)
        // {
        //     var orderProduct = await _dbContext.OrdersProducts.FindAsync(id);
        //
        //     if (orderProduct == null)
        //     {
        //         return NotFound();
        //     }
        //
        //     return orderProduct;
        // }
        //
        // // POST: api/OrderProducts
        // [HttpPost]
        // public async Task<ActionResult<OrderProduct>> PostOrderProduct(OrderProduct orderProduct)
        // {
        //     _dbContext.OrdersProducts.Add(orderProduct);
        //     await _dbContext.SaveChangesAsync();
        //
        //     return CreatedAtAction(nameof(GetOrderProduct), new { id = orderProduct.Id }, orderProduct);
        // }
        //
        // // PUT: api/OrderProducts/5
        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutOrderProduct(int id, OrderProduct orderProduct)
        // {
        //     if (id != orderProduct.Id)
        //     {
        //         return BadRequest();
        //     }
        //
        //     _dbContext.Entry(orderProduct).State = EntityState.Modified;
        //
        //     try
        //     {
        //         await _dbContext.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!OrderProductExists(id))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }
        //
        //     return NoContent();
        // }
        //
        // // DELETE: api/OrderProducts/5
        // [HttpDelete("{id}")]
        // public async Task<IActionResult> DeleteOrderProduct(int id)
        // {
        //     var orderProduct = await _dbContext.OrdersProducts.FindAsync(id);
        //     if (orderProduct == null)
        //     {
        //         return NotFound();
        //     }
        //
        //     _dbContext.OrdersProducts.Remove(orderProduct);
        //     await _dbContext.SaveChangesAsync();
        //
        //     return NoContent();
        // }
        //
        // private bool OrderProductExists(int id)
        // {
        //     return _dbContext.OrdersProducts.Any(e => e.Id == id);
        // }
    }
}

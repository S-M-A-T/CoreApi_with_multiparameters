using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TestCoreApi2.Controllers
{
    [Route("api/[controller]")] // Route for accessing the Products API
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context; // DbContext for database operations

        // Constructor to inject the ApplicationDbContext
        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/products
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            // Fetch all products from the database
            var products = await _context.Products.ToListAsync();
            return Ok(products); // Return the list of products
        }

        // GET: api/products/{category}/{minPrice}
        [HttpGet("{category}/{minPrice}")]
        public async Task<IActionResult> GetProductsByRoute(string category, decimal minPrice)
        {
            // Fetch products filtered by category and minimum price
            var filteredProducts = await _context.Products
                .Where(p => p.Category == category && p.Price >= minPrice)
                .ToListAsync();

            return Ok(filteredProducts); // Return the filtered list of products
        }
    }
}

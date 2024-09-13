using Microsoft.EntityFrameworkCore;
using TestCoreApi2.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // DbSet for Products, representing the Products table in the database
    public DbSet<Product> Products { get; set; }

    // Configure the model properties
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Set precision and scale for the Price property
        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasColumnType("decimal(18,2)"); // 18 total digits, 2 decimal places
    }
}

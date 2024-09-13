using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // Register the ApplicationDbContext with SQL Server

builder.Services.AddControllers(); // Add MVC controllers to the service container
builder.Services.AddEndpointsApiExplorer(); // Add support for endpoint exploration
builder.Services.AddSwaggerGen(); // Add Swagger generation for API documentation

var app = builder.Build(); // Build the application

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Enable Swagger in Development
    app.UseSwaggerUI(); // Enable Swagger UI in Development
}

app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS
app.UseAuthorization(); // Enable authorization middleware
app.MapControllers(); // Map controller routes
app.Run(); // Run the application

using ServerApp.Data;
using Microsoft.Extensions.Caching.Memory;
using ServerApp.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddMemoryCache(); // This line activating caching service for serverside.

var app = builder.Build();

app.UseCors();

app.MapGet("/api/products", (IMemoryCache cache) =>
{
    const string cacheKey = "products_cache";  

    // Try to read from cache
    if (!cache.TryGetValue(cacheKey, out List<Product>? products))
    {
        // Cache miss: load from ProductData
        products = ProductData.GetProducts();

        // Cache for 5 minutes
        var options = new MemoryCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
        };

        cache.Set(cacheKey, products, options);
    }

    return products;
});


app.Run();
using ServerApp.Models;

namespace ServerApp.Data;

public static class ProductData
{    
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Price = 1200.50,
                    Stock = 25,
                    Category = new Category { Id = 101, Name = "Electronics" }
                },
                new Product
                {
                    Id = 2,
                    Name = "Headphones",
                    Price = 50.00,
                    Stock = 100,
                    Category = new Category { Id = 102, Name = "Accessories" }
                }
            };
        }
}


using System.Collections.Generic;
using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name = "Iphone X",
                    Summary = "abc",
                    Description = "acc",
                    ImageFile = "product-1.png",
                    Category = "Smart Phone",
                    Price = 9.50M
                },
                new Product()
                {
                    Name = "Iphone 12",
                    Summary = "abc",
                    Description = "bcc",
                    ImageFile = "product-2.png",
                    Category = "Smart Phone",
                    Price = 11.50M
                },
                
            };
        }
    }
}
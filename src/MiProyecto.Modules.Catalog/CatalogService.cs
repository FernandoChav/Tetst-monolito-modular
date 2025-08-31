using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiProyecto.Modules.Catalog
{
    public class CatalogService : ICatalogApi
    {
        public Task<ProductDto> GetProductInfoAsync(string productId)
        {
            Console.WriteLine($" CATÁLOGO: Obteniendo info del producto {productId}.");
            
            
            var product = new ProductDto(productId, "Laptop Gamer", 1500.00m);
            
            return Task.FromResult(product);
        }
    }
}
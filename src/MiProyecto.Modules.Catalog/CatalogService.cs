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
            Console.WriteLine($"📦 CATÁLOGO: Obteniendo info del producto {productId}.");
            
            // En una aplicación real, aquí harías una consulta a la base de datos.
            // Por ahora, devolvemos datos de ejemplo.
            var product = new ProductDto(productId, "Laptop Gamer", 1500.00m);
            
            return Task.FromResult(product);
        }
    }
}
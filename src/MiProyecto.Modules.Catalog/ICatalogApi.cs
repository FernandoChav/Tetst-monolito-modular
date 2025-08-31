namespace MiProyecto.Modules.Catalog;
public record ProductDto(string Id, string Name, decimal Price);
public interface ICatalogApi
{
    Task<ProductDto> GetProductInfoAsync(string productId);
}

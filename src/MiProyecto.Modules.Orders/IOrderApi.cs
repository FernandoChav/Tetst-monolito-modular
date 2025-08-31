namespace MiProyecto.Modules.Orders;

public interface IOrderApi
{
    Task CreateNewOrderAsync(string userId, List<object> items);
}

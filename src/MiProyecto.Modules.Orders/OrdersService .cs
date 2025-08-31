using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiProyecto.Modules.Catalog;
using MediatR;
using MiProyecto.SharedKernel.Events;
namespace MiProyecto.Modules.Orders
{
    public class OrdersService(ICatalogApi catalogApi, IPublisher publisher) : IOrderApi
    {
        
        private readonly ICatalogApi _catalogApi = catalogApi;
        private readonly IPublisher _publisher = publisher;
        public async Task CreateNewOrderAsync(string userId, List<object> items)
        {
            Console.WriteLine($" PEDIDOS: Creando nuevo pedido para el usuario {userId}.");

            var productInfo = await _catalogApi.GetProductInfoAsync("prod-123");
            var total = productInfo.Price * 2;
            Console.WriteLine($"--> PEDIDOS: El total es ${total}, calculado usando el precio '${productInfo.Price}' desde el módulo de Catálogo.");

            var newOrderId = Guid.NewGuid();

            
            var orderEvent = new OrderCreatedEvent(newOrderId, userId, total);
            await _publisher.Publish(orderEvent);
            Console.WriteLine("--> PEDIDOS: Evento 'OrderCreatedEvent' publicado en el bus.");
        }
    }
}
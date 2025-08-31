
using MediatR;

using System.Threading;
using System.Threading.Tasks;

using MiProyecto.SharedKernel.Events; 

namespace MiProyecto.Modules.Catalog.Handlers;


public class OrderCreatedHandler : INotificationHandler<OrderCreatedEvent>
{
    
    public Task Handle(OrderCreatedEvent notification, CancellationToken cancellationToken)
    {
        Console.WriteLine("--- EVENTO RECIBIDO EN OTRO MÓDULO ---");
        Console.WriteLine($" CATÁLOGO: ¡Evento 'OrderCreatedEvent' recibido!");
        Console.WriteLine($" CATÁLOGO: Reduciendo stock para el pedido {notification.OrderId}.");
        
        Console.WriteLine("------------------------------------");
        return Task.CompletedTask;
    }

}
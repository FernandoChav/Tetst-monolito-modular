
using MediatR;
 // Importamos la definición del evento
using System.Threading;
using System.Threading.Tasks;
// using MiProyecto.Modules.Orders.Events;
using MiProyecto.SharedKernel.Events; // Update to correct namespace if 'OrderCreatedEvent' is here

namespace MiProyecto.Modules.Catalog.Handlers;

// Esta clase implementa INotificationHandler<T>, donde T es el evento que queremos escuchar.
public class OrderCreatedHandler : INotificationHandler<OrderCreatedEvent>
{
    // MediatR encontrará esta clase y llamará a este método automáticamente
    // cuando se publique un evento de tipo OrderCreatedEvent.
    public Task Handle(OrderCreatedEvent notification, CancellationToken cancellationToken)
    {
        Console.WriteLine("--- EVENTO RECIBIDO EN OTRO MÓDULO ---");
        Console.WriteLine($"📦 CATÁLOGO: ¡Evento 'OrderCreatedEvent' recibido!");
        Console.WriteLine($"📦 CATÁLOGO: Reduciendo stock para el pedido {notification.OrderId}.");
        // Aquí iría la lógica real, como actualizar la base de datos.
        Console.WriteLine("------------------------------------");
        return Task.CompletedTask;
    }

}
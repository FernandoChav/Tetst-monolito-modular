using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
namespace MiProyecto.SharedKernel.Events
{
    public record OrderCreatedEvent(Guid OrderId, string UserId, decimal Total) : INotification;
}
using Enee.Core.Events;

namespace EneePrueba.Domain.Modules.Factura.Events.FacturaCreada;

public class NotificarInvolucradoss : IEventHandler<Features.CrearFactura.FacturaCreada>
{
    public Task Handle(Features.CrearFactura.FacturaCreada @event)
    {
        Console.WriteLine("Notificacion de factura");
        return Task.CompletedTask;
    }
}

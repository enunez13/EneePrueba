using Enee.Core.CQRS.Command;

namespace EneePrueba.Domain.Modules.Factura.Features.CrearFactura;

public record CrearFacturaCommand(Guid Id, string Numero, DateOnly FechaEmision, string EstadoId)
    : ICommand;

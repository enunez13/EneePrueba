using Enee.Core.CQRS.Command;

namespace EneePrueba.Domain.Modules.Almacen.Features.EliminarAlmacen;

public record EliminarAlmacenCommand(Guid Id) : ICommand;

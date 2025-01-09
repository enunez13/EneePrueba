using Enee.Core.CQRS.Command;

namespace EneePrueba.Domain.Prueba.EstadoTareas.EliminarEstadoTarea;

public record EliminarEstadoTareaCommand(Guid Id) : ICommand;

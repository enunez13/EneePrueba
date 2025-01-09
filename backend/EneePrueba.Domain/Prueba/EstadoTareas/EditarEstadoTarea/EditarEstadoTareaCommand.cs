using Enee.Core.CQRS.Command;

namespace EneePrueba.Domain.Prueba.EstadoTareas.EditarEstadoTarea;

public record EditarEstadoTareaCommand(Guid Id, string Nombre) : ICommand;

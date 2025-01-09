using Enee.Core.CQRS.Command;

namespace EneePrueba.Domain.Prueba.EstadoTareas.CreateEstadoTarea;

public record EstadoTareaCommand(Guid Id, string Nombre) : ICommand;

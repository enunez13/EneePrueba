using Enee.Core.CQRS.Command;

namespace EneePrueba.Domain.Prueba.Tareas.EditarTareas;

public record EditarTareaCommand(
    Guid Id,
    string Nombre,
    string Descripcion,
    DateOnly FechaInicio,
    DateOnly FechaFin,
    Guid TipoTareaId,
    Guid EstadoId,
    Guid PrioridadId
) : ICommand;

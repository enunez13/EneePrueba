using Enee.Core.CQRS.Command;
using static EneePrueba.Domain.Prueba.Tareas.TareaRoot;

namespace EneePrueba.Domain.Prueba.Tareas.CrearTarea;

public record CrearTareaCommand(
    Guid Id,
    string Nombre,
    string Descripcion,
    DateOnly FechaInicio,
    DateOnly FechaFin,
    Guid TipoTareaId,
    Guid EstadoId,
    Guid PrioridadId
) : ICommand;

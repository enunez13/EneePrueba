using Enee.Core.CQRS.Command;

namespace EneePrueba.Domain.Prueba.PrioridadTareas.EliminarPrioridad
{
    public record EliminarPrioridadTareaCommand(Guid Id) : ICommand;
}

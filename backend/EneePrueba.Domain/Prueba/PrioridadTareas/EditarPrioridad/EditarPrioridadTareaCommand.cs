using Enee.Core.CQRS.Command;

namespace EneePrueba.Domain.Prueba.PrioridadTareas.EditarPrioridad;

public record EditarPrioridadTareaCommand(Guid Id, string Nombre) : ICommand;

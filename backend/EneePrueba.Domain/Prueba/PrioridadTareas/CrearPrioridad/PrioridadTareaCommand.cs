using Enee.Core.CQRS.Command;

namespace EneePrueba.Domain.Prueba.PrioridadTareas.CrearPrioridad;

public record PrioridadTareaCommand(Guid Id, string Nombre) : ICommand;

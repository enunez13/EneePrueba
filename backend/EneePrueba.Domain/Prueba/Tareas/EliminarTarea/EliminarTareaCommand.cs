using Enee.Core.CQRS.Command;

namespace EneePrueba.Domain.Prueba.Tareas.EliminarTarea;

public record EliminarTareaCommand(Guid Id) : ICommand;

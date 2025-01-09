using Enee.Core.CQRS.Command;

namespace EneePrueba.Domain.Prueba.TipoTareas.EliminarTipoTarea;

public record EliminarTipoTareaCommand(Guid Id) : ICommand;

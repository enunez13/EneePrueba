using Enee.Core.CQRS.Command;

namespace EneePrueba.Domain.Prueba.TipoTareas.EditarTipoTarea;

public record EditarTipoTareaCommand(Guid Id, string Nombre) : ICommand;

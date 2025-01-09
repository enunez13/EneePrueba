using Enee.Core.CQRS.Command;

namespace EneePrueba.Domain.Prueba.TipoTareas.CrearTarea;

public record TipoTareaCommand(Guid Id, string Nombre) : ICommand;

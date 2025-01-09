using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Command;
using Enee.Core.Domain.Repository;

namespace EneePrueba.Domain.Prueba.Tareas.CrearTarea;

public class CrearTareaCommandHandler : ICommandHandler<CrearTareaCommand>
{
    public IWritableEventStoreRepository<TareaRoot> Repository { get; }

    public CrearTareaCommandHandler(IWritableEventStoreRepository<TareaRoot> repository)
    {
        Repository = repository;
    }

    public async Task Handle(CrearTareaCommand command)
    {
        var entity = new TareaRoot(
            command.Id,
            command.Nombre,
            command.Descripcion,
            command.FechaInicio,
            command.FechaFin,
            command.TipoTareaId,
            command.EstadoId,
            command.PrioridadId
        );
        await Repository.Create(entity);
    }
}

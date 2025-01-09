using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;
using Enee.Core.CQRS.Command;
using Enee.Core.Domain.Repository;
using Enee.Core.Domain.Specs;
using EneePrueba.Domain.Prueba.Tareas.Projections;

namespace EneePrueba.Domain.Prueba.Tareas.EditarTareas;

public class EditarTareaCommandHandler : ICommandHandler<EditarTareaCommand>
{
    private IWritableEventStoreRepository<TareaRoot> Store { get; }

    private IWritableRepository<Tarea> Repository { get; }

    public EditarTareaCommandHandler(
        IWritableEventStoreRepository<TareaRoot> store,
        IWritableRepository<Tarea> repository
    )
    {
        Store = store;
        Repository = repository;
    }

    public async Task Handle(EditarTareaCommand command)
    {
        ISpecification<Tarea> spec = new SpecificationGeneric<Tarea>();
        spec.Query.Where(x => x.Id == command.Id);
        Tarea tarea = await Repository.FirstOrDefault(spec);
        TareaRoot tareaRoot = await Store.Find(tarea.Id);
        tareaRoot.Editar(
            command.Nombre,
            command.Descripcion,
            command.FechaInicio,
            command.FechaFin,
            command.TipoTareaId,
            command.EstadoId,
            command.PrioridadId
        );
        await Store.Update(tareaRoot);
    }
}

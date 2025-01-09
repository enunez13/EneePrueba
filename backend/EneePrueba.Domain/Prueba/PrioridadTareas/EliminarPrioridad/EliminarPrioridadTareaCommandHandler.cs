using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;
using Enee.Core.CQRS.Command;
using Enee.Core.Domain.Repository;
using Enee.Core.Domain.Specs;
using EneePrueba.Domain.Prueba.PrioridadTareas.Projections;
using EneePrueba.Domain.Prueba.TipoTareas.EliminarTipoTarea;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;
using Marten.Linq.SoftDeletes;

namespace EneePrueba.Domain.Prueba.PrioridadTareas.EliminarPrioridad;

public class EliminarPrioridadTareaCommandHandler : ICommandHandler<EliminarPrioridadTareaCommand>
{
    private IWritableRepository<PrioridadTarea> Repository { get; }

    public EliminarPrioridadTareaCommandHandler(IWritableRepository<PrioridadTarea> repository)
    {
        Repository = repository;
    }

    public async Task Handle(EliminarPrioridadTareaCommand command)
    {
        ISpecification<PrioridadTarea> spec = new SpecificationGeneric<PrioridadTarea>();
        spec.Query.Where(x => x.Id == command.Id);
        PrioridadTarea prioridadTarea = await Repository.FirstOrDefault(spec);
        prioridadTarea.IsDeleted();
        await Repository.Update(prioridadTarea);
    }
}

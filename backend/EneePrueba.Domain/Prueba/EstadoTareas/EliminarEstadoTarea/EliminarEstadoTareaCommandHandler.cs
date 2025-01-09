using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;
using Enee.Core.CQRS.Command;
using Enee.Core.Domain.Repository;
using Enee.Core.Domain.Specs;
using EneePrueba.Domain.Prueba.EstadoTareas.Projections;
using EneePrueba.Domain.Prueba.TipoTareas.EliminarTipoTarea;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;
using Marten.Linq.SoftDeletes;

namespace EneePrueba.Domain.Prueba.EstadoTareas.EliminarEstadoTarea;

public class EliminarEstadoTareaCommandHandler : ICommandHandler<EliminarEstadoTareaCommand>
{
    private IWritableRepository<EstadoTarea> Repository { get; }

    public EliminarEstadoTareaCommandHandler(IWritableRepository<EstadoTarea> repository)
    {
        Repository = repository;
    }

    public async Task Handle(EliminarEstadoTareaCommand command)
    {
        ISpecification<EstadoTarea> spec = new SpecificationGeneric<EstadoTarea>();
        spec.Query.Where(x => x.Id == command.Id);
        EstadoTarea estdoTarea = await Repository.FirstOrDefault(spec);
        estdoTarea.IsDeleted();
        await Repository.Update(estdoTarea);
    }
}

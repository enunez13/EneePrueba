using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;
using Enee.Core.CQRS.Command;
using Enee.Core.Domain.Repository;
using Enee.Core.Domain.Specs;
using EneePrueba.Domain.Prueba.TipoTareas.EditarTipoTarea;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;
using Marten.Linq.SoftDeletes;

namespace EneePrueba.Domain.Prueba.TipoTareas.EliminarTipoTarea;

public class EliminarTipoTareaCommandHandler : ICommandHandler<EliminarTipoTareaCommand>
{
    private IWritableRepository<TipoTarea> Repository { get; }

    public EliminarTipoTareaCommandHandler(IWritableRepository<TipoTarea> repository)
    {
        Repository = repository;
    }

    public async Task Handle(EliminarTipoTareaCommand command)
    {
        ISpecification<TipoTarea> spec = new SpecificationGeneric<TipoTarea>();
        spec.Query.Where(x => x.Id == command.Id);
        TipoTarea tipoTarea = await Repository.FirstOrDefault(spec);
        tipoTarea.IsDeleted();
        await Repository.Update(tipoTarea);
    }
}

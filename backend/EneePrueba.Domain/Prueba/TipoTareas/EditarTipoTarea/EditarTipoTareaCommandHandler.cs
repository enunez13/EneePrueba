using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;
using Enee.Core.CQRS.Command;
using Enee.Core.Domain.Repository;
using Enee.Core.Domain.Specs;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;

namespace EneePrueba.Domain.Prueba.TipoTareas.EditarTipoTarea;

public class EditarTipoTareaCommandHandler : ICommandHandler<EditarTipoTareaCommand>
{
    private IWritableRepository<TipoTarea> Repository { get; }

    public EditarTipoTareaCommandHandler(IWritableRepository<TipoTarea> repository)
    {
        Repository = repository;
    }

    public async Task Handle(EditarTipoTareaCommand command)
    {
        ISpecification<TipoTarea> spec = new SpecificationGeneric<TipoTarea>();
        spec.Query.Where(x => x.Id == command.Id);
        TipoTarea tipoTarea = await Repository.FirstOrDefault(spec);
        tipoTarea.Nombre = command.Nombre;
        await Repository.Update(tipoTarea);
    }
}

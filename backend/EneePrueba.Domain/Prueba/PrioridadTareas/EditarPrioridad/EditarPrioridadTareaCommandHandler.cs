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
using EneePrueba.Domain.Prueba.TipoTareas.EditarTipoTarea;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;

namespace EneePrueba.Domain.Prueba.PrioridadTareas.EditarPrioridad;

public class EditarPrioridadTareaCommandHandler : ICommandHandler<EditarPrioridadTareaCommand>
{
    private IWritableRepository<PrioridadTarea> Repository { get; }

    public EditarPrioridadTareaCommandHandler(IWritableRepository<PrioridadTarea> repository)
    {
        Repository = repository;
    }

    public async Task Handle(EditarPrioridadTareaCommand command)
    {
        ISpecification<PrioridadTarea> spec = new SpecificationGeneric<PrioridadTarea>();
        spec.Query.Where(x => x.Id == command.Id);
        PrioridadTarea prioridadTarea = await Repository.FirstOrDefault(spec);
        prioridadTarea.Nombre = command.Nombre;
        await Repository.Update(prioridadTarea);
    }
}

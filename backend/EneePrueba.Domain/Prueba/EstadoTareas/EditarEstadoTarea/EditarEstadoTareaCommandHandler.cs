using Ardalis.Specification;
using Enee.Core.CQRS.Command;
using Enee.Core.Domain.Repository;
using Enee.Core.Domain.Specs;
using EneePrueba.Domain.Prueba.EstadoTareas.Projections;
using EneePrueba.Domain.Prueba.TipoTareas.EditarTipoTarea;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;

namespace EneePrueba.Domain.Prueba.EstadoTareas.EditarEstadoTarea;

public class EditarEstadoTareaCommandHandler : ICommandHandler<EditarEstadoTareaCommand>
{
    private IWritableRepository<EstadoTarea> Repository { get; }

    public EditarEstadoTareaCommandHandler(IWritableRepository<EstadoTarea> repository)
    {
        Repository = repository;
    }

    public async Task Handle(EditarEstadoTareaCommand command)
    {
        ISpecification<EstadoTarea> spec = new SpecificationGeneric<EstadoTarea>();
        spec.Query.Where(x => x.Id == command.Id);
        EstadoTarea estadoTarea = await Repository.FirstOrDefault(spec);
        estadoTarea.Nombre = command.Nombre;
        await Repository.Update(estadoTarea);
    }
}

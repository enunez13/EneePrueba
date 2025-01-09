using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Command;
using Enee.Core.Domain.Repository;
using EneePrueba.Domain.Prueba.PrioridadTareas.Projections;
using EneePrueba.Domain.Prueba.TipoTareas.CrearTarea;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;

namespace EneePrueba.Domain.Prueba.PrioridadTareas.CrearPrioridad;

public class PrioridadTareaCommandHandler : ICommandHandler<PrioridadTareaCommand>
{
    private readonly IWritableRepository<PrioridadTarea> Repository;

    public PrioridadTareaCommandHandler(IWritableRepository<PrioridadTarea> repository)
    {
        Repository = repository;
    }

    public async Task Handle(PrioridadTareaCommand command)
    {
        var entity = new PrioridadTarea(command.Id, command.Nombre);
        await Repository.Create(entity);
    }
}

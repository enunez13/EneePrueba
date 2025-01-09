using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Command;
using Enee.Core.Domain.Repository;
using EneePrueba.Domain.Prueba.EstadoTareas.Projections;
using EneePrueba.Domain.Prueba.TipoTareas.CrearTarea;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;

namespace EneePrueba.Domain.Prueba.EstadoTareas.CreateEstadoTarea;

public class EstadoTareaCommandHandler : ICommandHandler<EstadoTareaCommand>
{
    private readonly IWritableRepository<EstadoTarea> Repository;

    public EstadoTareaCommandHandler(IWritableRepository<EstadoTarea> repository)
    {
        Repository = repository;
    }

    public async Task Handle(EstadoTareaCommand command)
    {
        var entity = new EstadoTarea(command.Id, command.Nombre);
        await Repository.Create(entity);
    }
}

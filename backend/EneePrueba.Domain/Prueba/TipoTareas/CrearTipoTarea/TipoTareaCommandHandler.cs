using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Command;
using Enee.Core.Domain.Repository;
using Enee.Core.Domain.Specs;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;

namespace EneePrueba.Domain.Prueba.TipoTareas.CrearTarea;

public class TipoTareaCommandHandler : ICommandHandler<TipoTareaCommand>
{
    private readonly IWritableRepository<TipoTarea> Repository;

    public TipoTareaCommandHandler(IWritableRepository<TipoTarea> repository)
    {
        Repository = repository;
    }

    public async Task Handle(TipoTareaCommand command)
    {
        var entity = new TipoTarea(command.Id, command.Nombre);
        await Repository.Create(entity);
    }
}

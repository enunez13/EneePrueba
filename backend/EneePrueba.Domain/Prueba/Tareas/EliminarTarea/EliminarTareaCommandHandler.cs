using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Command;
using Enee.Core.Domain.Repository;
using EneePrueba.Domain.Modules.Factura.Features.EliminarFactura;
using EneePrueba.Domain.Prueba.Tareas.Projections;

namespace EneePrueba.Domain.Prueba.Tareas.EliminarTarea;

public class EliminarTareaCommandHandler(IWritableEventStoreRepository<TareaRoot> facturas)
    : ICommandHandler<EliminarTareaCommand>
{
    public async Task Handle(EliminarTareaCommand command)
    {
        TareaRoot tarea = await facturas.Find(command.Id);
        tarea.Eliminar();
        await facturas.Update(tarea);
    }
}

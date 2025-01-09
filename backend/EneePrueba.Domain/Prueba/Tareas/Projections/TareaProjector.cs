using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Query;
using Enee.Core.Domain.Repository;
using EneePrueba.Domain.Modules.Factura.Features.EliminarFactura;
using EneePrueba.Domain.Prueba.Tareas.CrearTarea;
using EneePrueba.Domain.Prueba.Tareas.EditarTareas;
using EneePrueba.Domain.Prueba.Tareas.EliminarTarea;

namespace EneePrueba.Domain.Prueba.Tareas.Projections;

public class TareaProjector : TableProjector<Tarea>
{
    public TareaProjector(IWritableRepository<Tarea> tarea)
    {
        Create<TareaCreado>(
            (evento, documento) =>
            {
                documento.Id = evento.AggregateId;
                documento.Nombre = evento.Nombre;
                documento.Descripcion = evento.Descripcion;
                documento.FechaInicio = evento.FechaInicio;
                documento.FechaFin = evento.FechaFin;
                documento.TipoTareaId = evento.TipoTareaId;
                documento.EstadoId = evento.EstadoId;
                documento.PrioridadId = evento.PrioridadId;
            }
        );
        Project<TareaEditado>(
            (evento, documento) =>
            {
                documento.Id = evento.AggregateId;
                documento.Nombre = evento.Nombre;
                documento.Descripcion = evento.Descripcion;
                documento.FechaInicio = evento.FechaInicio;
                documento.FechaFin = evento.FechaFin;
                documento.TipoTareaId = evento.TipoTareaId;
                documento.EstadoId = evento.EstadoId;
                documento.PrioridadId = evento.PrioridadId;
            }
        );
        SoftDeleted<TareaEliminar>();
    }
}

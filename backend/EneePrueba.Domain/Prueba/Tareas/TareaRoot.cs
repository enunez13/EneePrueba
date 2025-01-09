using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.Domain;
using EneePrueba.Domain.Modules.Factura.Features.EliminarFactura;
using EneePrueba.Domain.Prueba.Tareas.CrearTarea;
using EneePrueba.Domain.Prueba.Tareas.EditarTareas;
using EneePrueba.Domain.Prueba.Tareas.EliminarTarea;
using EneePrueba.Domain.Prueba.Tareas.Projections;

namespace EneePrueba.Domain.Prueba.Tareas;

public class TareaRoot : AggregateRoot<Guid>
{
    public override Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public DateOnly FechaInicio { get; set; }
    public DateOnly FechaFin { get; set; }
    public Guid TipoTareaId { get; set; }
    public Guid EstadoId { get; set; }
    public Guid PrioridadId { get; set; }

    public TareaRoot() { }

    public TareaRoot(
        Guid Id,
        string Nombre,
        string Descripcion,
        DateOnly FechaInicio,
        DateOnly FechaFin,
        Guid TipoTareaId,
        Guid EstadoId,
        Guid PrioridadId
    )
    {
        Apply(
            NewChange(
                new TareaCreado(
                    Id,
                    Nombre,
                    Descripcion,
                    FechaInicio,
                    FechaFin,
                    TipoTareaId,
                    EstadoId,
                    PrioridadId
                )
            )
        );
    }

    private void Apply(TareaCreado @event)
    {
        Id = @event.AggregateId;
        Nombre = @event.Nombre;
        Descripcion = @event.Descripcion;
        FechaInicio = @event.FechaInicio;
        FechaFin = @event.FechaFin;
        TipoTareaId = @event.TipoTareaId;
        EstadoId = @event.EstadoId;
        PrioridadId = @event.PrioridadId;
        Version++;
    }

    public void Editar(
        string nombre,
        string descripcion,
        DateOnly fechaInicio,
        DateOnly fechaFin,
        Guid tipoTareaId,
        Guid estadoId,
        Guid prioridadId
    )
    {
        TareaEditado editar =
            new(Id, nombre, descripcion, fechaInicio, fechaFin, tipoTareaId, estadoId, prioridadId);

        Apply(NewChange(editar));
    }

    private void Apply(TareaEditado @event)
    {
        Id = @event.AggregateId;
        Nombre = @event.Nombre;
        Descripcion = @event.Descripcion;
        FechaInicio = @event.FechaInicio;
        FechaFin = @event.FechaFin;
        TipoTareaId = @event.TipoTareaId;
        EstadoId = @event.EstadoId;
        PrioridadId = @event.PrioridadId;
        Version++;
    }

    public void Eliminar()
    {
        Apply(NewChange(new TareaEliminar(Id)));
    }

    private void Apply(TareaEliminar @event)
    {
        Version++;
    }
}

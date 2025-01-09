using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.Common;

namespace EneePrueba.Domain.Prueba.Tareas.EditarTareas;

internal class TareaEditado : DomainEvent<Guid>
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public DateOnly FechaInicio { get; set; }
    public DateOnly FechaFin { get; set; }
    public Guid TipoTareaId { get; set; }
    public Guid EstadoId { get; set; }
    public Guid PrioridadId { get; set; }

    public TareaEditado(
        Guid aggregateId,
        string nombre,
        string descripcion,
        DateOnly fechaInicio,
        DateOnly fechaFin,
        Guid tipoTareaId,
        Guid estadoId,
        Guid prioridadId
    )
        : base(aggregateId)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        FechaInicio = fechaInicio;
        FechaFin = fechaFin;
        TipoTareaId = tipoTareaId;
        EstadoId = estadoId;
        PrioridadId = prioridadId;
    }
}

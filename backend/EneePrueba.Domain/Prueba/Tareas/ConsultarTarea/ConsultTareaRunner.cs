using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;
using Enee.Core.CQRS.Query;
using Enee.Core.Domain.Repository;
using Enee.Core.Domain.Specs;
using EneePrueba.Domain.Prueba.Tareas.Projections;

namespace EneePrueba.Domain.Prueba.Tareas.ConsultarTarea;

public class ConsultTareaRunner(IReadOnlyRepository<Tarea> repository)
    : IQueryRunner<ConsultaTareaQuery, ConsultaTareaDTO>
{
    public async Task<ConsultaTareaDTO> Run(ConsultaTareaQuery queryto)
    {
        ConsultaTareaDTO tareaModel = null;
        var spec = new SpecificationGeneric<Tarea>();

        spec.Query.Where(x => x.Nombre == queryto.Nombre);

        Tarea result = await repository.FirstOrDefault(spec);

        if (result != null)
        {
            tareaModel = new()
            {
                Nombre = result.Nombre,
                Descripcion = result.Descripcion,
                FechaInicio = result.FechaInicio,
                FechaFin = result.FechaFin,
                TipoTareaId = result.TipoTareaId,
                EstadoId = result.EstadoId,
                PrioridadId = result.PrioridadId
            };
        }

        return tareaModel;
    }
}

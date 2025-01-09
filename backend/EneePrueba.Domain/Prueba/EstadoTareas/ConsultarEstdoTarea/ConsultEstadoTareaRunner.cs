using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;
using Enee.Core.CQRS.Query;
using Enee.Core.Domain.Repository;
using Enee.Core.Domain.Specs;
using EneePrueba.Domain.Prueba.EstadoTareas.Projections;
using EneePrueba.Domain.Prueba.TipoTareas.ConsultarTipoTarea;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;

namespace EneePrueba.Domain.Prueba.EstadoTareas.ConsultarEstdoTarea;

internal class ConsultEstadoTareaRunner(IReadOnlyRepository<EstadoTarea> repository)
    : IQueryRunner<ConsultaEstadoTareaQuery, ConsultaParametrosDTO>
{
    public async Task<ConsultaParametrosDTO> Run(ConsultaEstadoTareaQuery queryto)
    {
        ConsultaParametrosDTO tipoTareaModel = null;
        var spec = new SpecificationGeneric<EstadoTarea>();

        spec.Query.Where(x => x.Nombre == queryto.Nombre);

        EstadoTarea result = await repository.FirstOrDefault(spec);

        if (result != null)
        {
            tipoTareaModel = new() { Nombre = result.Nombre, };
        }

        return tipoTareaModel;
    }
}

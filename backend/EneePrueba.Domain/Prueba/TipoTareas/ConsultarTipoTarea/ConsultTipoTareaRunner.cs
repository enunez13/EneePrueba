using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;
using Enee.Core.CQRS.Query;
using Enee.Core.Domain.Repository;
using Enee.Core.Domain.Specs;
using EneePrueba.Domain.Prueba.Tareas.ConsultarTarea;
using EneePrueba.Domain.Prueba.Tareas.Projections;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;

namespace EneePrueba.Domain.Prueba.TipoTareas.ConsultarTipoTarea;

public class ConsultTipoTareaRunner(IReadOnlyRepository<TipoTarea> repository)
    : IQueryRunner<ConsultaTipoTareaQuery, ConsultaParametrosDTO>
{
    public async Task<ConsultaParametrosDTO> Run(ConsultaTipoTareaQuery queryto)
    {
        ConsultaParametrosDTO tipoTareaModel = null;
        var spec = new SpecificationGeneric<TipoTarea>();

        spec.Query.Where(x => x.Nombre == queryto.Nombre);

        TipoTarea result = await repository.FirstOrDefault(spec);

        if (result != null)
        {
            tipoTareaModel = new() { Nombre = result.Nombre, };
        }

        return tipoTareaModel;
    }
}

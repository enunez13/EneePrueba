using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;
using Enee.Core.CQRS.Query;
using Enee.Core.Domain.Repository;
using Enee.Core.Domain.Specs;
using EneePrueba.Domain.Prueba.PrioridadTareas.Projections;
using EneePrueba.Domain.Prueba.TipoTareas.ConsultarTipoTarea;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;

namespace EneePrueba.Domain.Prueba.PrioridadTareas.ConsultaPrioridad;

public class ConsultPrioridadTareaRunner(IReadOnlyRepository<PrioridadTarea> repository)
    : IQueryRunner<ConsultaPrioridadTareaQuery, ConsultaParametrosDTO>
{
    public async Task<ConsultaParametrosDTO> Run(ConsultaPrioridadTareaQuery queryto)
    {
        ConsultaParametrosDTO tipoTareaModel = null;
        var spec = new SpecificationGeneric<PrioridadTarea>();

        spec.Query.Where(x => x.Nombre == queryto.Nombre);

        PrioridadTarea result = await repository.FirstOrDefault(spec);

        if (result != null)
        {
            tipoTareaModel = new() { Nombre = result.Nombre, };
        }

        return tipoTareaModel;
    }
}

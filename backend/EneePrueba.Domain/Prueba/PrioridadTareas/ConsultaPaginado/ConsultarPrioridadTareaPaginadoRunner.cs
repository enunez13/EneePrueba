using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Query;
using Enee.Core.Domain;
using Enee.Core.Domain.Repository;
using Enee.Core.Domain.Specs;
using EneePrueba.Domain.Prueba.PrioridadTareas.Projections;
using EneePrueba.Domain.Prueba.TipoTareas.ConsultaPaginado;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;

namespace EneePrueba.Domain.Prueba.PrioridadTareas.ConsultaPaginado;

internal class ConsultarPrioridadTareaPaginadoRunner
    : IQueryRunner<ConsultaPrioridadTareaPaginadoQuery, IPaginated<ConsultaParametrosDTO>>
{
    private readonly IReadOnlyRepository<PrioridadTarea> repository;

    public ConsultarPrioridadTareaPaginadoRunner(IReadOnlyRepository<PrioridadTarea> repository)
    {
        this.repository = repository;
    }

    public async Task<IPaginated<ConsultaParametrosDTO>> Run(
        ConsultaPrioridadTareaPaginadoQuery query
    )
    {
        var spec = new SpecificationGeneric<PrioridadTarea>();
        IPaginated<PrioridadTarea> list = await repository.Paginate(
            query.Page,
            query.PageSize,
            spec
        );

        var destinatariosResult = new ParametrosPaginadoDTO
        {
            CurrentPage = list.CurrentPage,
            PageSize = list.PageSize,
            RowCount = list.RowCount,
            PageCount = list.PageCount,
            FirstRowOnPage = list.FirstRowOnPage,
            LastRowOnPage = list.LastRowOnPage,
            Data = list.Data.Select(x => new ConsultaParametrosDTO { Nombre = x.Nombre, }).ToList()
        };

        return destinatariosResult;
    }
}

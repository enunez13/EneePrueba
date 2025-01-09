using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Query;
using Enee.Core.Domain;
using Enee.Core.Domain.Repository;
using Enee.Core.Domain.Specs;
using EneePrueba.Domain.Prueba.Tareas.ConsultarTarea;
using EneePrueba.Domain.Prueba.Tareas.Projections;
using EneePrueba.Domain.Prueba.TipoTareas.ConsultaPaginado;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;

namespace EneePrueba.Domain.Prueba.Tareas.ConsultaPaginado;

public class ConsultarTareaPaginadoRunner
    : IQueryRunner<ConsultaTareaPaginadoQuery, IPaginated<ConsultaTareaDTO>>
{
    private readonly IReadOnlyRepository<Tarea> repository;

    public ConsultarTareaPaginadoRunner(IReadOnlyRepository<Tarea> repository)
    {
        this.repository = repository;
    }

    public async Task<IPaginated<ConsultaTareaDTO>> Run(ConsultaTareaPaginadoQuery query)
    {
        var spec = new SpecificationGeneric<Tarea>();
        IPaginated<Tarea> list = await repository.Paginate(query.Page, query.PageSize, spec);

        var destinatariosResult = new TareaPaginadoDTO
        {
            CurrentPage = list.CurrentPage,
            PageSize = list.PageSize,
            RowCount = list.RowCount,
            PageCount = list.PageCount,
            FirstRowOnPage = list.FirstRowOnPage,
            LastRowOnPage = list.LastRowOnPage,
            Data = list.Data.Select(x => new ConsultaTareaDTO { Nombre = x.Nombre, }).ToList()
        };

        return destinatariosResult;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Query;
using Enee.Core.Domain;
using Enee.Core.Domain.Repository;
using Enee.Core.Domain.Specs;
using EneePrueba.Domain.Prueba.EstadoTareas.Projections;
using EneePrueba.Domain.Prueba.TipoTareas.ConsultaPaginado;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;

namespace EneePrueba.Domain.Prueba.EstadoTareas.ConsultaPaginado
{
    public class ConsultarEstadoTareaPaginadoRunner
        : IQueryRunner<ConsultaEstadoTareaPaginadoQuery, IPaginated<ConsultaParametrosDTO>>
    {
        private readonly IReadOnlyRepository<EstadoTarea> repository;

        public ConsultarEstadoTareaPaginadoRunner(IReadOnlyRepository<EstadoTarea> repository)
        {
            this.repository = repository;
        }

        public async Task<IPaginated<ConsultaParametrosDTO>> Run(
            ConsultaEstadoTareaPaginadoQuery query
        )
        {
            var spec = new SpecificationGeneric<EstadoTarea>();
            IPaginated<EstadoTarea> list = await repository.Paginate(
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
                Data = list.Data.Select(x => new ConsultaParametrosDTO { Nombre = x.Nombre, })
                    .ToList()
            };

            return destinatariosResult;
        }
    }
}

using Ardalis.Specification;
using Enee.Core.CQRS.Query;
using Enee.Core.Domain;
using Enee.Core.Domain.Repository;
using Enee.Core.Domain.Specs;
using EneePrueba.Domain.Modules.Almacen.Projections.Almacen;

namespace EneePrueba.Domain.Modules.Almacen.Features.ConsultarAlmacen;

public class ConsultaAlmacenPaginadoRunner
    : IQueryRunner<ConsultaAlmacenPaginado, IPaginated<AlmacenDocumento>>
{
    public IReadOnlyDocumentRepository<AlmacenDocumento> Repository { get; }

    public ConsultaAlmacenPaginadoRunner(IReadOnlyDocumentRepository<AlmacenDocumento> repository)
    {
        Repository = repository;
    }

    public async Task<IPaginated<AlmacenDocumento>> Run(ConsultaAlmacenPaginado query)
    {
        var spec = new SpecificationGeneric<AlmacenDocumento>();
        spec.Query.Where(
            x => x.NombreSucursal.Contains(query.NombreSucursal),
            !string.IsNullOrWhiteSpace(query.NombreSucursal)
        );
        spec.Query.OrderBy(x => x.NombreSucursal);
        IPaginated<AlmacenDocumento>? paginated = await Repository.Paginate(
            query.Page,
            query.PageSize,
            spec
        );
        return paginated;
    }
}

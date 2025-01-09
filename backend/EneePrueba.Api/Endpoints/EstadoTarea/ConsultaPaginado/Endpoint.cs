using Enee.Core.CQRS.Query;
using Enee.Core.Domain;
using EneePrueba.Domain.Prueba;
using EneePrueba.Domain.Prueba.EstadoTareas.ConsultaPaginado;
using EneePrueba.Domain.Prueba.TipoTareas.ConsultaPaginado;

namespace EneePrueba.Api.Endpoints.EstadoTarea.ConsultaPaginado;

public static class Endpoint
{
    public static void ConsultarEstadoPaginados(this IEndpointRouteBuilder app)
    {
        app.MapGet(
                "/",
                async (
                    [AsParameters] ConsultaEstadoTareaPaginadoQuery query,
                    IQueryDispatcher dispatcher
                ) =>
                {
                    IPaginated<ConsultaParametrosDTO> result = await dispatcher.Execute(query);
                    return result;
                }
            )
            .Produces<IPaginated<ConsultaParametrosDTO>>()
            .WithSummary("Obtiene listado de Estado Tarea paginados")
            .WithDescription("Listar estado Tarea  pagina.")
            .WithOpenApi();
    }
}

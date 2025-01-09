using Enee.Core.CQRS.Query;
using Enee.Core.Domain;
using EneePrueba.Domain.Prueba;
using EneePrueba.Domain.Prueba.PrioridadTareas.ConsultaPaginado;
using EneePrueba.Domain.Prueba.TipoTareas.ConsultaPaginado;

namespace EneePrueba.Api.Endpoints.PrioridadTarea.ConsultaPaginado;

public static class Endpoint
{
    public static void ConsultarPrioridadPaginados(this IEndpointRouteBuilder app)
    {
        app.MapGet(
                "/",
                async (
                    [AsParameters] ConsultaPrioridadTareaPaginadoQuery query,
                    IQueryDispatcher dispatcher
                ) =>
                {
                    IPaginated<ConsultaParametrosDTO> result = await dispatcher.Execute(query);
                    return result;
                }
            )
            .Produces<IPaginated<ConsultaParametrosDTO>>()
            .WithSummary("Obtiene listado de Prioridad Tarea paginados")
            .WithDescription("Listar Prioridad Tarea  pagina.")
            .WithOpenApi();
    }
}

using Enee.Core.CQRS.Query;
using Enee.Core.Domain;
using EneePrueba.Domain.Prueba;
using EneePrueba.Domain.Prueba.TipoTareas.ConsultaPaginado;

namespace EneePrueba.Api.Endpoints.TipoTarea.ConsultaPaginado;

public static class Endpoint
{
    public static void ConsultarTipoPaginados(this IEndpointRouteBuilder app)
    {
        app.MapGet(
                "/",
                async (
                    [AsParameters] ConsultaTipoTareaPaginadoQuery query,
                    IQueryDispatcher dispatcher
                ) =>
                {
                    IPaginated<ConsultaParametrosDTO> result = await dispatcher.Execute(query);
                    return result;
                }
            )
            .Produces<IPaginated<ConsultaParametrosDTO>>()
            .WithSummary("Obtiene listado de Tipo Tarea paginados")
            .WithDescription("Listar Tipo Tarea  pagina.")
            .WithOpenApi();
    }
}
